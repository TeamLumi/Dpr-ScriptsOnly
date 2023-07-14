using System;
using System.Runtime.InteropServices;
using SmartPoint.AssetAssistant;
using UnityEngine.Events;

namespace Dpr.Message
{
    public class MessageManager : SingletonMonoBehaviour<MessageManager>
    {
        public bool IsInitialize
        {
            get
            {
                return default(bool);
            }
        }

        public bool IsLoading
        {
            get
            {
                return default(bool);
            }
        }

        public void Initialize(MessageEnumData.MsgLangId languageId)
        {
        }

        private bool CheckInitialized()
        {
            return default(bool);
        }

        private void Destroy()
        {
        }

        public MessageEnumData.MsgLangId UserLanguageID
        {
            get
            {
                return (MessageEnumData.MsgLangId)0;
            }
        }

        public bool IsKanji
        {
            get
            {
                return default(bool);
            }
        }

        public void SetJPNKanjiFlag(bool flag)
        {
        }

        public string[] Varitnas
        {
            get
            {
                return null;
            }
        }

        /*
        public MessageMsgFile GetMsgFile(string fileName)
        {
            return null;
        }

        public MessageMsgFile GetMsgFile(string fileName, MessageEnumData.MsgLangId languageId)
        {
            return null;
        }
        */

        private void UnloadMSBTAssetBundle()
        {
        }

        private void UnloadCommonMSBTAssetBundle()
        {
        }

        private void RegistLoadingLanguageMsbt()
        {
        }

        private void RegisitLoadingCommonMsbt()
        {
        }

        private void RegistLoadingMsbtFile(MessageEnumData.MsgLangId languageId)
        {
        }

        public void ReloadAllMsbtFile(MessageEnumData.MsgLangId newLanguageId, Action onCompleteLoad)
        {
        }

        //public LoadMsbtOperation AsyncReloadAllMsbtFileAsync(MessageEnumData.MsgLangId newLanguageId)
        //{
            //return null;
        //}

        private void RequestLoadMessageAssetbundle([Optional] Action onFinishedLoadRequest)
        {
        }

        private void OnFinishReloadMsbt()
        {
        }

        //public TagWordBuffer TagWordBuffer
        //{
            //get
            //{
                //return null;
            //}
        //}

        public void ClearTagWordParams()
        {
        }

        //public void SetTagWordParam(int index, AWordParamBase wordParam)
        //{
        //}

        public bool IsSetWordParam(int index)
        {
            return default(bool);
        }

        public string GetRivalName()
        {
            return null;
        }

        public string GetRivalMotherName()
        {
            return null;
        }

        public string GetNameMessage(string fileName, int labelIndex)
        {
            return null;
        }

        public string GetNameMessage(string fileName, int labelIndex, MessageEnumData.MsgLangId languageId)
        {
            return null;
        }

        public string GetNameMessage(string fileName, string label)
        {
            return null;
        }

        public string GetNameMessage(string fileName, string label, MessageEnumData.MsgLangId languageId)
        {
            return null;
        }

        //public MessageGlossaryParseDataModel GetNameMessageDataModel(string fileName, int labelIndex)
        //{
        //return null;
        //}

        /*
        public MessageGlossaryParseDataModel GetNameMessageDataModel(string fileName, int labelIndex, MessageEnumData.MsgLangId languageId)
        {
            return null;
        }

        public MessageGlossaryParseDataModel GetNameMessageDataModel(string fileName, string label)
        {
            return null;
        }

        public MessageGlossaryParseDataModel GetNameMessageDataModel(string fileName, string label, MessageEnumData.MsgLangId languageId)
        {
            return null;
        }

        public AttributeInfo GetAttributeInfo(string fileName, string label, MessageEnumData.MsgLangId languageId)
        {
            return null;
        }
        */
        public string GetSimpleMessage(string fileName, string label)
        {
            return null;
        }

        public string GetSimpleMessage(string fileName, string label, MessageEnumData.MsgLangId languageId)
        {
            return null;
        }

        public string GetSimpleMessage(string fileName, int labelIndex)
        {
            return null;
        }

        public string GetSimpleMessage(string fileName, int labelIndex, MessageEnumData.MsgLangId languageId)
        {
            return null;
        }

        /*
        private void OnCompleteLoadAssetBundle(LoadAssetBundleTask loadTask)
        {
        }

        private void OnCompleteLoadMsbtFile(LoadMsbtFileTask loadTask)
        {
        }

        private void OnChangedConfig(ConfigID configID, int value)
        {
        }

        public static WordDataModel GetWordDataFromPool()
        {
            return null;
        }
        */

        public bool InsertSDCard
        {
            get
            {
                return default(bool);
            }
        }

        public MessageManager()
        {
        }

        public static UnityAction<bool> onChangeKanjiMode;

        //private MsgDataFileLoader msbtLoader;

        //private MessageDataModel dataModel;

        //private TagWordBuffer tagWordBuffer;

        //private MessageWordDataPool wordDataPool;

    	public Action onCompleteLoad;

        public Action onFinishedLoadRequest;
    }
}
