using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class UIDatabase
    {
        public object Item
        {
            get
            {
                return null;
            }
        }

        public GameObject UIWindow;

        public GameObject Transition;

        public GameObject SpriteAtlas;

        public GameObject SharedSprite;

        public GameObject CommonSprite;

        public GameObject PokemonIcon;

        public GameObject AshiatoIcon;

        public GameObject PokemonVoice;

        public GameObject MonsterBall;

        public GameObject ContextMenu;

        public GameObject Keyguide;

        public GameObject CharacterBag;

        public GameObject ZukanDisplay;

        public GameObject ZukanComparePlayer;

        public GameObject ZukanCompareHeight;

        public GameObject ZukanCompareWeight;

        public GameObject FloorDisplay;

        public GameObject ShopMessage;

        public GameObject PlaceMark;

        public GameObject MarkColor;

        public GameObject Wallpaper;

        public GameObject Box;

        public GameObject PokeColor;

        public GameObject DistributionMapchip;

        public GameObject PolishedBadge;

        public GameObject SearchPokeIconSex;

        public GameObject HideWazaName;

        public GameObject HideTokusei;

        public GameObject ZukanRating;

        public GameObject BoxOpenParam;

        public GameObject SealTemplate;

        [Serializable]
        public class SheetAshiatoIcon : ScriptableObject
        {
            public int UniqueID;

            public string SideIconAssetName;

            public string BothIconAssetName;
        }

        [Serializable]
        public class SheetBox : ScriptableObject
        {
            public string MessageFile;

            public string MessageLabel;

            public GameObject Wallpaper;
        }

        [Serializable]
        public class SheetBoxOpenParam : ScriptableObject
        {
            public GameObject MonsNo;

            public int SelectCount;

            public int Level;

            public bool IsTrade;

            public bool IsEnableParty;

            public bool IsEnableDying;
        }

        [Serializable]
        public class SheetCharacterBag : ScriptableObject
        {
            public int Index;

            public string XMenuDefault;

            public string XMenuSelect;

            public string XMenuShadow;

            public string BagHeader;

            public string BagBase;

            public object BagPockets;
        }

        [Serializable]
        public class SheetCommonSprite : ScriptableObject
        {
            public string SpriteName;
        }

        [Serializable]
        public class SheetContextMenu : ScriptableObject
        {
            public string MessageFile;

            public string MessageLabel;
        }

        [Serializable]
        public class SheetDistributionMapchip : ScriptableObject
        {
            public string SpriteName;

            public bool FlipX;

            public bool FlipY;
        }

        [Serializable]
        public class SheetFloorDisplay : ScriptableObject
        {
            public string MessageFile;

            public string MessageLabel;
        }

        [Serializable]
        public class SheetHideTokusei : ScriptableObject
        {
            public string TokuseiID;
        }

        [Serializable]
        public class SheetHideWazaName : ScriptableObject
        {
            public string WazaID;
        }

        [Serializable]
        public class SheetKeyguide : ScriptableObject
        {
            public GameObject ButtonSpriteId;

            public string MessageFile;

            public string MessageLabel;
        }

        [Serializable]
        public class SheetMarkColor : ScriptableObject
        {
            public Color32 Color;
        }

        [Serializable]
        public class SheetMonsterBall : ScriptableObject
        {
            public GameObject BallId;

            public GameObject ItemNo;
        }

        [Serializable]
        public class SheetPlaceMark : ScriptableObject
        {
            public string SpriteName;

            public GameObject CassetVersions;
        }

        [Serializable]
        public class SheetPokeColor : ScriptableObject
        {
            public Color32 Color;
        }

        [Serializable]
        public class SheetPokemonIcon : ScriptableObject
        {
            public int UniqueID;

            public string AssetBundleName;

            public string AssetName;

            public string AssetBundleNameLarge;

            public string AssetNameLarge;

            public Vector2 HallofFameOffset;
        }

        [Serializable]
        public class SheetPokemonVoice : ScriptableObject
        {
            public int UniqueID;

            public string WwiseEvent;

            public string stopEventId;

            public Vector3 CenterPointOffset;

            public bool RotationLimits;

            public Vector2 RotationLimitAngle;
        }

        [Serializable]
        public class SheetPolishedBadge : ScriptableObject
        {
            public ushort Value;
        }

        [Serializable]
        public class SheetSealTemplate : ScriptableObject
        {
            public string MessageFile;

            public string TitleMessageLabel;

            public string NameMessageLabel;

            public string TrainerImageFile;

            public string TrainerEmblemFile;
        }

        [Serializable]
        public class SheetSearchPokeIconSex : ScriptableObject
        {
            public GameObject MonsNo;

            public int Sex;
        }

        [Serializable]
        public class SheetSharedSprite : ScriptableObject
        {
            public string SpriteName;
        }

        [Serializable]
        public class SheetShopMessage : ScriptableObject
        {
            public object Message0;

            public object Message1;

            public object Message2;

            public object Message3;

            public object Message4;

            public object Message5;

            public object Message6;

            public object Message7;

            public object Message8;
        }

        [Serializable]
        public class SheetSpriteAtlas : ScriptableObject
        {
            public string AssetBundleName;

            public string AssetName;

            public bool Resident;

            public bool IsLanguage;
        }

        [Serializable]
        public class SheetTransition : ScriptableObject
        {
            public string AssetBundleName;

            public string AssetName;
        }

        [Serializable]
        public class SheetUIWindow : ScriptableObject
        {
            public int WindowAnimId;

            public string AssetBundleName;

            public string AssetName;

            public bool Resident;

            public int UiCameraMode;

            public bool Firstload;
        }

        [Serializable]
        public class SheetWallpaper : ScriptableObject
        {
            public string MessageFile;

            public string MessageLabel;

            public Color32 Color;
        }

        [Serializable]
        public class SheetZukanCompareHeight : ScriptableObject
        {
            public int UniqueID;

            public float PlayerScaleFactor;

            public Vector3 PlayerOffset;

            public Vector2 PlayerRotationAngle;
        }

        [Serializable]
        public class SheetZukanComparePlayer : ScriptableObject
        {
            public bool Sex;

            public ushort Height;

            public ushort Weight;
        }

        [Serializable]
        public class SheetZukanCompareWeight : ScriptableObject
        {
            public int No;

            public ushort DiffMin;

            public ushort DiffMax;
        }

        [Serializable]
        public class SheetZukanDisplay : ScriptableObject
        {
            public int UniqueID;

            public Vector3 MoveLimit;

            public Vector3 ModelOffset;

            public Vector2 ModelRotationAngle;
        }

        [Serializable]
        public class SheetZukanRating : ScriptableObject
        {
            public bool IsZenkokuZukan;

            public bool IsGetCount;

            public GameObject OtherCondition;

            public ushort RatingMinCount;

            public ushort RatingMaxCount;

            public string MessageFile;

            public string MessageLabel1;

            public string MessageLabel2;

            public string MessageLabel3;
        }
    }
}
