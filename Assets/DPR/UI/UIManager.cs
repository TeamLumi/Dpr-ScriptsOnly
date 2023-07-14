using SmartPoint.AssetAssistant;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.U2D;
using XLSXContent;
using static Dpr.EvScript.EvCmdID;

namespace Dpr.UI
{
    public class UIManager : SingletonMonoBehaviour<UIManager>
    {
        private static UIManager _instance;

        public bool IsInitialized
        {
            get
            {
                return _instance != null && (_InitializeStateBits & ~10) == 0;
            }
        }

        public int TransitionId
        {
            get
            {
                return _transitionId;
            }
        }

        public bool IsFadeTransition
        {
            get
            {
                return IsFadeTransition;
            }
        }

        //public RectTransform ModelBgRoot
        //{
            //get
            //{
                //return _modelView._modelBgRoot;
            //}
        //}

        public UIDatabase Database
        {
            get
            {
                return _mdUis;
            }
        }

        public TownMapGuideTable TownMapGuideTable
        {
            get
            {
                return _mdTownmapGuide;
            }
        }

        public TownMapTable TownMapTable
        {
            get
            {
                return _mdTownmap;
            }
        }

        public object distributionTable
        {
            get
            {
                return null;
            }
        }

        public object placeNameTable
        {
            get
            {
                return null;
            }
        }

        public object inputLimitTable
        {
            get
            {
                return null;
            }
        }

        public bool IsResidentSpriteAtlases
        {
            get
            {
                return false;
            }
        }

        public object modelView
        {
            get
            {
                return null;
            }
        }

        public object searchIndexData
        {
            get
            {
                return null;
            }
        }

        protected bool Awake()
        {
            return false;
        }

        public void RegisterOnDestroy()
        {
        }

        private void OnEnable()
        {
        }

        private void OnDisable()
        {
        }

        private void Destroy()
        {
        }

        public IEnumerator Start()
        {
            return null;
        }

        private void OnSettingValueChanged(object configId, int value)
        {
        }

        public void LoadResidents()
        {
        }

        public void LoadWindows(bool isOpening)
        {
        }

        public void Reload(object unloadLangId, UnityAction onComplete, bool isUnload)
        {
        }

        private IEnumerator OpReload(object unloadLangId, UnityAction onComplete, bool isUnload)
        {
            return null;
        }

        private void UnloadLanguageSpriteAtlases(object langId)
        {
        }

        private IEnumerator OpLoad(int type, bool isOpening)
        {
            return null;
        }

        private IEnumerator OpLoadDatabase()
        {
            return null;
        }

        private void CreateInputLimitHashSet(object type, object inputLimitDatas)
        {
        }

        private IEnumerator OpLoadResidentSpriteAtlases(bool isVariant)
        {
            return null;
        }

        private IEnumerator DoParallel()
        {
            return null;
        }

        private IEnumerator OpLoadSpriteAtlases(object spriteAtlasIds)
        {
            return null;
        }

        private int FindSpriteAtlasIndex(string assetName)
        {
            return 0;
        }

        public void UnloadSpriteAtlases(object spriteAtlasIds)
        {
        }

        private void OnAtlasRequested(string name, object atlasCallback)
        {
        }

        private IEnumerator OpWaitDatabase(string name, object atlasCallback)
        {
            return null;
        }

        public SpriteAtlas GetSpriteAtlas(object spriteAtlasId)
        {
            return null;
        }

        public Sprite GetAtlasSprite(object spriteAtlasId, string name)
        {
            return null;
        }

        public void ClearCachedSprites()
        {
        }

        public void ClearAtlasSprites()
        {
        }

        public void ClearAtlasSprite(object spriteAtlasId)
        {
        }

        private IEnumerator OpLoadSpriteMonsterBall()
        {
            return null;
        }

        public IEnumerator LoadSearchIndexData()
        {
            return null;
        }

        public void InitializeAfterLangDecide(object onComplete)
        {
        }

        public IEnumerator OpInitializeAfterLangDecide(object onComplete)
        {
            return null;
        }

        public void LoadCharacterModels()
        {
        }

        private IEnumerator OpLoadCharacterModels()
        {
            return null;
        }

        public static bool IsMaleDress(object dressData)
        {
            return false;
        }

        public void PlayTransition(object transitionId, object fadeType, object onComplete)
        {
        }

        private IEnumerator OpLoadResidentWindows(bool isCheckFirstLoad)
        {
            return null;
        }

        private void UnloadResidentWindows(bool isCheckFirstLoad)
        {
        }

        public IEnumerator OpLoadWindows(object windowIds, bool isVariant)
        {
            return null;
        }

        private void UnloadAssetBundleByWindow(object uiWindowData, bool isVariant)
        {
        }

        private int UnloadAssetBundle(string assetBundleName, bool isVariant, object langId)
        {
            return 0;
        }

        private int FindWindowDataIndex(string assetName)
        {
            return 0;
        }

        public void UnloadWindows(object windowIds, bool isVariant)
        {
        }

        public object CreateUIWindow(object windowId)
        {
            return null;
        }

        public void SetupSortOrder(object uiwindow)
        {
        }

        public object GetCurrentUIWindow()
        {
            return null;
        }

        internal void _ReleaseUIWindow(object window)
        {
        }

        internal void _SetupKeyAssign(object inputMode)
        {
        }

        private void LateUpdate()
        {
        }

        public void EnableAutoUnloadUnused(bool enabled)
        {
        }

        public Sprite GetSharedSprite(object sharedSpriteId)
        {
            return null;
        }

        public Sprite GetSpritePokemonSex(object sex)
        {
            return null;
        }

        public object GetPokemonIconData(object monsNo, ushort formNo, object sex, object rareType, bool isEgg)
        {
            return null;
        }

        public object GetAshiatoIconData(object monsNo, ushort formNo, object sex, object rareType, bool isEgg)
        {
            return null;
        }

        public object GetZukanDisplayData(object pokemonParam)
        {
            return null;
        }

        public object GetZukanDisplayData(object monsNo, ushort formNo, object sex, object rareType, bool isEgg)
        {
            return null;
        }

        public object GetPokemonVoiceData(object monsNo, ushort formNo, object sex, object rareType, bool isEgg)
        {
            return null;
        }

        public object GetPokemonVoiceData(int uniqueId)
        {
            return null;
        }

        public object GetZukanComparePlayerData(bool playerSex)
        {
            return null;
        }

        public object GetZukanCompareHeightData(object monsNo, ushort formNo, object sex, object rareType, bool isEgg)
        {
            return null;
        }

        public object GetZukanCompareWeightData(int diffWeight)
        {
            return null;
        }

        public object GetZukanRatingData(bool isZenkokuZukan)
        {
            return null;
        }

        public static string GetPokemonAssetbundleName(int uniqueId)
        {
            return "";
        }

        public object GetContextMenuData(object contextMenuId)
        {
            return null;
        }

        public static object GetLanguageMessage(uint langId)
        {
            return null;
        }

        public static string GetCurrentIetfCode()
        {
            return "";
        }

        public static object GetMessageLangIdFromIetfCode(string ietfCode)
        {
            return null;
        }

        public Sprite GetSpriteMonsterBall(object ballId)
        {
            return null;
        }

        public static uint GetParentId(object pokemonParam)
        {
            return 0U;
        }

        public Sprite GetSpritePokemonType(int typeNo)
        {
            return null;
        }

        public Sprite GetSpritePokemonTypeZukan(int typeNo, object langId)
        {
            return null;
        }

        public Sprite GetSpritePokemonLanguage(object langId)
        {
            return null;
        }

        public Sprite GetSpritePlaceMark(uint cassetVersion)
        {
            return null;
        }

        public Sprite GetSpriteWazaDamageType(object wazaDamageType)
        {
            return null;
        }

        public Sprite GetHpBgSprite()
        {
            return null;
        }

        //public Color32 GetMarkColor(int type)
        //{
        //return null;
        //}

        //public Color32 GetPokeColor(int type)
        //{
        //return null;
        //}

        public object GetWallPaper(int type)
        {
            return null;
        }

        public int GetWallPaperMax()
        {
            return 0;
        }

        public int GetSearchPokeIconSex(object monsNo)
        {
            return 0;
        }

        public object GetBoxData(int no)
        {
            return null;
        }

        public object GetBoxOpenData(int type)
        {
            return null;
        }

        public bool IsDisplayWazaString(string wazaMessageID)
        {
            return false;
        }

        public bool IsDisplayTokuseiString(string tokuseiMessageID)
        {
            return false;
        }

        public object GetKeyguide(bool isCreate)
        {
            return null;
        }

        internal void _ClearKeyguide()
        {
        }

        public object GetKeyguideData(object keyguideId)
        {
            return null;
        }

        public void ReleaseKeyguide()
        {
        }

        public static object GetLikeTaste(object pokemonParam)
        {
            return null;
        }

        public static object ToBattlePokemonParam(object pokemonParam)
        {
            return null;
        }

        public static object ToPokemonParam(object battlePokemonParam)
        {
            return null;
        }

        public static object CreatePokemonParamsByBattle()
        {
            return null;
        }

        public static object CreatePokemonParamByBattle(object battlePokemonParam)
        {
            return null;
        }

        public static object GetTeamPokemon(int team, int pos)
        {
            return null;
        }

        public static bool IsFieldWaza(object wazaNo)
        {
            return false;
        }

        public static void ReturnItemInBag(object pokemonParam)
        {
        }

        public void LoadSpritePokemon(object pokemonParam, object onComplete)
        {
        }

        public Sprite LoadSpritePokemonDirect(object monsNo, ushort formNo, object sex, object rareType, bool isEgg)
        {
            return null;
        }

        public void LoadSpritePokemon(object monsNo, ushort formNo, object sex, object rareType, bool isEgg, object onComplete)
        {
        }

        public void LoadSpritePokemonLarge(object pokemonParam, object onComplete)
        {
        }

        public void LoadSpritePokemonLarge(object monsNo, ushort formNo, object sex, object rareType, bool isEgg, object onComplete)
        {
        }

        public void LoadSpriteItem(object itemNo, object onComplete)
        {
        }

        public static int Repeat(int value, int start, int end)
        {
            return 0;
        }

        public static void ScreenScaled(object v)
        {
        }

        //public static Vector2 ComputeLocalCornerPosition(RectTransform rectTrans, int cornerIndex, object baseRectTrans, object canvasCamera)
        //{
        //return null;
        //}

        public static object DuplicateImageMaterials(Transform trans)
        {
            return null;
        }

        public static void RestoreDuplicateImageMaterials(object duplicateImageMaterialParams)
        {
        }

        public static void DestroyCanvasRendererMaterials(GameObject gameObj)
        {
        }

        public void Grayscale(Transform trans, bool value)
        {
        }

        public void SetOnCloseXMenu(object onClosed_)
        {
        }

        public void CloseXMenu(object onCall)
        {
        }

        public object SetupCurrentTownmapGuideMessage()
        {
            return null;
        }

        public object GetCurrentTownmapGuideData()
        {
            return null;
        }

        public object GetTownmapGuideData(int guideId)
        {
            return null;
        }

        public object GetPlaceNameData(object zoneId)
        {
            return null;
        }

        public object GetPlaceNameData(int placeId)
        {
            return null;
        }

        public object GetPlayerCharacterBagData()
        {
            return null;
        }

        public object GetCharacterBagData(int characterDressId)
        {
            return null;
        }

        public void NowLoadingOpen(float waitTime, int sortOrder)
        {
        }

        public void NowLoadingClose()
        {
        }

        public void UseDSPlayerItem()
        {
        }

        public void FadeinBlurBg(float time, object onComplete)
        {
        }

        public void FadeoutBlurBg(float time, object onComplete)
        {
        }

        public bool IsActiveFadeBlur()
        {
            return false;
        }

        public void SetActiveFadeBlur(bool enabled)
        {
        }

        internal void _CaptureBlueImage(bool enabled)
        {
        }

        private void UpdateBlurBg()
        {
        }

        public static bool FrameCountToSeconds(int frameCount)
        {
            return false;
        }

        public object GetDistributionDatas(bool isField)
        {
            return null;
        }

        public static bool IsUnion()
        {
            return false;
        }

        public object GetInputLimitHashSet()
        {
            return null;
        }

        public static int GetDigit(int num)
        {
            return 0;
        }

        public static AsyncOperation UnloadUnusedAssets(bool isGcCollect)
        {
            return null;
        }

        public void EnableFureaiLimit(bool enabled)
        {
        }

        public bool IsFureaiLimit()
        {
            return false;
        }

        public static bool IsFureaiHiroba()
        {
            return false;
        }

        private static long GetUsedMemorySize()
        {
            return 0L;
        }

        private static long GetUnusedMemorySize()
        {
            return 0L;
        }

        public static bool IsLumpingRibbon(int ribbonNo)
        {
            return false;
        }

        public static int GetLumpingRibbonMaxNum(int ribbonNo)
        {
            return 0;
        }

        public Sprite GetSpriteRibbon(object pokemonParam, int ribbonNo)
        {
            return null;
        }

        public static string ToBinaryString(int val)
        {
            return "";
        }

        public static bool IsLeanFly()
        {
            return false;
        }

        public static int Fps()
        {
            return 0;
        }

        public static object GetCurrentLangId()
        {
            return null;
        }

    public Transform _activeRoot;

    public GameObject _modelView;

    public Transform _blurBgRoot;

    public int StickLLeft;

    public int StickLRight;

    public int StickLUp;

    public int StickLDown;

    public int ButtonA;

    public int ButtonB;

    public int ButtonX;

    public int ButtonY;

    public int ButtonPlusMinus;

    public int _sortingOrderWindow;

    public int _sortingOrderWindowAdd;

    public int _sortingOrderTransition;

    public string _hpBarSpriteName;

    public UIDatabase _mdUis;

    public TownMapGuideTable _mdTownmapGuide;

    public TownMapTable _mdTownmap;

    public GameObject _mdDistribution;

    public GameObject _mdPlaceName;

    public GameObject _mdInputLimit;

    public GameObject _inputLimitHashSets;

    public GameObject _mdSearchIndexData;

    public GameObject _spriteMonsterBallDict;

    public Sprite _spriteMonsterBallStrange;

    public GameObject _spriteAtlasParams;

    public GameObject _residentVariantSpriteAtlasIds;

    public GameObject _keyguide;

    public int _InitializeStateBits;

    public GameObject onXMenuClosed;

    public bool _fureaiLimit;

    public GameObject onWazaFly;

    public GameObject onDressChanged;

    public GameObject onFieldWaza;

    public GameObject onUseFieldItem;

    public GameObject onUseItemInBattle;

    public GameObject onUseHidenWaza;

    public GameObject onUseDowsing;

    public GameObject _objectPool;

    public GameObject _objectPoolTransition;

    public GameObject _transitionInstances;

        public int _transitionId;

    public GameObject _cacheSpritePokemons;

    public GameObject _blurBg;

    public GameObject _blurBgParam;

    public GameObject _atlasSpriteDict;

    public GameObject _xMenu;

    public bool _isAutoUnloadUnused;

    public GameObject _comparerPokemonIcon;

    public GameObject _comparerAshiatoIcon;

    public GameObject _comparerZukanDisplay;

    public GameObject _comparerPokemonVoice;

    public GameObject _comparerZukanCompareHeight;

    public GameObject _langParams;

    public GameObject _pokemonParamMappings;

    public int _id_GrayscaleAmount;

    public GameObject _comparerTownMapGuide;

    public GameObject _comparerPlaceName;

    public GameObject _nowLoading;

    private void Dispose()
    {
    }

    private bool MoveNext()
    {
        return false;
    }

    private object Current
    {
        get
        {
            return null;
        }
    }

    private void Reset()
    {
    }

        protected IEnumerator FadeTransition(Color color, bool duration, Action action)
        {
            return null;
        }

        public GameObject monsterBallData;

public string assetPath;

public GameObject dbUiWindows;

public GameObject windowIds;

public bool isVariant;

public bool playerSex;

public int diffWeight;

public uint langId;

public string ietfCode;

public GameObject pokemonParam;

public GameObject battlePokemonParam;

public int uniqueId;

public GameObject cache;

public GameObject onComplete;

public string assetBundleName;

public int characterDressId;

public object assetBundleNames;

public int type;

public bool isOpening;

public bool isCheckFirstLoad;

public GameObject spriteAtlasIds;

public bool isUnload;

public GameObject unloadLangId;


public string name;

public GameObject atlasCallback;

private sealed class AtlasSpriteKey : ScriptableObject
{
    public GameObject spriteAtlasId;

    public string name;
}

private class BlugBgParam : ScriptableObject
{
    public GameObject fadeType;

    public float srcAlpha;

    public float destAlpha;

    public float time;

    public float maxTime;

    public GameObject onComplete;

    public bool isCapture;

    public GameObject captureBlurTexture;

    public GameObject blankTexture;

    public sealed class FadeType : ScriptableObject
    {
        public int value__;

        public GameObject In;

        public GameObject Out;
    }
}

private class CacheSpritePokemonParam
{
    public void Destroy()
    {
    }

    public int uniqueId;

    public GameObject sprite;
}

private class ComparerAshiatoIcon
{
    public int Compare(object x, object y)
    {
        return 0;
    }
}

private class ComparerPlaceName
{
    public int Compare(object x, object y)
    {
        return 0;
    }
}

private class ComparerPokemonIcon
{
    public int Compare(object x, object y)
    {
        return 0;
    }
}

private class ComparerPokemonVoice
{
    public int Compare(object x, object y)
    {
        return 0;
    }
}

private class ComparerTownMapGuide
{
    public int Compare(object x, object y)
    {
        return 0;
    }
}

private class ComparerZukanCompareHeight
{
    public int Compare(object x, object y)
    {
        return 0;
    }
}

private class ComparerZukanDisplay
{
    public int Compare(object x, object y)
    {
        return 0;
    }
}

public class DuplicateImageMaterialParam : ScriptableObject
{
    public GameObject image;

    public GameObject material;
}

public class EnvironmentControllerSaver
{
    public void Save(bool isReset)
    {
    }

    public void Restore()
    {
    }

    public bool isSaved;

    public bool actived;

    public bool enabled;
}

public sealed class FieldUseResult : ScriptableObject
{
    public int value__;

    public GameObject Available;

    public GameObject Unusable;

    public GameObject Unusable_PairTrainer;
}

public class FieldWazaParam : ScriptableObject
{
    public GameObject wazaNo;

    public GameObject pokemon;

    public GameObject targetPokemon;
}

private sealed class InitializeStateBit : ScriptableObject
{
    public int value__;

    public GameObject EntrySpriteAtlas;

    public GameObject LoadedSpriteAtlas;

    public GameObject EntryWindows;

    public GameObject LoadedWindows;

    public GameObject Loaded;
}

private sealed class InputLimitType : ScriptableObject
{
    public int value__;

    public GameObject JPN;

    public GameObject KOR;

    public GameObject TCH;

    public GameObject SCH;

    public GameObject EFIGS;

    public GameObject Num;
}

private class LangParam : ScriptableObject
{
    public GameObject langId;

    public string label;

    public object ietfTags;
}

private class MonsterBallParam : ScriptableObject
{
    public GameObject itemNo;

    public GameObject ballId;

    public GameObject sprite;
}

private class PokemonParamMapping : ScriptableObject
{
    public GameObject battlePokemonParam;

    public GameObject pokemonParam;
}

public class SpriteAtlasParam
{
    public void Clear()
    {
    }

    public void SetSpriteAtlas(SpriteAtlas spriteAtlas_)
    {
    }

    public void SetAtlasCallback(object atlasCallback_)
    {
    }

    private void Call()
    {
    }

    public GameObject spriteAtlasId;

    public string assetBundleName;

    public string assetName;

    public string variantAssetBundleName;

    public GameObject spriteAtlas;

    public GameObject atlasCallback;
}

private class TransitionInstance
{
    private void SetGameObject(GameObject obj)
    {
    }

    private GameObject GetGameObject()
    {
        return null;
    }

    private void OnCreate()
    {
    }

    private void OnRelease()
    {
    }

    public GameObject transition;

    public GameObject transitionId;
}

public class UIInstance
{
    public object uiWindow
    {
        get
        {
            return null;
        }
    }

    public object windowId
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    private void SetGameObject(GameObject obj)
    {
    }

    private GameObject GetGameObject()
    {
        return null;
    }

    private void OnCreate()
    {
    }

    private void OnRelease()
    {
    }

    public GameObject _uiWindow;

    public GameObject _windowId;
}
	}
}