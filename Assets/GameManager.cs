using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
//using Dpr.Message;
//using Il2CppDummyDll;
//using Pml;
//using ScriptableObjectFormat;
using SmartPoint.AssetAssistant;
//using SmartPoint.Components;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using XLSXContent;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    public class AfterInitType : ScriptableObject
    {
        public int Value;
        public GameObject LanguageSelect;
        public GameObject BackupLoad;
    }

    public class AfterLoadState : ScriptableObject
    {
        public int Value;
        public GameObject None;
        public GameObject Msbt;
        public GameObject Ui;
        public GameObject Ui2;
    }

    public class AfterInitializeType : ScriptableObject
    {
        public int Value;
        public GameObject Language;
        public GameObject Backup;
    }

    [Serializable]
    private class EncountData
    {
        public GameObject ZoneId;

        public bool GetFieldEncountData(object _)
        {
            return false;
        }
    }

    [Serializable]
    private class Initialization
    {
        public GameObject InitializationField1;
        public GameObject InitializationField2;
        public GameObject InitializationField3;
        public GameObject InitializationField4;
        public GameObject InitializationField5;
        public GameObject InitializationField6;

        public void Initialize() { }
        public void OnetimeInitializeOperation(object eventType, string name, UnityEngine.Object asset) { }
        public bool OnetimeInitializeOperation() { return false; }
        public void UpdateTargetScene() { }
    }

    private class LanguageReload
    {
        public GameObject OnLoaded;

        public void ReloadLanguage() { }
    }

    private class AfterInitialize
    {
        public GameObject OnLoaded;
        public GameObject OnLoaded2;

        public void AfterInitialize1() { }
        public void AfterInitialize2() { }
    }

    public static FieldCamera fieldCamera;

    private UnityEngine.Object fieldObjectHolder;

    public UnityEngine.Object FieldObjectHolder
    {
        get
        {
            return SingletonMonoBehaviour<GameManager>.Instance.fieldObjectHolder;
        }
    }

    private UnityEngine.Object battleObjectHolder;

    public UnityEngine.Object BattleObjectHolder
    {
        get
        {
            return SingletonMonoBehaviour<GameManager>.Instance.battleObjectHolder;
        }
    }

    private static bool isReady;

    public bool IsReady
    {
        get
        {
            return GameManager.isReady;
        }
        set
        {
            GameManager.isReady = value;
        }
    }

    private static XLSXContent.ArenaInfo arenaInfo;

    public XLSXContent.ArenaInfo ArenaInfo
    {
        get
        {
            return GameManager.arenaInfo;
        }
    }

    private static XLSXContent.CalenderEncTable calenderEncTable;

    public XLSXContent.CalenderEncTable CalenderEncTable
    {
        get
        {
            return GameManager.calenderEncTable;
        }
    }

    private static XLSXContent.FieldEncountTable fieldEncountTable;

    public XLSXContent.FieldEncountTable FieldEncountTable
    {
        get
        {
            if (PlayerWork.cassetVersion == 0x30)
            {
                return GameManager.fieldEncountTable;
            }
            else
            {
                return GameManager.fieldEncountTable;
            }
        }
    }

    private static XLSXContent.WaterSettings waterSettings;

    public XLSXContent.WaterSettings WaterSettings
    {
        get
        {
            return GameManager.waterSettings;
        }
    }

    private static bool afterStarting;

    public bool AfterStarting
    {
        get
        {
            return GameManager.afterStarting;
        }
        set
        {
            GameManager.afterStarting = value;
        }
    }

    private static bool playingEnding;

    public bool PlayingEnding
    {
        get
        {
            return GameManager.playingEnding;
        }
        set
        {
            GameManager.playingEnding = value;
        }
    }

    private static System.DateTime nowTime;

    public System.DateTime NowTime
    {
        get
        {
            return GameManager.nowTime;
        }
        set
        {
            GameManager.nowTime = value;
        }
    }

    private static Int64 tickOffset;

    public Int64 TickOffset
    {
        get
        {
            return GameManager.tickOffset;
        }
        set
        {
            GameManager.tickOffset = value;
        }
    }

    private static Int64 timeScale;

    public Int64 TimeScale
    {
        get
        {
            return GameManager.timeScale;
        }
        set
        {
            GameManager.timeScale = value;
        }
    }

    private static bool pause;

    public bool Pause
    {
        get
        {
            return GameManager.pause;
        }
        set
        {
            GameManager.pause = value;
        }
    }

    public float ElapsedTimeOfDay
    {
        get
        {
            long ticks = nowTime.Ticks;
            long scaledTicks = (tickOffset + timeScale * (ticks % 864000000000)) % 864000000000;
            return ((float)scaledTicks / 8.64e+11f) * 24.0f;
        }
    }

    public int CurrentPeriodOfDay
    {
        get
        {
            float elapsedTime = ElapsedTimeOfDay;
            if (elapsedTime < 2.0f)
            {
                return 3;
            }
            else if (elapsedTime < 4.0f)
            {
                return 4;
            }
            else if (elapsedTime < 10.0f)
            {
                return 0;
            }
            else if (elapsedTime < 17.0f)
            {
                return 1;
            }
            else if (elapsedTime < 20.0f)
            {
                return 2;
            }
            else
            {
                return 3;
            }
        }
    }

    public (int, float, float) CurrentPeriodOfDayEx
    {
        get
        {
            float elapsedTime = ElapsedTimeOfDay;
            float fVar2, fVar3;
            int period;

            if (elapsedTime < 2.0f)
            {
                fVar3 = 4.0f;
                fVar2 = (elapsedTime + fVar3) / 6.0f;
                fVar3 = Mathf.Max((fVar2 * 360.0f - 350.0f) * 0.1f, 0.0f);
                period = 3;
            }
            else if (elapsedTime < 4.0f)
            {
                fVar2 = (elapsedTime - 2.0f) * 0.5f;
                fVar3 = Mathf.Max((fVar2 * 120.0f - 110.0f) * 0.1f, 0.0f);
                period = 4;
            }
            else if (elapsedTime < 10.0f)
            {
                fVar2 = (elapsedTime - 4.0f) / 6.0f;
                fVar3 = Mathf.Max((fVar2 * 360.0f - 350.0f) * 0.1f, 0.0f);
                period = 0;
            }
            else if (elapsedTime < 17.0f)
            {
                fVar2 = (elapsedTime - 10.0f) / 7.0f;
                fVar3 = Mathf.Max((fVar2 * 420.0f - 410.0f) * 0.1f, 0.0f);
                period = 1;
            }
            else if (elapsedTime < 20.0f)
            {
                fVar2 = (elapsedTime - 17.0f) / 3.0f;
                fVar3 = Mathf.Max((fVar2 * 180.0f - 170.0f) * 0.1f, 0.0f);
                period = 2;
            }
            else
            {
                fVar3 = -20.0f;
                fVar2 = (elapsedTime + fVar3) / 6.0f;
                fVar3 = Mathf.Max((fVar2 * 360.0f - 350.0f) * 0.1f, 0.0f);
                period = 3;
            }

            return (period, fVar2, fVar3);
        }
    }

    public ScriptableObjectFormat.PokemonData DebugPokemonData
    {
        get
        {
            return Instance._debugPokemonData;
        }
    }

    private ScriptableObjectFormat.PokemonData _debugPokemonData;

    public XLSXContent.FieldEncountTable.Sheettable GetFieldEncountData(int zoneid)
    {
        if (Instance != null)
        {
            foreach (var item in _fieldEncountTable)
            {
                //if (item.ZoneId == zoneid)
                //{
                //return item;
                //}
            }
        }
        return null;
    }

    //public List<Sheethoneytree> GetHoneyTreeEncountLotteryTable()
    //{
    //if (FieldEncountTable == null)
    //{
    //return null;
    //}

    //return FieldEncountTable.honeytree;
    //}

    private List<XLSXContent.FieldEncountTable.Sheettable> _fieldEncountTable;

    void GetHoneyTreeEncountTable()
    {

    }

    void GetSafariMonsNo()
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
