using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerWork
{
    public sealed class LoadResult : ScriptableObject
    {
        public int value__;

        public GameObject SUCCESS;

        public GameObject NOT_EXIST;

        public GameObject CORRUPTED;

        public GameObject FAILED;
    }

    [Serializable]
    public sealed class SaveData : ScriptableObject
    {
        public int CURRENT_VERSION_1C;

        public int CURRENT_VERSION_20;

        public int CURRENT_VERSION_21;

        public int CURRENT_VERSION_22;

        public int CURRENT_VERSION_23;

        public int CURRENT_VERSION_24;

        public int CURRENT_VERSION_25;

        public int CURRENT_VERSION;

        public object BINARY_SIZE;

        public int SAVEDATA_HASH_ADDR;

        public int SAVEDATA_HASH_SIZE;

        public int version;

        public GameObject intValues;

        public GameObject boolValues;

        public GameObject systemFlags;

        public GameObject rivalName;

        public GameObject zoneID;

        public float timeScale;

        public GameObject saveItem;

        public GameObject saveUgItem;

        public GameObject saveItemShortcut;

        public GameObject playerParty;

        public GameObject boxData;

        public GameObject boxTray;

        public GameObject playerData;

        public GameObject zukanData;

        public GameObject tr_battleData;

        public GameObject topMenuData;

        public GameObject fieldObj_Save;

        public GameObject record;

        public GameObject enc_sv_data;

        public GameObject player_save_data;

        public GameObject ballDecoData;

        public GameObject saveSeal;

        public GameObject randomGroup;

        public GameObject fieldGimmickSaveData;

        public GameObject kinomiGrowSaveData;

        public GameObject poffinSaveData;

        public GameObject btlTowerSave;

        public GameObject systemData;

        public GameObject poketchData;

        public GameObject azukariyaData;

        public GameObject dendoudata;

        public GameObject badgeSaveData;

        public GameObject boukenNote;

        public GameObject tvData;

        public GameObject ugSaveData;

        public GameObject gmsdata;

        public GameObject networkdata;

        public GameObject unionSaveData;

        public GameObject contstPhotoLangData;

        public GameObject zukanPersonalRndData;

        public GameObject contestPhotoExtData;

        public GameObject gmsPointExtData;

        public GameObject ugCountRecord;

        public GameObject reBuffNameData;

        public GameObject saveDataHash;
    }

    public sealed class WarpType : ScriptableObject
    {
        public int value__;

        public GameObject None;

        public GameObject Zenmetsu;

        public GameObject Teleport;

        public GameObject Ananuke;

        public GameObject Sorawotobu;
    }

    private sealed class warpClass : ScriptableObject
    {
        public GameObject warp;
    }

    public GameObject _saveData;

    public GameObject _transitionZoneID;

    public int _locatorIndex;

    public GameObject _transitionLocation;

    public bool _isBattling;

    public bool _isContest;

    public bool _isSealPreview;

    public bool _isEvolveDemo;

    public bool _isHatchDemo;

    public bool _isMass;

    public bool _isEncount;

    public bool _isDigFossil;

    public bool _isGMS;

    public GameObject _loadResult;

    public GameObject _battleSetupParam;

    public GameObject _playerParty;

    public GameObject _capturedPokemon;

    public GameObject _evolveRequets;

    public bool _isMainSave;

    public bool _isBackupSave;

    public bool _003CNoSavePlayerPos_003Ek__BackingField;

    public GameObject _003CcapturedMonsNo_003Ek__BackingField;

    public bool _003CencountEnable_003Ek__BackingField;

    public bool _003CisDebugWalk_003Ek__BackingField;

    public bool _003CisDebugPlayerVisible_003Ek__BackingField;

    public bool _003CisDebugBattleTextView_003Ek__BackingField;

    public bool _isPlayerInputActive;

    public bool _isPlayerInputActive_ContactEvent;

    public bool IsFieldKuruKuruStart;

    public bool IsFieldFallStart;

    public bool IsToUg;

    public bool IsFromUg;

    public bool ReserveZoneChangeNaminoriEnd;

    public string _003CFieldWorpLinkName_003Ek__BackingField;

    public string _003CFieldWorpLabel_003Ek__BackingField;

    public bool _003CisDebugNpcVisble_003Ek__BackingField;

    public bool _003CisDebugNpcPokeVisble_003Ek__BackingField;

    public GameObject _003CDebugEncountMonsNo_003Ek__BackingField;

    public GameObject _003CFieldWeather_003Ek__BackingField;

    public GameObject _003CDoubleSlot_003Ek__BackingField;

    public int _003CDebugWeek_003Ek__BackingField;

    public int InputNormal;

    public int InputLR;

    public int InputUD;

    public int InputCross;

    public int _003CFieldInputMode_003Ek__BackingField;

    public bool _003CIsZenmetuFlag_003Ek__BackingField;

    public bool _003CIsNeedUnloadOnFieldConnector_003Ek__BackingField;

    public GameObject _003CWarp_003Ek__BackingField;

    public bool _003CTelescope_003Ek__BackingField;

    public bool _003CFieldCacheFlag_003Ek__BackingField;

    public int _003CSafariBallNum_003Ek__BackingField;

    public int _003CSafariStepCount_003Ek__BackingField;

    public GameObject _003CSafariCaptureMonsNo_003Ek__BackingField;

    public int _003CIsCpuBoostMode_003Ek__BackingField;

    public GameObject _003CUsedFieldItem_003Ek__BackingField;

    public GameObject _003CUsedFieldWazaNo_003Ek__BackingField;

    public int _003CUsedFieldWazaTemotiNo_003Ek__BackingField;

    public bool _003CFlash_003Ek__BackingField;

    public GameObject UsedFieldWazaInArea;

    public bool _003CPoketchOpen_003Ek__BackingField;

    public int _003CMovePokemonIndex_003Ek__BackingField;

    public bool _003CIsD26Key_003Ek__BackingField;

    public static int playerID => 0;

    public static string userName
    {
        get
        {
            return "";
        }
        set
        {
        }
    }

    public static bool playerSex
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static int playerFashion
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static string rivalName
    {
        get
        {
            return "";
        }
        set
        {
        }
    }

    public static object zoneID
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static bool NoSavePlayerPos
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    //public static Vector2Int grid => null;

    public static bool height => false;

    public static bool rotation => false;

    public static object transitionZoneID
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static int locatorIndex
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static object transitionLocation
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static bool isBattling
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool isContest
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool isSealPreview
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool isEvolveDemo
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool isHatchDemo
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool isDigFossil
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool isGMS
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool isMass
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool isEncount
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static int colorID
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static byte badge
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static object msgLangID
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static int cassetVersion
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static bool isKanji
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static object btlTowerSave
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static bool bicycleGear
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static byte bicycleColor
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static object battleSetupParam => null;

    public static object playerParty => null;

    public static object capturedPokemon
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object capturedMonsNo
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object evolveRequets => null;

    public static bool encountEnable
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool isDebugDash => false;

    public static bool isDebugWalk
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool isDebugPlayerVisible
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool isDebugBattleTextView
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    //public static ref PLAYER_DATA playerData
    //{
        //get
        //{
            //return null;
        //}
    //}

    public static object playerStatus => null;

    public static object config => null;

    public static object contestData => null;

    public static object contestPhotoLangData => null;

    public static object contestPhotoExtData => null;

    public static object gmsData => null;

    public static object gmsExtData => null;

    public static object networkData => null;

    public static object zukan
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static bool isPlayerInputActive
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static uint uniqueID
    {
        get
        {
            return 0u;
        }
        set
        {
        }
    }

    public static object defaultPokeType
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object defaultPokeNo => null;

    public static object rivalPokeType => null;

    public static object rivalPokeNo => null;

    public static object supportPokeType => null;

    public static object supportPokeNo => null;

    public static object tr_battleData
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object topMenu
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object fieldObjSave
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object record
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static string FieldWorpLinkName
    {
        get
        {
            return "";
        }
        set
        {
        }
    }

    public static string FieldWorpLabel
    {
        get
        {
            return "";
        }
        set
        {
        }
    }

    public static bool isDebugNpcVisble
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool isDebugNpcPokeVisble
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static object DebugEncountMonsNo
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object FieldWeather
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object Enc_SV_Data
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static byte BtlSearcherCharge
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static int HoneyLastTreeIndex
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static object HoneyData => null;

    public static long HoneyLastUpdateMinutes
    {
        get
        {
            return 0L;
        }
        set
        {
        }
    }

    public static int WalkEncountCount
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static object PlayerSaveData
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static bool WalkCount
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static object DoubleSlot
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object RandomGroup
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object GimmickGearRotate
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object KinomiGrows => null;

    public static long KinomiGrowLastUpdateMinutes
    {
        get
        {
            return 0L;
        }
        set
        {
        }
    }

    //public static DayOfWeek Week => null;

    public static int DebugWeek
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static int FieldInputMode
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static bool IsZenmetuFlag
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool IsNeedUnloadOnFieldConnector
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static object Warp
    {
        get
        {
            return null;
        }
        private set
        {
        }
    }

    public static bool Telescope
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static object ugSaveData
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static int ReturnZoneID
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static int ReturnUgZoneID
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static Vector3 UgReturnPos
    {
        //get
        //{
            //return null;
        //}
        set
        {
        }
    }

    public static object UgRecord => null;

    public static object UgCountRecord => null;

    public static object poffinSaveData => null;

    public static int CookingCount
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static bool FieldCacheFlag
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static int SafariBallNum
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static int SafariStepCount
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static object SafariCaptureMonsNo
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static int IsCpuBoostMode
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static object UsedFieldItem
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object UsedFieldWazaNo
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static int UsedFieldWazaTemotiNo
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static bool Kiribarai
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool Flash
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static object SystemData
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static bool PoketchOpen
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static object PoketchData
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static uint PoketchPedometer
    {
        get
        {
            return 0u;
        }
        set
        {
        }
    }

    public static int TureWalkMemberIndex
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static object AzukariyaData => null;

    public static bool IsMovePokemon => false;

    public static int MovePokemonIndex
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static bool IsD26Key
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static object dendoudata
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object BadgeData
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static int natuki_walkcnt
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static object boukenNote
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object tvData
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object unionSaveData
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object zukanPersonalRndData
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static object reBuffNameData
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    //protected override void Initialization()
    //{
    //}

    private object ToBytes<T>(object obj)
    {
        return null;
    }

    private void LoadBytes<T>(object bytes, object obj)
    {
    }

    //protected override bool CustomLoadOperation()
    //{
        //return false;
    //}

    //protected override bool CustomSaveOperation()
    //{
        //return false;
    //}

    //protected override bool CustomLoadAsyncOperation()
    //{
        //return false;
    //}

    //protected override bool CustomSaveAsyncOperation()
    //{
        //return false;
    //}

    //protected override void OnPostLoad()
    //{
    //}

    private static void OnPostLoad_NeedMD()
    {
    }

    //protected override void OnPreSave()
    //{
    //}

    public static void DataSave(bool isAsync, bool writeMain, bool writeBackup)
    {
    }

    public static object SaveAsync(bool writeMain, bool writeBackup)
    {
        return null;
    }

    public static void DataLoad(bool isAsync, bool fromBackup)
    {
    }

    public static object LoadAsync(bool fromBackup)
    {
        return null;
    }

    public static bool ExistBackUpData()
    {
        return false;
    }

    public static int GetInt(object index)
    {
        return 0;
    }

    public static void SetInt(object index, int value)
    {
    }

    public static bool GetBool(object index)
    {
        return false;
    }

    public static void SetBool(object index, bool value)
    {
    }

    public static bool GetSytemFlag(object index)
    {
        return false;
    }

    public static void SetSytemFlag(object index, bool value)
    {
    }

    public static void SetTransitionZone(object zoneID, int index)
    {
    }

    public static void SetWarp(object warp)
    {
    }

    public static void SetWarpSorawotobu(object zoneId, int locatorIndex)
    {
    }

    public static void SetPlayerPosData(object player)
    {
    }

    public static void SetPlayerGrid(Vector2Int vec)
    {
    }

    public static void SetPlayerHeight(bool height)
    {
    }

    public static void SetPlayerRotation(bool rot)
    {
    }

    public static void SetMoney(int value)
    {
    }

    public static int GetMoney()
    {
        return 0;
    }

    public static void SetItem(int itemno, object value)
    {
    }

    public static object GetItem(int itemno)
    {
        return null;
    }

    public static void SetUgItem(int ugItemNo, object value)
    {
    }

    public static object GetUgItem(int ugItemNo)
    {
        return null;
    }

    public static void SetItemShortcut(int id, ushort itemNo)
    {
    }

    //public static ushort GetItemShortcut(int id)
    //{
        //IL_0003: Expected I4, but got O
        //return (ushort)(int)null;
    //}

    public static int GetItemShortcutId(ushort itemNo)
    {
        return 0;
    }

    public static int GetItemShortcutRegisteredCount()
    {
        return 0;
    }

    public static object GetBoxData()
    {
        return null;
    }

    public static object GetBoxTray(int tray)
    {
        return null;
    }

    public static object GetBallDecoData()
    {
        return null;
    }

    public static object GetSealData(int id)
    {
        return null;
    }

    public static object SetSealData(int id, object value)
    {
        return null;
    }

    public static void SetFormNormal()
    {
    }

    public static bool IsFormNormal()
    {
        return false;
    }

    public static void SetFormBicycle()
    {
    }

    public static bool IsFormBicycle()
    {
        return false;
    }

    public static void SetFormSwim()
    {
    }

    public static bool IsFormSwim()
    {
        return false;
    }

    public static bool GetGakusyuusoutiFlag()
    {
        return false;
    }

    public static uint GenerateUniqueId()
    {
        return 0u;
    }

    public static void CreateAlpha1Party(object party)
    {
    }

    public static void DebugResetWork()
    {
    }

    public static void GetDateTime(object year, object month, object day)
    {
    }

    public static void SetPlayerStatus(int selectIndex, string name)
    {
    }

    public static void SetPlayerStatus(bool sex, int colorId, string name)
    {
    }

    public static object GetPhotoDataByCategoryID(object categoryID)
    {
        return null;
    }

    public static void SetPhotoDataByCategoryID(object categoryID, object newData)
    {
    }

    public static object GetPhotoLangIdByCategoryID(object categoryID)
    {
        return null;
    }

    public static int GetTrainerRank()
    {
        return 0;
    }

    public static bool IsEasyInput()
    {
        return false;
    }

    public static bool VerifySaveData(object byteArray)
    {
        return false;
    }

    private void UpdateSaveDataHash()
    {
    }

    public static object GetLoadResult()
    {
        return null;
    }

    private static void TakeOverOldVersion()
    {
    }

    private void _003CCustomLoadAsyncOperation_003Eb__7_0(bool result)
    {
    }

    internal static object _003CSetWarp_003Eg__GetLocationWork_007C44_0(object P_0)
    {
        return null;
    }
}
