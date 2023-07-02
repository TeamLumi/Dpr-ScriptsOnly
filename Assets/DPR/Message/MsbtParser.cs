using System;
using UnityEngine;

namespace Dpr.Message
{
    public class MsbtParser
    {
        public void Initialize()
        {
        }

        public object ParseMsbtBinData(object binDataArray, object langID, int patchVersion)
        {
            return null;
        }

        private object ParseMsbtFileData(object msbtByteDataArray)
        {
            return null;
        }

        private object ConvertParseTextDataToFormatMsbtData(object dataModel, int patchVersion)
        {
            return null;
        }

        private object CreateStyleInfo(int styleIndex, object controlID)
        {
            return null;
        }

        private object CreateAttributeInfo(object attributeDataModel)
        {
            return null;
        }

        private object CreateTagDataArray(object dataModel)
        {
            return null;
        }

        private void SetForceTagReference(object tagDataList)
        {
        }

        private void GrmTagReference(int listIndex, object tagId, object tagDataList)
        {
        }

        private void ENTagReference(int listIndex, object tagData, object tagDataList)
        {
        }

        private void FRTagReference(int listIndex, object tagData, object tagDataList)
        {
        }

        private void ITTagReference(int listIndex, object tagData, object tagDataList)
        {
        }

        private void DETagReference(int listIndex, object tagData, object tagDataList)
        {
        }

        private void ESTagReference(int listIndex, object tagData, object tagDataList)
        {
        }

        private void SetForceGrmId(int listIndex, object tagDataList, object forceGrmId)
        {
        }

        private object CreateWordDataArray(object parseDataModel, object errorMsg)
        {
            return null;
        }

        private object CreateEventDataByCtrl2ID(object tagId, bool tagParameter)
        {
            return null;
        }

        private void AddStrWordData(string str)
        {
        }

        private void AddNewLineWordData(object eventID, string str)
        {
        }

        public void SetFontAsset(object langID)
        {
        }

        private bool CalcStrWidth(string str)
        {
            return false;
        }

        public GameObject NEW_LINE_CHAR;

        public GameObject wordDataList;

        public GameObject parseProcessor;

        public GameObject msgLangID;

        public GameObject fontAsset;

        public float fontSize;

        public GameObject fontTagLangID;

        public int sizeTagScale;

        private class LabelDataModel
        {
            public object TagDataList
            {
                get
                {
                    return null;
                }
            }

            public GameObject parseDataModel;

            public string labelName;

            public int labelIndex;

            public int arrayIndex;

            public int styleIndex;

            public int patchVersion;
        }

        private class MsbtFileData
        {
            public int LabelNum
            {
                get
                {
                    return 0;
                }
            }

            public object GetAttributeDataModel(int labelIndex)
            {
                return null;
            }

            public object CheckControlID(int labelIndex)
            {
                return null;
            }

            public int GetMaxDataIndex()
            {
                return 0;
            }

            public int GetIndexAttributeData(int labelIndex)
            {
                return 0;
            }

            public GameObject langID;

            public GameObject labelDataModelArray;

            public GameObject binMsgFile;
        }

        private class MsgEventData : ScriptableObject
        {
            public GameObject endEventId;

            public float tagParameter;
        }
    }
}
