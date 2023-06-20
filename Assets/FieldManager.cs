using Dpr.Trainer;
using System;
using System.Collections;
using System.Collections.Generic;
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
    private TrainerID _btl_trainerID1;
    private TrainerID _btl_trainerID2;
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
        set
        {

        }
    }
}
