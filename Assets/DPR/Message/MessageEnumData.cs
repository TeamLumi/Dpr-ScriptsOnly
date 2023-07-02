using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Dpr.Message
{
    public static class MessageEnumData
    {
        public enum MsgLangId
        {
            None = 0,
            JPN,
            USA,
            FRA,
            ITA,
            DEU,
            ESP,
            KOR,
            SCH,
            TCH,
            Num
        }

        public enum NXLangId
        {
            None = 0,
            Japanese,
            English,
            French,
            German,
            Italian,
            Spanish,
            Korean,
            NetherLands,
            Portuguese,
            Russian,
            SimpChinese,
            TradChinese
        }

        public enum TagPatternID
        {
            None = 0,
            Word,
            Digit,
            Conversion,
            RichText,
            Grammar,
            GrammarWord,
            ControlDesign,
            ControlMessage,
            SpriteFont
        }

        public enum InitialSoundID
        {
            None = 0,
            Vowel,
            VowelA,
            VowelE,
            Vowel2,
            Vowel3,
            Consonant2,
            Consonant
        }


        public sealed class AttributeID : ScriptableObject
        {
            public int value__;

            public GameObject EnglishInitialSound;

            public GameObject EnglishCountability;

            public GameObject EnglishArticlePresence;

            public GameObject FrenchGender;

            public GameObject FrenchInitialSound;

            public GameObject FrenchCountability;

            public GameObject FrenchExtraAttribute;

            public GameObject FrenchArticlePresence;

            public GameObject ItalianGender;

            public GameObject ItalianInitialSound;

            public GameObject ItalianCountability;

            public GameObject ItalianArticlePresence;

            public GameObject GermanGender;

            public GameObject GermanCountability;

            public GameObject GermanExtraAttribute;

            public GameObject GermanArticlePresence;

            public GameObject SpanishGender;

            public GameObject SpanishInitialSound;

            public GameObject SpanishCountability;

            public GameObject SpanishExtraAttribute;

            public GameObject SpanishArticlePresence;

            public GameObject LabelIndex;

            public GameObject Version;
        }

        public sealed class AttriCountabilityID : ScriptableObject
        {
            public int value__;

            public GameObject Countable;

            public GameObject Uncontable;

            public GameObject AlwaysPlural;
        }

        public sealed class AttriArticleID : ScriptableObject
        {
            public int value__;

            public GameObject Article;

            public GameObject NoArticle;
        }

        public sealed class ENInitialSoundID : ScriptableObject
        {
            public int value__;

            public GameObject AutoDetected;

            public GameObject Consonant;

            public GameObject Vowel;
        }

        public sealed class FRInitialSoundID : ScriptableObject
        {
            public int value__;

            public GameObject AutoDetected;

            public GameObject NoElision;

            public GameObject YesElision;
        }

        public sealed class ITInitialSoundID : ScriptableObject
        {
            public int value__;

            public GameObject AutoDetected;

            public GameObject ConsonantOthers;

            public GameObject S_Consonant;

            public GameObject Vowel;
        }

        public sealed class ESInitialSoundID : ScriptableObject
        {
            public int value__;

            public GameObject AutoDetected;

            public GameObject Consonant;

            public GameObject Cacophony_y;

            public GameObject TonicaA;

            public GameObject Cacophony_o;
        }

        public sealed class StyleID : ScriptableObject
        {
            public int value__;

            public GameObject keywait_text_18_big;

            public GameObject keywait_text_23_big;

            public GameObject keywait_text_28_big;

            public GameObject std_1_N_big;

            public GameObject std_4_N_big;

            public GameObject std_6_N_big;

            public GameObject std_7_N_big;

            public GameObject std_8_N_big;

            public GameObject std_10_N_big;

            public GameObject std_10_N2_big;

            public GameObject std_11_N_big;

            public GameObject std_11_N2_big;

            public GameObject std_12_N_big;

            public GameObject std_12_N2_big;

            public GameObject std_14_N_big;

            public GameObject std_15_N_big;

            public GameObject std_15_N4_big;

            public GameObject std_16_N_big;

            public GameObject std_17_N_big;

            public GameObject std_18_N_big;

            public GameObject std_18_N2_big;

            public GameObject std_18_N3_big;

            public GameObject std_18_N4_big;

            public GameObject std_18_N5_big;

            public GameObject std_18_N6_big;

            public GameObject std_18_N7_big;

            public GameObject std_18_N10_big;

            public GameObject std_20_N4_big;

            public GameObject std_23_N_big;

            public GameObject std_23_N2_big;

            public GameObject keywait_text_18;

            public GameObject keywait_text_23;

            public GameObject std_01_N;

            public GameObject std_02_N;

            public GameObject std_03_N;

            public GameObject std_04_N;

            public GameObject std_05_N;

            public GameObject std_06_N;

            public GameObject std_07_N;

            public GameObject std_08_N;

            public GameObject std_08_N2;

            public GameObject std_09_N;

            public GameObject std_10_N;

            public GameObject std_10_N2;

            public GameObject std_11_N;

            public GameObject std_11_N2;

            public GameObject std_12_N;

            public GameObject std_13_N;

            public GameObject std_14_N;

            public GameObject std_15_N;

            public GameObject std_16_N;

            public GameObject std_16_N2;

            public GameObject std_16_N4;

            public GameObject std_16_N5;

            public GameObject std_16_N7;

            public GameObject std_17_N;

            public GameObject std_18_N;

            public GameObject std_18_N2;

            public GameObject std_18_N3;

            public GameObject std_18_N4;

            public GameObject std_18_N5;

            public GameObject std_18_N6;

            public GameObject std_18_N7;

            public GameObject std_18_N8;

            public GameObject std_18_N10;

            public GameObject std_20_N;

            public GameObject std_20_N6;

            public GameObject std_20_N12;

            public GameObject std_21_N;

            public GameObject std_21_N3;

            public GameObject std_22_N2;

            public GameObject std_23_N;

            public GameObject std_23_N2;

            public GameObject std_24_N;

            public GameObject std_30_N;

            public GameObject std_43_N;

            public GameObject std_01_N_small;

            public GameObject std_02_N_small;

            public GameObject std_03_N_small;

            public GameObject std_04_N_small;

            public GameObject std_05_N_small;

            public GameObject std_06_N_small;

            public GameObject std_07_N_small;

            public GameObject std_08_N_small;

            public GameObject std_08_N2_small;

            public GameObject std_08_N3_small;

            public GameObject std_09_N_small;

            public GameObject std_10_N_small;

            public GameObject std_10_N2_small;

            public GameObject std_10_N3_small;

            public GameObject std_11_N_small;

            public GameObject std_12_N_small;

            public GameObject std_13_N_small;

            public GameObject std_14_N_small;

            public GameObject std_15_N_small;

            public GameObject std_16_N_small;

            public GameObject std_16_N2_small;

            public GameObject std_16_N4_small;

            public GameObject std_16_N5_small;

            public GameObject std_16_N7_small;

            public GameObject std_16_N8_small;

            public GameObject std_16_N14_small;

            public GameObject std_18_N_small;

            public GameObject std_18_N2_small;

            public GameObject std_18_N3_small;

            public GameObject std_18_N5_small;

            public GameObject std_20_N2_small;

            public GameObject std_20_N3_small;

            public GameObject std_21_N_small;

            public GameObject std_21_N3_small;

            public GameObject std_22_N_small;

            public GameObject std_22_N3_small;

            public GameObject std_23_N_small;

            public GameObject std_23_N2_small;

            public GameObject std_23_N5_small;

            public GameObject std_32_N_small;

            public GameObject std_46_N_small;

            public GameObject std_10_G_big;

            public GameObject std_14_G_big;

            public GameObject std_05_G;

            public GameObject std_06_G;

            public GameObject std_08_G;

            public GameObject std_08_G_P;

            public GameObject std_08_G_C;

            public GameObject std_09_G;

            public GameObject std_10_G;

            public GameObject std_10_G_P;

            public GameObject std_10_G_C;

            public GameObject std_12_G;

            public GameObject std_12_G_P;

            public GameObject std_12_G_C;

            public GameObject std_14_G;

            public GameObject std_15_G;

            public GameObject std_16_G;

            public GameObject std_05_G_small;

            public GameObject std_06_G_small;

            public GameObject std_08_G_P_small;

            public GameObject std_08_G_small;

            public GameObject std_10_G_small;

            public GameObject std_14_G_small;

            public GameObject std_01_S_big;

            public GameObject std_02_S_big;

            public GameObject std_03_S_big;

            public GameObject std_04_S_big;

            public GameObject std_05_S_big;

            public GameObject std_06_S_big;

            public GameObject std_01_S;

            public GameObject std_02_S;

            public GameObject std_03_S;

            public GameObject std_04_S;

            public GameObject std_05_S;

            public GameObject std_06_S;

            public GameObject std_07_S;

            public GameObject std_08_S;

            public GameObject std_09_S;

            public GameObject std_10_S;

            public GameObject std_11_S;

            public GameObject std_12_S;

            public GameObject std_14_S;

            public GameObject std_16_S;

            public GameObject std_17_S;

            public GameObject std_18_S;

            public GameObject std_19_S;

            public GameObject std_24_S;

            public GameObject std_01_S_small;

            public GameObject std_02_S_small;

            public GameObject std_03_S_small;

            public GameObject std_04_S_small;

            public GameObject std_05_S_small;

            public GameObject std_06_S_small;

            public GameObject std_07_S_small;

            public GameObject std_08_S_small;

            public GameObject std_09_S_small;

            public GameObject std_10_S_small;

            public GameObject std_11_S_small;

            public GameObject std_12_S_small;

            public GameObject std_14_S_small;

            public GameObject std_16_S_small;

            public GameObject std_17_S_small;

            public GameObject std_19_S_small;

            public GameObject std_24_S_small;

            public GameObject std_6_N_huge;

            public GameObject std_10_N_huge;

            public GameObject keywait_text_18_big_white;

            public GameObject keywait_text_18_big_1;

            public GameObject keywait_text_18_big_2;

            public GameObject keywait_text_18_big_3;

            public GameObject keywait_text_14_big_white;

            public GameObject Max;
        }

        public sealed class FontID : ScriptableObject
        {
            public int value__;

            public GameObject Switch_Std;

            public GameObject Switch_Small;

            public GameObject Switch_Big;

            public GameObject Switch_Std_efigs;

            public GameObject Switch_Small_efigs;

            public GameObject Switch_Big_efigs;

            public GameObject Switch_Std_kor;

            public GameObject Switch_Small_kor;

            public GameObject Switch_Big_kor;

            public GameObject Switch_Std_simp;

            public GameObject Switch_Small_simp;

            public GameObject Switch_Big_simp;

            public GameObject Switch_Std_trad;

            public GameObject Switch_Small_trad;

            public GameObject Switch_Big_trad;

            public GameObject Switch_Huge;

            public GameObject Switch_Huge_efigs;

            public GameObject Switch_Huge_kor;

            public GameObject Switch_Huge_simp;

            public GameObject Switch_Huge_trad;
        }

        public sealed class FontSizeID : ScriptableObject
        {
            public int value__;

            public GameObject Small;

            public GameObject Std;

            public GameObject Big;

            public GameObject Huge;
        }

        public sealed class GroupTagID : ScriptableObject
        {
            public int value__;

            public GameObject System;

            public GameObject Name;

            public GameObject Digit;

            public GameObject Grm;

            public GameObject EN;

            public GameObject FR;

            public GameObject IT;

            public GameObject DE;

            public GameObject ES;

            public GameObject Kor;

            public GameObject SC;

            public GameObject Character1;

            public GameObject Character2;

            public GameObject Ctrl1;

            public GameObject Ctrl2;
        }

        public sealed class SystemID : ScriptableObject
        {
            public int value__;

            public GameObject Font;

            public GameObject Size;

            public GameObject Color;
        }

        public sealed class NameID : ScriptableObject
        {
            public int value__;

            public GameObject TrainerName;

            public GameObject PokemonName;

            public GameObject PokemonNickname;

            public GameObject Type;

            public GameObject PokedexType;

            public GameObject Place;

            public GameObject Ability;

            public GameObject Move;

            public GameObject Nature;

            public GameObject Item;

            public GameObject ItemClassified;

            public GameObject ItemAcc;

            public GameObject PokemonNicknameTwo;

            public GameObject Status;

            public GameObject TrainerType;

            public GameObject Poffin;

            public GameObject ItemAccClassified;

            public GameObject GoodsName;

            public GameObject Pocket;

            public GameObject ItemText;

            public GameObject TrainerNameField;

            public GameObject Poketch;

            public GameObject UgItem;

            public GameObject BagPocketIcon;

            public GameObject PocketIcon;

            public GameObject Word;

            public GameObject Question;

            public GameObject Answer;

            public GameObject Accessory;

            public GameObject Gym;

            public GameObject TimeZone;

            public GameObject Contest;

            public GameObject ContestRank;

            public GameObject PokeGender;

            public GameObject PokeLevel;

            public GameObject GroupName;

            public GameObject Location;

            public GameObject Area;

            public GameObject Ribbon;

            public GameObject UndergroundItemDefArt;

            public GameObject UndergroundItemIndefArt;

            public GameObject Taste;

            public GameObject SerialNumber;

            public GameObject FreeWord;

            public GameObject Undefined;

            public GameObject PlayerNickname;

            public GameObject PlayerNicknamePrefix;

            public GameObject TrimmianFormName;

            public GameObject TrainerTypeAndName;

            public GameObject HairStyle_Name;

            public GameObject Bangs_Name;

            public GameObject HairColor_Name;

            public GameObject TournamentName;

            public GameObject FullPowerMove;

            public GameObject BattleState;

            public GameObject FlySpotName;

            public GameObject Record_Name;

            public GameObject BattleTeam;

            public GameObject BoxName;

            public GameObject KisekaeItem;

            public GameObject KisekaeItemColor;

            public GameObject BGM;

            public GameObject Uniformnumber;

            public GameObject BirthdayM;

            public GameObject BirthdayD;

            public GameObject TrainerNameUpperCase;

            public GameObject PokemonNicknameUpperCase;

            public GameObject CookName;

            public GameObject Classname;

            public GameObject AnotherName;

            public GameObject CompanyName;

            public GameObject PlaceIndirect;

            public GameObject FormName;

            public GameObject RegurationName;

            public GameObject Memory_Place;

            public GameObject Memory_Feeling;

            public GameObject Memory_Rank;

            public GameObject Sticker;

            public GameObject ParkItem;

            public GameObject Kinomi;

            public GameObject UgItemAcc;

            public GameObject UgItemClassified;

            public GameObject UgItemAccClassified;

            public GameObject PoffinAcc;

            public GameObject StyleName;

            public GameObject BattleRule;
        }

        public sealed class DigitID : ScriptableObject
        {
            public int value__;

            public GameObject OneDigit;

            public GameObject TwoDigits;

            public GameObject ThreeDigits;

            public GameObject FourDigits;

            public GameObject FiveDigits;

            public GameObject SixDigits;

            public GameObject SevenDigits;

            public GameObject EightDigits;

            public GameObject NineDigits;

            public GameObject TenDigits;
        }

        public sealed class GrmID : ScriptableObject
        {
            public int value__;

            public GameObject ForceSingular;

            public GameObject ForcePlural;

            public GameObject ForceMasculine;

            public GameObject ForceInitialCap;
        }

        public sealed class ENID : ScriptableObject
        {
            public int value__;

            public GameObject Gen;

            public GameObject Qty;

            public GameObject GenQty;

            public GameObject DefArt;

            public GameObject DefArtCap;

            public GameObject IndArt;

            public GameObject IndArtCap;

            public GameObject ForceSingular;

            public GameObject ForcePlural;

            public GameObject ForceInitialCap;

            public GameObject QtyZero;
        }

        public sealed class FRID : ScriptableObject
        {
            public int value__;

            public GameObject Gen;

            public GameObject Qty;

            public GameObject GenQty;

            public GameObject DefArt;

            public GameObject DefArtCap;

            public GameObject IndArt;

            public GameObject IndArtCap;

            public GameObject A_DefArt;

            public GameObject A_DefArtCap;

            public GameObject De_DefArt;

            public GameObject De_DefArtCap;

            public GameObject De;

            public GameObject DeCap;

            public GameObject ForceSingular;

            public GameObject ForcePlural;

            public GameObject Que;

            public GameObject QueCap;

            public GameObject Elision;

            public GameObject ForceInitialCap;

            public GameObject QtyZero;
        }

        public sealed class ITID : ScriptableObject
        {
            public int value__;

            public GameObject Gen;

            public GameObject Qty;

            public GameObject GenQty;

            public GameObject DefArt;

            public GameObject DefArtCap;

            public GameObject IndArt;

            public GameObject IndArtCap;

            public GameObject Di_DefArt;

            public GameObject Di_DefArtCap;

            public GameObject Su_DefArt;

            public GameObject Su_DefArtCap;

            public GameObject A_DefArt;

            public GameObject A_DefArtCap;

            public GameObject ForceSingular;

            public GameObject ForcePlural;

            public GameObject ForceMasculine;

            public GameObject In_DefArt;

            public GameObject In_DefArtCap;

            public GameObject Ed;

            public GameObject EdCap;

            public GameObject Ad;

            public GameObject AdCap;

            public GameObject ForceInitialCap;

            public GameObject QtyZero;

            public GameObject DateIT;
        }

        public sealed class DEID : ScriptableObject
        {
            public int value__;

            public GameObject Gen;

            public GameObject Qty;

            public GameObject GenQty;

            public GameObject DefArtNom;

            public GameObject DefArtNomCap;

            public GameObject IndArtNom;

            public GameObject IndArtNomCap;

            public GameObject DefArtAcc;

            public GameObject DefArtAccCap;

            public GameObject IndArtAcc;

            public GameObject IndArtAccCap;

            public GameObject ForceSingular;

            public GameObject ForcePlural;

            public GameObject ForceInitialCap;

            public GameObject QtyZero;

            public GameObject ItemAcc;

            public GameObject ItemAccClassified;
        }

        public sealed class ESID : ScriptableObject
        {
            public int value__;

            public GameObject Gen;

            public GameObject Qty;

            public GameObject GenQty;

            public GameObject DefArt;

            public GameObject DefArtCap;

            public GameObject IndArt;

            public GameObject IndArtCap;

            public GameObject De_DefArt;

            public GameObject De_DefArtCap;

            public GameObject A_DefArt;

            public GameObject A_DefArtCap;

            public GameObject DefArt_TrTypeAndName;

            public GameObject DefArtCap_TrTypeAndName;

            public GameObject A_DefArt_TrTypeAndName;

            public GameObject De_DefArt_TrTypeAndName;

            public GameObject ForceSingular;

            public GameObject ForcePlural;

            public GameObject ForceInitialCap;

            public GameObject QtyZero;

            public GameObject y_e;

            public GameObject Y_E;

            public GameObject o_u;

            public GameObject O_U;
        }

        public sealed class KorID : ScriptableObject
        {
            public int value__;

            public GameObject Particle;

            public GameObject Gen;

            public GameObject Qty;

            public GameObject GenQty;

            public GameObject QtyZero;
        }

        public sealed class SCID : ScriptableObject
        {
            public int value__;

            public GameObject Gen;
        }

        public sealed class Character1ID : ScriptableObject
        {
            public int value__;

            public GameObject heart;

            public GameObject music;

            public GameObject male;

            public GameObject female;

            public GameObject PokeDollar;

            public GameObject Left;

            public GameObject Up;

            public GameObject Right;

            public GameObject Down;

            public GameObject PocketIcon;

            public GameObject Item;

            public GameObject KeyItem;

            public GameObject Machine;

            public GameObject Seal;

            public GameObject Medicine;

            public GameObject Nut;

            public GameObject Ball;

            public GameObject Battle;

            public GameObject Staff;

            public GameObject LeftDirection;

            public GameObject UpDirection;

            public GameObject RightDirection;

            public GameObject DownDirection;

            public GameObject Sparkles;
        }

        public sealed class Character2ID : ScriptableObject
        {
            public int value__;

            public GameObject L_SingleQuot_;

            public GameObject R_SingleQuot_;

            public GameObject L_DoubleQuot_;

            public GameObject R_DoubleQuot_;

            public GameObject DE_L_DoubleQuot_;

            public GameObject DE_R_DoubleQuot_;

            public GameObject StraightSingleQuot_;

            public GameObject StraightDoubleQuot_;

            public GameObject HalfSpace;

            public GameObject QuarterSpace;

            public GameObject Upper_er;

            public GameObject Upper_re;

            public GameObject Upper_r;

            public GameObject Upper_e;

            public GameObject Upper_a;

            public GameObject Abbrev_;

            public GameObject Center_dot;

            public GameObject PKMN;

            public GameObject NULL;

            public GameObject ModifierLetterCapitalO;

            public GameObject SixPerEmSpace;
        }

        public sealed class Ctrl1ID : ScriptableObject
        {
            public int value__;

            public GameObject xright;

            public GameObject xadd;

            public GameObject xset;

            public GameObject battle_oneline;

            public GameObject unknown_message;
        }

        public sealed class Ctrl2ID : ScriptableObject
        {
            public int value__;

            public GameObject LineFeed;

            public GameObject PageClear;

            public GameObject WaitOne;

            public GameObject CallBackOne;

            public GameObject GuidIcon;
        }

        public sealed class DigitTagParamID : ScriptableObject
        {
            public int value__;

            public GameObject None;

            public GameObject Default;

            public GameObject Comma;

            public GameObject Period;

            public GameObject HalfSpace;

            public GameObject QuaterSpace;

            public GameObject Max;
        }

        public sealed class QtyID : ScriptableObject
        {
            public int value__;

            public GameObject Singular;

            public GameObject Plural;

            public GameObject Zero;
        }

        public sealed class GenderQtyID : ScriptableObject
        {
            public int value__;

            public GameObject MasculineSingular;

            public GameObject FeminineSingular;

            public GameObject MasculinePlural;

            public GameObject FemininePlural;
        }

        public sealed class DEGenderQtyID : ScriptableObject
        {
            public int value__;

            public GameObject MasculineSingular;

            public GameObject FeminineSingular;

            public GameObject NeuterSingular;

            public GameObject Plural;
        }

        public sealed class ForceGrmID : ScriptableObject
        {
            public int value__;

            public GameObject None;

            public GameObject Singular;

            public GameObject Plural;

            public GameObject Masculine;

            public GameObject InitialCap;
        }

        public sealed class MsgEventID : ScriptableObject
        {
            public int value__;

            public GameObject None;

            public GameObject NewLine;

            public GameObject Wait;

            public GameObject ScrollPage;

            public GameObject ScrollLine;

            public GameObject CallBack;

            public GameObject GuidIcon;

            public GameObject End;
        }

        public sealed class WordDataPatternID : ScriptableObject
        {
            public int value__;

            public GameObject Str;

            public GameObject FontTag;

            public GameObject ColorTag;

            public GameObject SizeTag;

            public GameObject CtrlTag;

            public GameObject WordTag;

            public GameObject SpriteFont;

            public GameObject Event;
        }

        public sealed class MsgControlID : ScriptableObject
        {
            public int value__;

            public GameObject None;

            public GameObject BattleOneline;

            public GameObject UnknownMessage;
        }

        public sealed class UIFontSizeID : ScriptableObject
        {
            public int value__;

            public GameObject SSS;

            public GameObject SS;

            public GameObject S;

            public GameObject M;

            public GameObject L;

            public GameObject LL;

            public GameObject LLL;

            public GameObject XL;

            public GameObject WazaKouka;
        }

        public sealed class GenderID : ScriptableObject
        {
            public int value__;

            public GameObject Masculine;

            public GameObject Feminine;

            public GameObject Neuter;
        }
    }
}
