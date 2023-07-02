using System;
using System.Collections.Generic;
using UnityEngine;
using static Dpr.Message.MessageEnumData;

namespace Dpr.Message
{
    [Serializable]
    public class MsbtData : ScriptableObject
    {
        public int hash;
        public MsgLangId langID;
        public bool isResident;
        public bool isKanji;
        public List<LabelData> labelDataArray;
    }

    [Serializable]
    public class StyleInfo
    {
        public int styleIndex;
        public int colorIndex;
        public int fontSize;
        public int maxWidth;
        public int controlID;
    }

    [Serializable]
    public class TagData
    {
        public int tagIndex;
        public int groupID;
        public int tagID;
        public int tagPatternID;
        public int forceArticle;
        public int tagParameter;
        public List<object> tagWordArray;
        public int forceGrmID;
    }

    [Serializable]
    public class WordData
    {
        public int patternID;
        public int eventID;
        public int tagIndex;
        public int tagValue;
        public string str;
        public float strWidth;
    }

    [Serializable]
    public class LabelData
    {
        public int labelIndex;
        public int arrayIndex;
        public string labelName;
        public StyleInfo styleInfo;
        public List<object> attributeValueArray;
        public List<TagData> tagDataArray;
        public List<WordData> wordDataArray;
    }
}
