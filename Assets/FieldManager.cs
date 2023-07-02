//using Dpr.Trainer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Diagnostics;

public class FieldManager
{
    private const int MapSize = 64;

    public static GameObject fwMng; // FieldWalkingManager
    public static GameObject abUnloader; // Utils.AssetUnloader
    public static bool SealPrevFalg;

    private Action OnZoneChangeEvent;
    public Action OnZoneChangeOnce;
    private Action OnSceneInitEvent;
	private GameObject _updateType; // FieldManager.UpdateType
    private GameObject _encountUpdateType; // FieldManager.EncountUpdateType
    private float _encountWait;
    private GameObject _encountFadeType; // FieldManager.EncountFadeType
    private Queue<GameObject> _attributeEntitySE; // Queue<FieldManager.AttributeEvent>
    private Queue<GameObject> _attributeEntityEffect; // Queue<FieldManager.AttributeEvent>
    public GameObject NowMapType; // MapType
    public GameObject OldMapType; // MapType
    private ZoneID _now_zoneID;
    private GameObject[] _effectDataArray; // FieldManager.LoadEffectData[]
    private GameObject _weatherEffectInstance; // EffectInstance
    private GameObject _nowWeather; // SYS_WEATHER
    private GameObject _weather; // FieldWeather
    public GameObject MistWork; // FieldMistWork
    public GameObject FlashWork; // FieldFlashWork
    //private TrainerID _btl_trainerID1;
    //private TrainerID _btl_trainerID2;
    private GameObject _ug_hole;
    private bool _is_ugHoleLock;
    private Vector3 _ugHolePos;
    private GameObject _ugMainProc; // UgMainProc
    private GameObject _fldCanvasObject;
    private GameObject _fldCanvasAssetReqOpe; // AssetRequestOperation
    private int _oldEncountWalkCount;
    private GameObject _encFadeTextures; // EncountFadeTextures
    private Material _encFadeMaterial;
    private GameObject _encFadeTexturesReqOpe; // AssetRequestOperation
    private GameObject _encResult; // EncountResult
    private GameObject _encEffctController; // EncEffectSequenceController
    private int _encEffectCount;
    private GameObject[] _encEffectAsset;
    private bool _encountAttriLog;
    private GameObject _fishing; // FieldFishing
    private GameObject _useRod; // FishingRod
    private GameObject _wazaAction; // FieldManager.FieldWazaAction
    private bool _isMenuOpenRequest;
    private float _shortCutPushTime;
    private int _shortCutPushHoldId;
	public bool SND_W_ID_CTRL_BGM_FLAG;
    private GameObject _demoReturnType; // FieldManager.UpdateType
    private bool _demoReturnInput;
    private uint _WalkEventName_Attribute;
    private bool _initFlag;
    private GameObject _autoSaveState; // FieldManager.AutoSaveState
    public Vector3 eventTownMapPos;
    private List<int> unnnoonFormList;
    private int _shorCutSeq;
    private Transform _akLisnerTransform;

    public static FieldManager Instance
    {
        get
        {
            return null;
        }
        set
        {
            // TODO
        }
    }

    public static bool IsResume
    {
        get
        {
            return true;
        }
        set
        {

        }
    }

    public GameObject updateType // FieldManager.UpdateType
    {
        get
        {
            return null;
        }
    }

    public GameObject ZoneData // MapInfo.SheetZoneData
    {
        get
        {
            return null;
        }
    }

    public AreaID areaID
    {
        get
        {
            return AreaID.C01;
        }
    }

    public ZoneID zoneID
    {
        get
        {
            return ZoneID.C01;
        }
    }

    public ZoneID Before_zoneID
    {
        get
        {
            return ZoneID.C01;
        }
        set
        {

        }
    }

    public GameObject UG_Hole
    {
        get
        {
            return null;
        }
    }

    public static bool IsWazaActionEnd
    {
        get
        {
            return true;
        }
    }

    public uint _nowEventId
    {
        get
        {
            return 0;
        }
        set
        {

        }
    }

    public bool IsMenuOpen
    {
        get
        {
            return true;
        }
        set
        {

        }
    }

    public bool isMenuOpenRequest
    {
        get
        {
            return true;
        }
    }

    public bool IsPoketchOpen
    {
        get
        {
            return true;
        }
        set
        {

        }
    }

    public GameObject KinomiResources // KinomiResources
    {
        get
        {
            return null;
        }
        private set
        {
        }
    }

    private class AutoSaveCoroutine : IEnumerator
    {
        private int _state;
        private object _current;

        public AutoSaveCoroutine(int state)
        {
            _state = state;
        }

        public bool MoveNext()
        {
            switch (_state)
            {
                case 0:
                    _state = -1;
                    // Insert logic here
                    _current = null;
                    _state = 1;
                    return true;
                case 1:
                    _state = -1;
                    // Insert logic here
                    _current = null;
                    _state = 2;
                    return true;
                case 2:
                    _state = -1;
                    // Insert logic here
                    return false;
                default:
                    return false;
            }
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }

        public object Current
        {
            get { return _current; }
        }

        public void Dispose()
        {
        }
    }

    private class AutoSaveWindowAnime : IEnumerator
    {
        private int _state;
        private object _current;

        public AutoSaveWindowAnime(int state)
        {
            _state = state;
        }

        public bool MoveNext()
        {
            switch (_state)
            {
                case 0:
                    _state = -1;
                    // Insert logic here
                    _current = null;
                    _state = 1;
                    return true;
                case 1:
                    _state = -1;
                    // Insert logic here
                    _current = null;
                    _state = 2;
                    return true;
                case 2:
                    _state = -1;
                    // Insert logic here
                    return false;
                default:
                    return false;
            }
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }

        public object Current
        {
            get { return _current; }
        }

        public void Dispose()
        {
        }
    }


    [StructLayout(LayoutKind.Sequential)]
    public sealed class AttributeEvent : ScriptableObject
    {
        public int chartype;

        public bool isRun;

        public bool isBic;

        public GameObject entity;

        public GameObject eventType;

        public GameObject callType;
    }

    public sealed class AttributeEventCallType : ScriptableObject
    {
        public int value__;

        public GameObject Player;

        public GameObject NPC_Heel;

        public GameObject NPC;
    }

    public sealed class AttributeEventType : ScriptableObject
    {
        public int value__;

        public GameObject Run;

        public GameObject Jump;
    }

    public sealed class AutoSaveState : ScriptableObject
    {
        public int value__;

        public GameObject None;

        public GameObject Zone_Change;

        public GameObject BattleResult;

        public GameObject EventScript;

        public GameObject Stop;
    }

    public sealed class EncountFadeType : ScriptableObject
    {
        public int value__;

        public GameObject Normal;

        public GameObject Trainer;
    }

    private sealed class EncountUpdateType : ScriptableObject
    {
        public int value__;

        public GameObject CallEffect;

        public GameObject EndWait;

        public GameObject CallBackWait;

        public GameObject TrainerEffWait;

        public GameObject End;
    }

    public sealed class FieldWazaAction
    {
        public extern FieldWazaAction(object @object, IntPtr method);

        public extern bool Invoke(bool deltatime);

        public extern IAsyncResult BeginInvoke(bool deltatime, AsyncCallback callback, object @object);

        public extern bool EndInvoke(IAsyncResult result);
    }

    private class LoadEffectData : ScriptableObject
    {
        public string name;

        public GameObject effect;

        public bool isLoading;

        public bool isComplete;
    }

    public sealed class UpdateType : ScriptableObject
    {
        public int value__;

        public GameObject Field;

        public GameObject UnderGround;

        public GameObject Encount;

        public GameObject Fishing;

        public GameObject DemoWait;
    }
}
