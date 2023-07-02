using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UnityEngine.SocialPlatforms;
using UnityEngine;
using Pml;
using Dpr.Trainer;
using DPData;
using Dpr.UI;
using SmartPoint.AssetAssistant;

namespace Dpr.EvScript
{
    public class EvDataManager
    {
        private const string Path_Parsons = "persons/field/";
        private const string Path_Poke_Model = "pokemons/field/";
        private const int Graphic_Gimmick = 500;
        private const int Graphic_Poke = 10000;
        private const float HitMinSize = 3f;
        private const int Graphic_SekiZou = 1000;
        private const int Graphic_SekiZouMAX = 3000;
        private const int WarpListLength = 30;
        private const int EntityParamLength = 50;
        private const int FieldObjectMoveCodesLength = 200;
        private const int TRAINER_EYE_HITMAX = 2;
        private const int SCR_EYE_TR_TYPE_SINGLE = 0;
        private const int SCR_EYE_TR_TYPE_DOUBLE = 1;
        private const int SCR_EYE_TR_TYPE_TAG = 2;
        private const float _fallSpd = 0.25f;
        private const float _fallOffset = 15f;
        private const float _fallRotSpd = 35f;
        private const float _fallDiveSpd = 15f;
        private const float _fallDiveAcce = 0.1f;
        private const float _fromRotSpd = 50f;
        private const float _fromRotAcce = 4f;
        private const float _fromRotSpdMin = 10f;
        private const float _const_cloudTime = 5f;
        private const float _app_frame = 0.033333335f;
        private const int _WORK_TRUE = 1;
        private const int _WORK_FALSE = 0;
        private const string SEQ_SE_DP_SELECT = "UI_common_decide";
        private const int TRMSG_FIGHT_START = 0;
        private const int TRMSG_FIGHT_LOSE = 1;
        private const int TRMSG_FIGHT_AFTER = 2;
        private const int TRMSG_FIGHT_START_1 = 3;
        private const int TRMSG_FIGHT_LOSE_1 = 4;
        private const int TRMSG_FIGHT_AFTER_1 = 5;
        private const int TRMSG_POKE_ONE_1 = 6;
        private const int TRMSG_FIGHT_START_2 = 7;
        private const int TRMSG_FIGHT_LOSE_2 = 8;
        private const int TRMSG_FIGHT_AFTER_2 = 9;
        private const int TRMSG_POKE_ONE_2 = 10;
        private const int TRMSG_FIGHT_NONE_DN = 11;
        private const int TRMSG_FIGHT_NONE_D = 12;
        private const int TRMSG_FIGHT_FIRST_DAMAGE = 13;
        private const int TRMSG_FIGHT_POKE_HP_HALF = 14;
        private const int TRMSG_FIGHT_POKE_LAST = 15;
        private const int TRMSG_FIGHT_POKE_LAST_HP_HALF = 16;
        private const int TRMSG_REVENGE_FIGHT_START = 17;
        private const int TRMSG_REVENGE_FIGHT_START_1 = 18;
        private const int TRMSG_REVENGE_FIGHT_START_2 = 19;
        private const int MUGEN_LOOP = 5000;
        private const int RockClimbSequence_None = 0;
        private const int RockClimbSequence_JumpUp = 1;
        private const int RockClimbSequence_JumpLoop = 2;
        private const int RockClimbSequence_Climb = 3;
        private const int RockClimbSequence_EndJumpUp = 4;
        private const int RockClimbSequence_EndJumpLoop = 5;
        private const int RockClimbSequence_EndJumpEnd = 6;
        private const int FashionSeq_Reqest = 0;
        private const int FashionSeq_Wait = 1;
        private const int FashionSeq_End = 2;
        private const int FashionSeq_Error = 999;
        private const int LIGHT_FILED = 0;
        private const int LIGHT_CHAR = 1;
        private const int LIGHT_POKE = 2;
        private const int LIGHT_MAX = 3;
        private const int FieldObjectEntityLength = 100;
        private const int FieldKinomiGrowEntityLength = 30;
        private const int _PoolLength = 100;

        private static EvDataManager _instanse;
        public static bool IsFirstInitializedAfterSaveDataLoad;
        private static Dictionary<int, MonsNo> KasekiFukugenTable;
        private static ValueTuple<int, int, int>[] PokemonSizeTable;
        public static bool EventCameraEnable;

        private Action<EntityParam> OnTalkStartCallBack;
        private bool _isScriptLoad;
        private EvScriptData[] _eventList;
        private int _eventListIndex;
        private Stack<EvCallData> _callQueue;
        private Dictionary<string, int[]> _findAllLabel;
        private GameObject _hit_object; // FieldObjectEntity
        private GameObject _hit_object_sub; // FieldObjectEntity
        private Vector3 _hit_position;
        private CmpResult _cmp_flag;
        private GameObject _scriptOperation; // AssetRequestOperation
        private AreaID _areaID;
        private List<GameObject> _warpList; // List<FieldEventEntity>
        private GameObject _warpData; // MapWarp
        private GameObject _warpRoot;
        private PlaySeData[] _se_datas;
        private PlaySeData[] _voice_datas;
        private Vector2Int _eventEndPosition;
        private string _posEventLabelReserve;
        private EntityParam[] _entityParamList;
        private GameObject _stopRoot;
        private bool _isInitFirstMap;
        private UpdateDelegate _updateDelegate;
        private EventEndDelegate _eventEndDelegate;
        private GameObject _doorEntity; // FieldEventDoorEntity
        private WorpEventData _worpEventData;
        private Vector2Int _eqZoneWorpGrid;
        private bool _isEqZoneWorp;
        private GameObject _liftEntity; // FieldEventLiftEntity
        private GameObject _tobariGymWallEntity; // FieldTobariGymWallEntity
        private GameObject _nagisaGymGearEntity; // FieldNagisaGymGearEntity
        private GameObject _nomoseGymSwitchEntity; // FieldNomoseGymSwitchEntity
        private GameObject _eyePaintingEntity; // FieldEyePaintingEntity
        private GameObject _embankmentEntity; // FieldEmbankmentEntity
        private GameObject _mistPlate; // FieldMistPlate
        private bool AzukariyaInitEventFlag;
        private int[] TvCommercials;
        private int TvCommercialsCurrentIndex;
        private string _callLabel_SceneChange;
        private string _callLabel_UpdateSP;
        private string _callLabel_AdjustHeroPos;
        public List<GameObject> FieldObjectMoveCodes; // List<FieldObjectMoveCode>
        private bool _lateUpdateMoveCode;
        private bool _isCall_TrainerBtl;
        private EvCallData _battleReturnData;
        private GameObject _battleReturnHitObject; // FieldObjectEntity
        private GameObject[] _eyeEncountTarget; // FieldObjectMoveCode[]
        private GameObject[] _eyeEncountBallon; // Balloon[]
        private float _eyeEncountWait;
        private int _eyeEncountSeq;
        private int[] _talkTrinerIndex;
        public TrainerType Btl_TrainerType1;
        public TrainerType Btl_TrainerType2;
        private int _ugSeq;
        private Vector3 _ugEndPos;
        private Vector3 _ugHoleRot;
        private float _ugFallSpdCurrent;
        private int _ugDiveSeq;
        private float _ugDiveUpdateTime;
        private float _ugDiveRotTime;
        private float _ugDiveRotStart;
        private float _ugDiveRotEnd;
        private float _ugDiveJumpingTime;
        private int _ugFromSeq;
        private float _ugFromJumpTime;
        private float _ugFromRotSpdCurrent;
        private GameObject _ugNextJumpPos; // UgJumpPos.SheetData
        private GameObject _toUgInvisibleObjects; // FieldToUgInvisibleObjects
        private ZoneID _cacheZoneID_SceneChange;
        private bool _pendingInitScripts;
        public ZoneID SorawotobuZoneId;
        public int SorawotobuLocatorIndex;
        private EventCameraTable _evCameraTable;
        private GameObject _tairyouHasseiMane; // TairyouHasseiPokeManager
        private bool _isFadeEventReturnInput;
        private float _cloudSpeed;
        private float _cloudTime;
        private int _switch_work_index;
        private float _timeWait;
        private GameObject _msgWindowParam; // MsgWindowParam
        private GameObject _msgWindowParamOther; // MsgWindowParam
        private MsgOpenParam _msgOpenParam;
        private bool _isAutoMsg;
        private MSGSPEED _eMsgSpeed;
        private float _autoTime;
        private BOARD _boardState;
        private GameObject _msgWindow; // MsgWindow
        private GameObject _msgWindowOther; // MsgWindow
        private Coroutine _msgWindowCoroutine;
        private TalkState _talkStart;
        private EvCmdID.NAME _macroCmd;
        private EvCmdID.NAME _procCmd;
        private string _talkOpenMsbt;
        private string _talkOpenLabel;
        private float _turnEndFrame_Hero;
        private float _turnEndFrame_Obj;
        private float[] _turnTime;
        private Quaternion[] _turnEndQuaternion;
        private bool[] _turnDiffFlag;
        private float _deltatime;
        private string _mapChangeZoneID;
        private int _mapChangeIndex;
        private Quaternion _moveGridCenterStart;
        private Quaternion _moveGridCenterEnd;
        private bool _isOpenSubContentsMenu;
        private bool _isWaitCheckOnlineAccount;
        private string _custumWindow_msbt;
        private List<string> _custumWindow_Labels;
        private List<int> _custumWindow_RetIndex;
        private GameObject _selectDoorObject; // FieldEventEntity
        private float _fadeSpeed;
        private HeroReqBit _heroReqBit;
        private DIR _heroMoveGridCenterFrontDir;
        private bool _heroMoveGridCenterFrontStat;
        private GameObject _fieldObjectMove; // FieldObjectMove
        private GameObject _fieldObjectRotateYaw; // FieldObjectRotateYaw
        private GameObject _fieldFloatMove; // FieldFloatMove
        private int _hidenSequence;
        private Vector3 _takiTargetPosition;
        private Vector3 _rockClimbingEndPos;
        private Vector3 _rockClimbingStandPos;
        private bool _hidenEffectWait;
        private bool _rideBicycleReserve;
        private GameObject _runEventLiftEntity; // FieldEventLiftEntity
        private int _liftSequence;
        private int _gearSequence;
        private int _waterSequence;
        private int _kinomiSequence;
        private float _kinomiSequenceTime;
        private GameObject _kinomiEffect; // EffectInstance
        private int _warpSequence;
        private int _warpSpeedSequence;
        private float _warpSpeedSequenceTime;
        private int _scopeSequence;
        private int _azukariyaSequence;
        private int _pokelistSequence;
        private int _pokelistBox;
        private int _pokelistIndex;
        private int _trainSequence;
        private int _itemSequence;
        private int _btwrSequence;
        private bool _isOpenSpecialWin;
        private int _openSpecialWinLabelSelected;
        private TV_PROGRAM _currentTvProgram;
        private CutInState _cutinState;
        private bool _isShopOpen;
        private int _bagSelectItemNo;
        private GameObject _floorWindow; // FloorWindow
        private GameObject _moneyWindow; // MoneyWindow
        private StringBuilder matchingPassword;
        private int _openTownMapSeq;
        private bool _isOpenBtlTowerRecode;
        private int _softwareKeyboardSubState;
        private int _effSeq;
        private bool _pc_window_close;
        private int _dendou;
        private GameObject[] _umaAnimatorCtr; // FieldAnimatorController[]
        private bool _isOpenCustomBallTrainer;
        private int _nicknamePlacementSequence;
        private GameObject[] _scriptEffects; // EffectInstance[]
        private Coroutine[] _scriptScaleCorutine;
        private bool[] _scriptScaleVectol;
        private GameObject _temp_PokePara; // PokemonParam
        private bool _isBattleTowerBtl;
        private bool _isBattleTowerWin;
        private Vector2 _playerMoveGridCenterAngle;
        private EvScriptData _evData;
        private EvData.Script _evScript;
        private EvData.Command _evCommand;
        private EvData.Aregment[] _evArg;
        private int btlsearchSeq;
        private GameObject btlserchAudio; // AudioInstance
        private bool _isOpenHallOfFame;
        private Coroutine _cmdReportSaveCoroutine;
        private int _seqRankingView;
        private bool _isOpenCertificate;
        private int returnSequenceID;
        private bool _boukennootoTipsOpen;
        private int _fashionLoadSeq;
        private string _oldfashionAssetReqUri;
        private GameObject _fashionAssetReqOp; // AssetRequestOperation
        private float _fashionYawAngle;
        private Vector3 _fashionWorldpos;
        private bool _isTraining;
        private bool _isOpenTraining;
        private float[] _setlight_timer;
        private float[] _setlight_timer_limit;
        private float[] _start_lightIntensity;
        private float[] _end_lightIntensity;
        private bool[] _isRunningLight;
        public List<string> Debug_01_DebugLabel;
        public List<string> DebugSceneEventLabel;
        public List<GameObject> _fieldObjectEntity; // List<FieldObjectEntity>
        public List<GameObject> _FieldKinomiGrowEntity; // List<FieldKinomiGrowEntity>
        private List<AssetReqOpeRef> _AssetReqOpeList;
        private List<EvDataManager.LoadObjectData> _loadObjectList;
        private int _loadObjectIndex;
        private Transform _loadObjectParent;
        private bool _nowInstantiate;

        private Dictionary<int, GameObject> _poolLoadObjects;

        public static EvDataManager Instanse
        {
            get
            {
                return null;
            }
        }

        public bool IsPosEventReserved
        {
            get
            {
                return false;
            }
        }

        public GameObject _dummyPlayer // FieldObjectEntity
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public GameObject PokemonCenter // FieldPokemonCenter
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public GameObject Telescope // Telescope
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public GameObject TelescopeNagisa // TelescopeNagisa
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public GameObject FieldWazaCutIn // FieldWazaCutIn
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public GameObject InterviewWork // InterviewWork
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public GameObject FieldShip // FieldShip
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        private enum CmpResult
        {
            MINUS = 0,
            EQUAL = 1,
            PLUS = 2
        }

        public enum EntityType
        {
            Stop = 0,
            Warp = 1,
            Board = 2,
            Npc = 3
        }

        private enum MsgWindowType
        {
            DEFAULT = 0,
            NAME_PLATE = 1,
            BOARD_TYPE_TOWN = 2,
            BOARD_TYPE_ROAD = 3,
            BOARD_TYPE_POST = 4,
            BOARD_TYPE_INFO = 5,
            ITEM = 6,
            END = 7
        }

        private enum MsgEndType
        {
            Input = 0,
            Auto = 1,
            Time = 2,
            Manual = 3
        }

        private enum BOARD
        {
            BOARD_REQ_WAIT = 0,
            BOARD_REQ_ADD = 1,
            BOARD_REQ_DOWN = 2,
            BOARD_REQ_UP = 3,
            BOARD_REQ_DEL = 4,
            END = 5
        }

        private enum TalkState
        {
            Init = 0,
            EndWait = 1,
            CloseWait = 2
        }

        private enum HeroReqBit
        {
            Non = 0,
            Normal = 1,
            Banzai = 256
        }

        private enum CutInState
        {
            None = 0,
            ResetForm = 1,
            PostResetForm = 2,
            Rotate = 3,
            PoketchAnimeStart = 4,
            WaitLoad = 5,
            WaitCutIn = 6,
            Sorawotobu_WaitPlayEffect = 7,
            Sorawotobu_WaitPreCaptureInvisible = 8,
            Sorawotobu_WaitNextCommand = 9,
            PoketchAnimeEnd = 10,
            End = 11
        }

        private struct EvCallData
        {
            public int EventListIndex;
            public int LabelIndex;
            public int CommandIndex;
        }

        private struct PlaySeData
        {
            public string name;
            public GameObject AudioInstance; // AudioInstance
            public uint playEventId;
        }

        private struct WorpEventData
        {
            public GameObject Entity; // FieldEventDoorEntity
            public int State;
            public float Time;
        }

        private struct MsgOpenParam
        {
	        public string MsbtFile;
            public string Label;
            public int LabelIndex;
            public MsgWindowType WindowType;
            public bool Input;
            public string[] TrainerName;
            public MsgEndType EndType;
            public bool PlayTextFeedSe;
        }

        public class EntityParam
        {
            public const int NearNone = -10;

            public string TalkLabel;
            public string ContactLabel;
            public int VanishFlagIndex;
            public bool IsContact;
            public EvWork.WORK_INDEX WorkIndex;
            public int WorkValue;
            public EntityType Type;
            public RectInt StopGridArea;
            public bool IsEventRunning;
            public int MoveCodeIndex;
            public bool Kairiki;
            public bool Iwakudaki;
            public bool Iaigiri;
            public bool Rockclimb;
            public int Dowsing;
            public bool SnowBall;
            public bool AzukariyaOldMan;
            public bool HoneyTree;
            public bool HeightIgnore;
            public Vector2 ContactSize;
            public bool IsContactCenter;
            public bool Sit;
            public int IdleAnimOverride;
            public int WalkAnimOverride;
            public TrainerID TrainerID;
            public int FieldObjectIndex;
            public int[] NearObject;
            public float TalkRange;
            public bool isTalkHit;
            public float TalkAngle;
            public bool SaveObject;
            public ZoneID LocaitionZoneID;
            public bool IsObject;
            public Vector2 TalkSegment;
            public byte TalkBit;
            public int CharacterGraphicsIndex;
            public bool BattleReturnNotRotate;

            public EntityParam()
            {
                // TODO
            }
        }

        private class AssetReqOpeRef
        {
	        public GameObject ReqOpe; // AssetRequestOperation
            public int RefCount;
            public bool isEnd;

            public AssetReqOpeRef()
            {
                // TODO
            }
        }

        private class LoadObjectData
        {
	        public bool IsLoadFast;
            public int Distance;
            public bool IsCreated;
            public int AssetReqIndex;
            public string ObjectName;
            public GameObject PlaceData; // PlaceData.SheetData
            public Vector2 Position;
            public float Height;
            public float Angle;
            public int MoveCode;
            public DIR MoveDirHead;
            public int MoveParam0;
            public int MoveParam1;
            public int MoveParam2;
            public int MoveLimitX;
            public int MoveLimitZ;
            public int Ev_Type;
            public int mv_old_dir;
            public int mv_dir;
            public bool useloadData;
            public int replaceGraphicIndex;

            public LoadObjectData()
            {
                // TODO
            }
        }

        public delegate void UpdateDelegate(float time);
        public delegate void EventEndDelegate();

        private void SetCloudScaleStart()
        {
            // TODO
        }

        private void SetCloudScaleEnd()
        {
            // TODO
        }

        private bool EvCmdTimeWait()
        {
            if (_evArg.Length > 1)
            {
                float frames = GetWorkOrFloatValue(_evArg[1]);

                if (_evArg.Length > 2)
                {
                    if (frames * 0.03333334 < _timeWait)
                    {
                        FlagWork.SetWork(_evArg[2].data, 0);
                        return true;
                    }
                    FlagWork.SetWork(_evArg[2].data, 1);
                    _timeWait += _deltatime;
                    return false;
                }
            }

            ThrowIndexOutOfRange();
            return true;
        }

        private bool EvCmdCmpWkWk()
        {
            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return true;
            }

            int workNo1 = GetWorkOrIntValue(_evArg[1]);

            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return true;
            }

            int workNo2 = GetWorkOrIntValue(_evArg[2]);

            int workValue1 = FlagWork.GetWork(workNo1);
            int workValue2 = FlagWork.GetWork(workNo2);

            if (workValue1 < workValue2)
            {
                _cmp_flag = CmpResult.MINUS;
            }
            else if (workValue1 == workValue2)
            {
                _cmp_flag = CmpResult.EQUAL;
            }
            else
            {
                _cmp_flag = CmpResult.PLUS;
                return true;
            }

            _cmp_flag = CmpResult.PLUS; // BUG? Will always be returning work1 as greater
            return true;
        }

        public bool CallLabel(string label)
        {
            if (!string.IsNullOrEmpty(label) && _findAllLabel.ContainsKey(label))
            {
                if (_eventListIndex < _eventList.Length)
                {
                    EvCallData call;
                    call.EventListIndex = _eventListIndex;
                    call.LabelIndex = _eventList[_eventListIndex].LabelIndex;
                    call.CommandIndex = _eventList[_eventListIndex].CommandIndex + 1;
                    _callQueue.Push(call);

                    int[] foundLabel = _findAllLabel[label]; //Probably some struct?
                    if (foundLabel[6] != 0)
                    {
                        int nextEventListIndex = foundLabel[8];
                        if (nextEventListIndex == -1)
                        {
                            SetCloudScaleEnd();
                        }
                        else if (_eventListIndex == -1)
                        {
                            SetCloudScaleStart();
                        }

                        _eventListIndex = nextEventListIndex;
                        if (_eventListIndex < _eventList.Length)
                        {
                            if ((uint)foundLabel[6] > 1)
                            {
                                _eventList[_eventListIndex].LabelIndex = foundLabel[9];
                                _eventList[_eventListIndex].CommandIndex = 0;
                                return true;
                            }
                        }
                    }
                }

                ThrowIndexOutOfRange();
                return false;
            }

            return false;
        }

        public bool ReturnEvData()
        {
            if (_callQueue.Count > 0)
            {
                EvCallData popped = _callQueue.Pop();
                if (popped.EventListIndex == -1)
                {
                    SetCloudScaleEnd();
                }
                else
                {
                    if (_eventListIndex == -1)
                    {
                        SetCloudScaleStart();
                    }
                }

                _eventListIndex = popped.EventListIndex;
                if (_eventListIndex < _eventList.Length)
                {
                    _eventList[popped.EventListIndex].LabelIndex = popped.LabelIndex;
                    _eventList[popped.EventListIndex].CommandIndex = popped.CommandIndex;
                    return true;
                }

                ThrowIndexOutOfRange();
                return false;
            }
            return false;
        }

        public bool JumpLabel(string label, EventEndDelegate callback)
        {
            if (!string.IsNullOrEmpty(label) && _findAllLabel.ContainsKey(label))
            {
                int[] foundLabel = _findAllLabel[label]; //Probably some struct?
                if (foundLabel[6] != 0)
                {
                    int nextEventListIndex = foundLabel[8];
                    if (nextEventListIndex == -1)
                    {
                        SetCloudScaleEnd();
                    }
                    else if (_eventListIndex == -1)
                    {
                        SetCloudScaleStart();
                    }

                    _eventListIndex = nextEventListIndex;
                    if (_eventListIndex < _eventList.Length)
                    {
                        if ((uint)foundLabel[6] > 1)
                        {
                            _eventList[_eventListIndex].LabelIndex = foundLabel[9];
                            _eventList[_eventListIndex].CommandIndex = 0;

                            XMenuTop.CloseForce();
                            BoxWindow.CloseForce();

                            if (callback != null)
                            {
                                _eventEndDelegate += callback;

                                if (_eventEndDelegate != null && !(_eventEndDelegate is EventEndDelegate))
                                {
                                    ThrowInvalidCast();
                                    return false;
                                }
                            }
                            return true;
                        }
                    }
                }

                ThrowIndexOutOfRange();
                return false;
            }
            return false;
        }

        private string ReEQType(string eq)
        {
            switch (eq)
            {
                case "EQUAL":
                    return "EQ";
                case "LITTLER":
                    return "LT";
                case "GREATER":
                    return "GT";
                case "LT_EQ":
                    return "LE";
                case "GT_EQ":
                    return "GE";
                case "FLGON":
                    return "EQ";
                case "FLGOFF":
                    return "LT";
                default:
                    return eq;
            }
        }

        private bool IfJump_Call(bool jump, string eq, string label)
        {
            string comparison = ReEQType(eq);
            switch (comparison)
            {
                case "EQ":
                    //Exclude Less and Greater
                    if (_cmp_flag != CmpResult.EQUAL)
                    {
                        return false;
                    }
                    break;
                case "NE":
                    //Exclude Equal
                    if (_cmp_flag == CmpResult.EQUAL)
                    {
                        return false;
                    }
                    break;
                case "GT":
                    //Exclude Less and Equal
                    if (_cmp_flag != CmpResult.PLUS)
                    {
                        return false;
                    }
                    break;
                case "GE":
                    //Exclude Less
                    if (_cmp_flag == CmpResult.MINUS)
                    {
                        return false;
                    }
                    break;
                case "LT":
                    //Exclude Greater and Equal
                    if (_cmp_flag != CmpResult.MINUS)
                    {
                        return false;
                    }
                    break;
                case "LE":
                    //Exclude Greater
                    if (_cmp_flag == CmpResult.PLUS)
                    {
                        return false;
                    }
                    break;
                default:
                    return false;
            }

            if (jump)
            {
                return JumpLabel(label, null);
            }
            return CallLabel(label);
        }

        private bool EvCmdIfJump()
        {
            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string eq = "";
            if (_evArg[1].argType == EvData.ArgType.String)
            {
                eq = _evData.EvData.GetString(_evArg[1].data);
            }

            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string label = "";
            if (_evArg[2].argType == EvData.ArgType.String)
            {
                label = _evData.EvData.GetString(_evArg[2].data);
            }

            IfJump_Call(true, eq, label);
            return true;
        }

        private bool EvCmdIfCall()
        {
            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string eq = "";
            if (_evArg[1].argType == EvData.ArgType.String)
            {
                eq = _evData.EvData.GetString(_evArg[1].data);
            }

            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string label = "";
            if (_evArg[2].argType == EvData.ArgType.String)
            {
                label = _evData.EvData.GetString(_evArg[2].data);
            }

            IfJump_Call(false, eq, label);
            return true;
        }

        private bool CommandEquals(string eq, int val1, int val2)
        {
            string comparison = ReEQType(eq);
            switch (comparison)
            {
                case "EQ":
                    //Equals
                    return val1 == val2;
                case "NE":
                    //Not Equals
                    return val1 != val2;
                case "GT":
                    //Greater
                    return val1 > val2;
                case "GE":
                    //Greater or equal
                    return val1 >= val2;
                case "LT":
                    //Less
                    return val1 < val2;
                case "LE":
                    //Less or equal
                    return val1 <= val2;
                default:
                    return false;
            }
        }

        private bool EvMacro_IFVAL_JUMP()
        {
            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            int val1 = GetWorkOrIntValue(_evArg[1]);

            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string eq = "";
            if (_evArg[2].argType == EvData.ArgType.String)
            {
                eq = _evData.EvData.GetString(_evArg[2].data);
            }

            if (_evArg.Length < 4)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            int val2 = GetWorkOrIntValue(_evArg[3]);

            if (_evArg.Length < 5)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string label = "";
            if (_evArg[4].argType == EvData.ArgType.String)
            {
                label = _evData.EvData.GetString(_evArg[4].data);
            }

            if (CommandEquals(eq, val1, val2))
            {
                JumpLabel(label, null);
            }
            return true;
        }

        private bool EvMacro_IFVAL_CALL()
        {
            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            int val1 = GetWorkOrIntValue(_evArg[1]);

            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string eq = "";
            if (_evArg[2].argType == EvData.ArgType.String)
            {
                eq = _evData.EvData.GetString(_evArg[2].data);
            }

            if (_evArg.Length < 4)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            int val2 = GetWorkOrIntValue(_evArg[3]);

            if (_evArg.Length < 5)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string label = "";
            if (_evArg[4].argType == EvData.ArgType.String)
            {
                label = _evData.EvData.GetString(_evArg[4].data);
            }

            if (CommandEquals(eq, val1, val2))
            {
                CallLabel(label);
            }
            return true;
        }

        private bool EvMacro_CASE_JUMP()
        {
            int actualVal = FlagWork.GetWork(_switch_work_index);

            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            int checkedVal = GetWorkOrIntValue(_evArg[1]);

            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string label = "";
            if (_evArg[2].argType == EvData.ArgType.String)
            {
                label = _evData.EvData.GetString(_evArg[2].data);
            }

            if (actualVal == checkedVal)
            {
                JumpLabel(label, null);
            }
            return true;
        }

        private bool EvMacro_CASE_CANCEL()
        {
            int val1 = FlagWork.GetWork(EvWork.WORK_INDEX.SCWK_REG0);
            int val2 = FlagWork.GetWork(EvWork.WORK_INDEX.EV_WIN_B_CANCEL);
            if (val1 < val2)
            {
                _cmp_flag = CmpResult.MINUS;
            }
            else if (val1 == val2)
            {
                _cmp_flag = CmpResult.EQUAL;
            }
            _cmp_flag = CmpResult.PLUS; // BUG? Will always be returning SCWK_REG0 as greater

            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string label = "";
            if (_evArg[1].argType == EvData.ArgType.String)
            {
                label = _evData.EvData.GetString(_evArg[1].data);
            }

            IfJump_Call(true, "EQ", label);
            return true;
        }

        private bool EvCmdFlagSet()
        {
            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            int flagNo = _evArg[1].data;
            if (flagNo > -1)
            {
                FlagWork.SetFlag(flagNo, true);
                if (flagNo == (int)EvWork.FLAG_INDEX.FLAG_STOP_ZONE_PROGRAM)
                {
                    FieldManager.Instance.eventTownMapPos = EntityManager.activeBattlePlayer.worldPosition;
                }
            }
            return true;
        }

        public void SetSysFlag(int index, bool val)
        {
            FlagWork.SetSysFlag((EvWork.SYSFLAG_INDEX)index, val);

            byte badgeCount = 0;
            if (FlagWork.GetSysFlag(EvWork.SYSFLAG_INDEX.BADGE_ID_C03)) badgeCount++;
            if (FlagWork.GetSysFlag(EvWork.SYSFLAG_INDEX.BADGE_ID_C04)) badgeCount++;
            if (FlagWork.GetSysFlag(EvWork.SYSFLAG_INDEX.BADGE_ID_C07)) badgeCount++;
            if (FlagWork.GetSysFlag(EvWork.SYSFLAG_INDEX.BADGE_ID_C06)) badgeCount++;
            if (FlagWork.GetSysFlag(EvWork.SYSFLAG_INDEX.BADGE_ID_C05)) badgeCount++;
            if (FlagWork.GetSysFlag(EvWork.SYSFLAG_INDEX.BADGE_ID_C02)) badgeCount++;
            if (FlagWork.GetSysFlag(EvWork.SYSFLAG_INDEX.BADGE_ID_C09)) badgeCount++;
            if (FlagWork.GetSysFlag(EvWork.SYSFLAG_INDEX.BADGE_ID_C08)) badgeCount++;
            PlayerWork.badge = badgeCount;
        }

        private bool EvMacro_IF_FLAGON_JUMP()
        {
            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string label = "";
            if (_evArg[2].argType == EvData.ArgType.String)
            {
                label = _evData.EvData.GetString(_evArg[2].data);
            }

            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            bool flagState;
            int flagNo = _evArg[1].data;
            switch (_evArg[1].argType)
            {
                case EvData.ArgType.SysFlag:
                    flagState = FlagWork.GetSysFlag((EvWork.SYSFLAG_INDEX)flagNo);
                    break;

                case EvData.ArgType.Flag:
                    if (flagNo < 0 || flagNo == (int)EvWork.FLAG_INDEX.FLAG_END_SAVE_SIZE)
                    {
                        return true;
                    }
                    flagState = FlagWork.GetFlag(flagNo);
                    break;

                default:
                    return true;
            }

            if (flagState)
            {
                _cmp_flag = CmpResult.EQUAL;
                IfJump_Call(true, "FLGON", label);
            }

            return true;
        }

        private bool EvMacro_IF_FLAGOFF_JUMP()
        {
            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string label = "";
            if (_evArg[2].argType == EvData.ArgType.String)
            {
                label = _evData.EvData.GetString(_evArg[2].data);
            }

            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            bool flagState;
            int flagNo = _evArg[1].data;
            switch (_evArg[1].argType)
            {
                case EvData.ArgType.SysFlag:
                    flagState = FlagWork.GetSysFlag((EvWork.SYSFLAG_INDEX)flagNo);
                    break;

                case EvData.ArgType.Flag:
                    if (flagNo < 0 || flagNo == (int)EvWork.FLAG_INDEX.FLAG_END_SAVE_SIZE)
                    {
                        _cmp_flag = CmpResult.MINUS;
                        IfJump_Call(true, "FLGOFF", label);
                        return true;
                    }
                    flagState = FlagWork.GetFlag(flagNo);
                    break;

                default:
                    return true;
            }

            if (!flagState)
            {
                _cmp_flag = CmpResult.MINUS;
                IfJump_Call(true, "FLGOFF", label);
            }

            return true;
        }

        private bool EvMacro_IF_FLAGON_CALL()
        {
            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string label = "";
            if (_evArg[2].argType == EvData.ArgType.String)
            {
                label = _evData.EvData.GetString(_evArg[2].data);
            }

            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            bool flagState;
            int flagNo = _evArg[1].data;
            switch (_evArg[1].argType)
            {
                case EvData.ArgType.SysFlag:
                    flagState = FlagWork.GetSysFlag((EvWork.SYSFLAG_INDEX)flagNo);
                    break;

                case EvData.ArgType.Flag:
                    if (flagNo < 0 || flagNo == (int)EvWork.FLAG_INDEX.FLAG_END_SAVE_SIZE)
                    {
                        return true;
                    }
                    flagState = FlagWork.GetFlag(flagNo);
                    break;

                default:
                    return true;
            }

            if (flagState)
            {
                _cmp_flag = CmpResult.EQUAL;
                IfJump_Call(false, "FLGON", label);
            }

            return true;
        }

        private bool EvMacro_IF_FLAGOFF_CALL()
        {
            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string label = "";
            if (_evArg[2].argType == EvData.ArgType.String)
            {
                label = _evData.EvData.GetString(_evArg[2].data);
            }

            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            bool flagState;
            int flagNo = _evArg[1].data;
            switch (_evArg[1].argType)
            {
                case EvData.ArgType.SysFlag:
                    flagState = FlagWork.GetSysFlag((EvWork.SYSFLAG_INDEX)flagNo);
                    break;

                case EvData.ArgType.Flag:
                    if (flagNo < 0 || flagNo == (int)EvWork.FLAG_INDEX.FLAG_END_SAVE_SIZE)
                    {
                        _cmp_flag = CmpResult.MINUS;
                        IfJump_Call(false, "FLGOFF", label);
                        return true;
                    }
                    flagState = FlagWork.GetFlag(flagNo);
                    break;

                default:
                    return true;
            }

            if (!flagState)
            {
                _cmp_flag = CmpResult.MINUS;
                IfJump_Call(false, "FLGOFF", label);
            }

            return true;
        }

        private bool EvCmdFlagCheckWk()
        {
            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            int workNo = _evArg[1].data;
            CmpResult result;
            switch (_evArg[1].argType)
            {
                case EvData.ArgType.Work:
                    int workValue = FlagWork.GetWork(workNo);
                    if (workValue < 0 || workValue == (int)EvWork.FLAG_INDEX.FLAG_END_SAVE_SIZE)
                    {
                        result = CmpResult.EQUAL;
                    }
                    else
                    {
                        result = FlagWork.GetFlag(workValue) ? CmpResult.MINUS : CmpResult.EQUAL;
                    }
                    break;

                case EvData.ArgType.Float:
                    int floatWorkValue = (int)ConvertToFloat(workNo);
                    if (floatWorkValue < 0 || floatWorkValue == (int)EvWork.FLAG_INDEX.FLAG_END_SAVE_SIZE)
                    {
                        result = CmpResult.EQUAL;
                    }
                    else
                    {
                        result = FlagWork.GetFlag(floatWorkValue) ? CmpResult.MINUS : CmpResult.EQUAL;
                    }
                    break;

                default:
                    result = FlagWork.GetFlag(0) ? CmpResult.MINUS : CmpResult.EQUAL;
                    break;
            }

            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            FlagWork.SetWork(_evArg[2].data, (int)result);
            return true;
        }

        private TrainerID GetArgTrainerID(EvScriptData ev, EvData.Aregment arg)
        {
            switch (arg.argType)
            {
                case EvData.ArgType.Work:
                case EvData.ArgType.Float:
                    return (TrainerID) GetWorkOrIntValue(arg);

                case EvData.ArgType.String:
                    string trainerName = ev.EvData.GetString(arg.data);
                    for (int i=0; i<(int)TrainerID.MAX; i++)
                    {
                        if (trainerName == Enum.GetName(typeof(TrainerID), i))
                        {
                            return (TrainerID) i;
                        }
                    }
                    return TrainerID.NONE;

                default:
                    return TrainerID.NONE;
            }
        }

        private bool EvMacro_IF_TR_FLAGON_JUMP()
        {
            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            TrainerID id = GetArgTrainerID(_evData, _evArg[1]);
            //_cmp_flag = TrainerWork.GetWinFlag(id) ? CmpResult.EQUAL : CmpResult.MINUS;

            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string label = "";
            if (_evArg[2].argType == EvData.ArgType.String)
            {
                label = _evData.EvData.GetString(_evArg[2].data);
            }

            IfJump_Call(true, "FLGON", label);
            return true;
        }

        private bool EvMacro_IF_TR_FLAGOFF_JUMP()
        {
            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            TrainerID id = GetArgTrainerID(_evData, _evArg[1]);
            //_cmp_flag = TrainerWork.GetWinFlag(id) ? CmpResult.EQUAL : CmpResult.MINUS;

            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string label = "";
            if (_evArg[2].argType == EvData.ArgType.String)
            {
                label = _evData.EvData.GetString(_evArg[2].data);
            }

            IfJump_Call(true, "FLGOFF", label);
            return true;
        }

        private bool EvMacro_IF_TR_FLAGON_CALL()
        {
            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            TrainerID id = GetArgTrainerID(_evData, _evArg[1]);
            //if (!TrainerWork.GetWinFlag(id) || TrainerWork.GetBattleSearcher(id))
            //{
                //_cmp_flag = CmpResult.MINUS;
            //}
            //else
            //{
                //_cmp_flag = CmpResult.EQUAL;
            //}

            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string label = "";
            if (_evArg[2].argType == EvData.ArgType.String)
            {
                label = _evData.EvData.GetString(_evArg[2].data);
            }

            IfJump_Call(false, "FLGON", label);
            return true;
        }

        private bool EvMacro_IF_TR_FLAGOFF_CALL()
        {
            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            TrainerID id = GetArgTrainerID(_evData, _evArg[1]);
            //if (!TrainerWork.GetWinFlag(id) || TrainerWork.GetBattleSearcher(id))
            //{
                //_cmp_flag = CmpResult.MINUS;
            //}
            //else
            //{
                //_cmp_flag = CmpResult.EQUAL;
            //}

            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string label = "";
            if (_evArg[2].argType == EvData.ArgType.String)
            {
                label = _evData.EvData.GetString(_evArg[2].data);
            }

            IfJump_Call(false, "FLGOFF", label);
            return true;
        }

        private bool EvCmdWkAdd()
        {
            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            int initialValue = GetWorkOrIntValue(_evArg[1]);

            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            int addedValue = GetWorkOrIntValue(_evArg[2]);

            FlagWork.SetWork(_evArg[1].data, initialValue + addedValue);
            return true;
        }

        private bool EvCmdWkSub()
        {
            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            int initialValue = GetWorkOrIntValue(_evArg[1]);

            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            int addedValue = GetWorkOrIntValue(_evArg[2]);

            FlagWork.SetWork(_evArg[1].data, initialValue - addedValue);
            return true;
        }

        private bool EvCmdLoadWkValue()
        {
            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            int newValue = GetWorkOrIntValue(_evArg[2]);

            FlagWork.SetWork(_evArg[1].data, newValue);
            return true;
        }

        private bool EvCmdLoadWkWk()
        {
            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            int newValue = GetWorkOrIntValue(_evArg[2]);

            FlagWork.SetWork(_evArg[1].data, newValue);
            return true;
        }

        private bool EvCmdLoadWkWkValue()
        {
            if (_evArg.Length < 3)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            int newValue = GetWorkOrIntValue(_evArg[2]);

            FlagWork.SetWork(_evArg[1].data, newValue);
            return true;
        }

        private bool Cmd_TalkMsg(EvScriptData ev, bool index = false)
        {
            switch (_talkStart)
            {
                case TalkState.Init:
                    if (ev.CommandIndex >= ev.GetScript.Commands.Count)
                    {
                        ThrowArgumentOutOfRange();
                    }

                    EvData.Command command = ev.GetScript.Commands[ev.CommandIndex];

                    if (index)
                    {
                        if (command.Arg.Count < 2)
                        {
                            ThrowArgumentOutOfRange();
                        }

                        string file = "";
                        if (command.Arg[1].argType == EvData.ArgType.String)
                        {
                            file = _evData.EvData.GetString(command.Arg[1].data);
                        }

                        _msgOpenParam.MsbtFile = file;
                        _msgOpenParam.Label = "";

                        if (command.Arg.Count < 3)
                        {
                            ThrowArgumentOutOfRange();
                        }

                        int workno = GetWorkOrIntValue(command.Arg[2]);
                        _msgOpenParam.LabelIndex = workno;

                        if (command.Arg.Count < 4)
                        {
                            _msgOpenParam.PlayTextFeedSe = false;
                        }
                        else
                        {
                            _msgOpenParam.PlayTextFeedSe = GetWorkOrIntValue(command.Arg[3]) == 1;
                        }
                    }
                    else
                    {
                        if (command.Arg.Count < 2)
                        {
                            ThrowArgumentOutOfRange();
                        }

                        string label = "";
                        if (command.Arg[1].argType == EvData.ArgType.String)
                        {
                            label = _evData.EvData.GetString(command.Arg[1].data);
                        }
                        string[] file = label.Split('%');

                        if (file.Length < 1)
                        {
                            ThrowIndexOutOfRange();
                        }

                        _msgOpenParam.MsbtFile = file[0];

                        if (file.Length < 2)
                        {
                            ThrowIndexOutOfRange();
                        }

                        _msgOpenParam.Label = file[1];

                        if (command.Arg.Count < 3)
                        {
                            _msgOpenParam.PlayTextFeedSe = false;
                        }
                        else
                        {
                            _msgOpenParam.PlayTextFeedSe = GetWorkOrIntValue(command.Arg[2]) == 1;
                        }
                    }

                    _msgOpenParam.WindowType = MsgWindowType.DEFAULT;
                    _msgOpenParam.Input = true;
                    _msgOpenParam.EndType = MsgEndType.Input;
                    OpenTalk(_msgOpenParam);
                    _talkStart = TalkState.EndWait;
                    return false;

                case TalkState.EndWait:
                    if (_msgWindowCoroutine != null)
                    {
                        return false;
                    }
                    _talkStart = TalkState.Init;
                    return true;

                default:
                    return false;
            }
        }

        private bool OpenTalk(MsgOpenParam msgparam)
        {
            if (_msgWindowCoroutine != null)
            {
                Sequencer.Stop(_msgWindowCoroutine);
            }

            // TODO
            return true;
        }

        private bool EvCmdEventCameraIndex()
        {
            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            int index = GetWorkOrIntValue(_evArg[1]);
            //GameManager.fieldCamera.EventCamera.SetCameraData(_evCameraTable, index);

            return true;
        }

        private bool EvCmd_CAMERA_CONTROLLER_PLAY()
        {
            if (_evArg.Length < 2)
            {
                ThrowIndexOutOfRange();
                return false;
            }

            string statename = "";
            if (_evArg[1].argType == EvData.ArgType.String)
            {
                statename = _evData.EvData.GetString(_evArg[1].data);
            }

            FieldAnimeCamera.instance.Play(statename);
            return true;
        }

        private bool RunEvCmd(EvCmdID.NAME index)
        {
            if (index < EvCmdID.NAME.CMD_NAME_END)
            {
                switch (index)
                {
                    case EvCmdID.NAME._NOP:
                    case EvCmdID.NAME._END:
                        {
                            EndScript();
                            return true;
                        }

                    case EvCmdID.NAME._TIME_WAIT:
                        {
                            return EvCmdTimeWait();
                        }

                    case EvCmdID.NAME._CMPWK:
                        {
                            EvCmdCmpWkWk();
                            return true;
                        }

                    case EvCmdID.NAME._CHG_COMMON_SCR:
                    case EvCmdID.NAME._CALL:
                        {
                            if (_evArg.Length < 2)
                            {
                                ThrowIndexOutOfRange();
                                return true;
                            }
                            string label = "";
                            if (_evArg[1].argType == EvData.ArgType.String)
                            {
                                label = _evData.EvData.GetString(_evArg[1].data);
                            }
                            CallLabel(label);
                            return true;
                        }

                    case EvCmdID.NAME._CHG_LOCAL_SCR:
                    case EvCmdID.NAME._RET:
                        {
                            bool retResult = ReturnEvData();
                            if (!retResult)
                            {
                                EndScript();
                            }
                            return true;
                        }

                    case EvCmdID.NAME._JUMP:
                        {
                            if (_evArg.Length < 2)
                            {
                                ThrowIndexOutOfRange();
                                return true;
                            }
                            string label = "";
                            if (_evArg[1].argType == EvData.ArgType.String)
                            {
                                label = _evData.EvData.GetString(_evArg[1].data);
                            }
                            JumpLabel(label, null);
                            return true;
                        }

                    case EvCmdID.NAME._IF_JUMP:
                        {
                            EvCmdIfJump();
                            return true;
                        }

                    case EvCmdID.NAME._IF_CALL:
                        {
                            EvCmdIfCall();
                            return true;
                        }

                    case EvCmdID.NAME._IFVAL_JUMP:
                    case EvCmdID.NAME._IFWK_JUMP:
                        {
                            EvMacro_IFVAL_JUMP();
                            return true;
                        }

                    case EvCmdID.NAME._IFVAL_CALL:
                    case EvCmdID.NAME._IFWK_CALL:
                        {
                            EvMacro_IFVAL_CALL();
                            return true;
                        }

                    case EvCmdID.NAME._SWITCH:
                        {
                            if (_evArg.Length < 2)
                            {
                                ThrowIndexOutOfRange();
                                return true;
                            }
                            _switch_work_index = _evArg[1].data;
                            return true;
                        }

                    case EvCmdID.NAME._CASE_JUMP:
                        {
                            EvMacro_CASE_JUMP();
                            return true;
                        }

                    case EvCmdID.NAME._CASE_CANCEL:
                        {
                            EvMacro_CASE_CANCEL();
                            return true;
                        }

                    case EvCmdID.NAME._FLAG_SET:
                        {
                            EvCmdFlagSet();
                            return true;
                        }

                    case EvCmdID.NAME._ARRIVE_FLAG_SET:
                        {
                            if (_evArg.Length < 2)
                            {
                                ThrowIndexOutOfRange();
                                return true;
                            }
                            SetSysFlag(_evArg[1].data, true);
                            return true;
                        }

                    case EvCmdID.NAME._FLAG_RESET:
                        {
                            if (_evArg.Length < 2)
                            {
                                ThrowIndexOutOfRange();
                                return true;
                            }
                            int flagNo = _evArg[1].data;
                            if (flagNo > -1)
                            {
                                FlagWork.SetFlag(flagNo, false);
                            }
                            return true;
                        }

                    case EvCmdID.NAME._FLAG_CHECK:
                        {
                            if (_evArg.Length < 2)
                            {
                                ThrowIndexOutOfRange();
                                return true;
                            }
                            int flagNo = _evArg[1].data;
                            if ((flagNo < 0) || (flagNo == (int)EvWork.FLAG_INDEX.FLAG_END_SAVE_SIZE))
                            {
                                _cmp_flag = CmpResult.EQUAL;
                            }
                            else if (!FlagWork.GetFlag(flagNo))
                            {
                                _cmp_flag = CmpResult.EQUAL;
                            }
                            else
                            {
                                _cmp_flag = CmpResult.MINUS;
                            }
                                
                            return true;
                        }

                    case EvCmdID.NAME._IF_FLAGON_JUMP:
                        {
                            EvMacro_IF_FLAGON_JUMP();
                            return true;
                        }

                    case EvCmdID.NAME._IF_FLAGOFF_JUMP:
                        {
                            EvMacro_IF_FLAGOFF_JUMP();
                            return true;
                        }

                    case EvCmdID.NAME._IF_FLAGON_CALL:
                        {
                            EvMacro_IF_FLAGON_CALL();
                            return true;
                        }

                    case EvCmdID.NAME._IF_FLAGOFF_CALL:
                        {
                            EvMacro_IF_FLAGOFF_CALL();
                            return true;
                        }

                    case EvCmdID.NAME._FLAG_CHECK_WK:
                        {
                            EvCmdFlagCheckWk();
                            return true;
                        }

                    case EvCmdID.NAME._FLAG_SET_WK:
                        {
                            if (_evArg.Length < 2)
                            {
                                ThrowIndexOutOfRange();
                                return true;
                            }

                            int flagNo = GetWorkOrIntValue(_evArg[1]);
                            
                            if (flagNo < 0)
                            {
                                return true;
                            }

                            FlagWork.SetFlag(flagNo, true);
                            return true;
                        }

                    case EvCmdID.NAME._TRAINER_FLAG_SET:
                        {
                            if (_evArg.Length < 2)
                            {
                                ThrowIndexOutOfRange();
                                return true;
                            }

                            TrainerID id = GetArgTrainerID(_evData, _evArg[1]);
                            //TrainerWork.SetWinFlag(id);
                            //TrainerWork.SetBattleSaercher(id);
                            return true;
                        }

                    case EvCmdID.NAME._TRAINER_FLAG_RESET:
                        {
                            if (_evArg.Length < 2)
                            {
                                ThrowIndexOutOfRange();
                                return true;
                            }

                            TrainerID id = GetArgTrainerID(_evData, _evArg[1]);
                            //TrainerWork.ResetWinFlag(id);
                            //TrainerWork.ReSetBattleSaercher(id);
                            return true;
                        }

                    case EvCmdID.NAME._TRAINER_FLAG_CHECK:
                        {
                            if (_evArg.Length < 2)
                            {
                                ThrowIndexOutOfRange();
                                return true;
                            }

                            TrainerID id = GetArgTrainerID(_evData, _evArg[1]);
                            //if (!TrainerWork.GetWinFlag(id) || TrainerWork.GetBattleSearcher(id))
                            //{
                                //_cmp_flag = CmpResult.MINUS;
                            //}
                            //else
                            //{
                                //_cmp_flag = CmpResult.EQUAL;
                            //}

                            return true;
                        }

                    case EvCmdID.NAME._IF_TR_FLAGON_JUMP:
                        {
                            EvMacro_IF_TR_FLAGON_JUMP();
                            return true;
                        }

                    case EvCmdID.NAME._IF_TR_FLAGOFF_JUMP:
                        {
                            EvMacro_IF_TR_FLAGOFF_JUMP();
                            return true;
                        }

                    case EvCmdID.NAME._IF_TR_FLAGON_CALL:
                        {
                            EvMacro_IF_TR_FLAGON_CALL();
                            return true;
                        }

                    case EvCmdID.NAME._IF_TR_FLAGOFF_CALL:
                        {
                            EvMacro_IF_TR_FLAGOFF_CALL();
                            return true;
                        }

                    case EvCmdID.NAME._ADD_WK:
                        {
                            EvCmdWkAdd();
                            return true;
                        }

                    case EvCmdID.NAME._SUB_WK:
                        {
                            EvCmdWkSub();
                            return true;
                        }

                    case EvCmdID.NAME._LDVAL:
                        {
                            EvCmdLoadWkValue();
                            return true;
                        }

                    case EvCmdID.NAME._LDWK:
                        {
                            EvCmdLoadWkWk();
                            return true;
                        }

                    case EvCmdID.NAME._LDWKVAL:
                        {
                            EvCmdLoadWkWkValue();
                            return true;
                        }

                    case EvCmdID.NAME._TALKMSG:
                        {
                            return Cmd_TalkMsg(_evData, false);
                        }

                    case EvCmdID.NAME._EVENT_CAMERA_INDEX:
                        {
                            EvCmdEventCameraIndex();
                            return true;
                        }

                    case EvCmdID.NAME._CAMERA_CONTROLLER_PLAY:
                        {
                            EvCmd_CAMERA_CONTROLLER_PLAY();
                            return true;
                        }

                    default:
                        {
                            return true;
                        }
                }
            }
            return true;
        }

        // Not an actual method, here to simplify the code.
        // Ends the script.
        private void EndScript()
        {
            SetCloudScaleEnd();
            _eventListIndex = -1;
        }

        // Not an actual method, here to simplify the code.
        // Throws an IndexOutOfRange exception.
        private void ThrowIndexOutOfRange()
        {
            // TODO
            throw new IndexOutOfRangeException();
        }

        // Not an actual method, here to simplify the code.
        // Throws an InvalidCast exception.
        private void ThrowInvalidCast()
        {
            // TODO
            throw new InvalidCastException();
        }

        // Not an actual method, here to simplify the code.
        // Throws an ArgumentOutOfRange exception.
        private void ThrowArgumentOutOfRange()
        {
            // TODO
            throw new ArgumentOutOfRangeException();
        }

        // Not an actual method, here to simplify the code.
        // Converts the IEEE-754 formatted int32 into its proper float value.
        private float ConvertToFloat(int value)
        {
            return BitConverter.ToSingle(BitConverter.GetBytes(_evArg[1].data), 0);
        }

        // Not an actual method, here to simplify the code.
        // Returns either the value at the given work variable or the direct int value depending on the given argument's type.
        // Returns 0 for any other argument type.
        int GetWorkOrIntValue(EvData.Aregment arg)
        {
            EvData.ArgType argType = arg.argType;
            int data = arg.data;
            int result = 0;

            switch (argType)
            {
                case EvData.ArgType.Work:
                    result = PlayerWork.GetInt(data);
                    break;
                case EvData.ArgType.Float:
                    result = (int)ConvertToFloat(data);
                    break;
                default:
                    break;
            }

            return result;
        }

        // Not an actual method, here to simplify the code.
        // Returns either the value at the given work variable or the direct float value depending on the given argument's type.
        // Returns 0 for any other argument type.
        float GetWorkOrFloatValue(EvData.Aregment arg)
        {
            EvData.ArgType argType = arg.argType;
            int data = arg.data;
            float result = 0;

            switch (argType)
            {
                case EvData.ArgType.Work:
                    result = PlayerWork.GetInt(data);
                    break;
                case EvData.ArgType.Float:
                    result = ConvertToFloat(data);
                    break;
                default:
                    break;
            }

            return result;
        }

        // Not an actual method, here to simplify the code.
        // If the given argument is a work variable, set it to the given value.
        // Does nothing otherwise.
        void SetWorkToValue(EvData.Aregment arg, int value)
        {
            EvData.ArgType argType = arg.argType;
            int data = arg.data;

            if (argType == EvData.ArgType.Work)
            {
                PlayerWork.SetInt(data, value);
            }
        }
    }
}
