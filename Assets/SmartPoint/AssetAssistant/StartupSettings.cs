using System;
using SmartPoint.AssetAssistant.Forms;
using SmartPoint.AssetAssistant.UnityExtensions;
using UnityEngine;

namespace SmartPoint.AssetAssistant
{
    public class StartupSettings : SingletonScriptableObject<StartupSettings>
    {
        public static string platformName
        {
            get
            {
                return null;
            }
        }

        public static MessageBoxManifestBase messageBoxManifest
        {
            get
            {
                return null;
            }
        }

        public static bool useSceneBrowser
        {
            get
            {
                return default(bool);
            }
        }

        public static string assetBundleTargetURI
        {
            get
            {
                return null;
            }
        }

        public static string[] assetBundlesForEditor
        {
            get
            {
                return null;
            }
        }

        public static string[] externalProjectNames
        {
            get
            {
                return null;
            }
        }

        public static AssetBundleTarget assetBundleTarget
        {
            get
            {
                return AssetBundleTarget.AssetDatabase;
            }
        }

        public static bool runBootSequence
        {
            get
            {
                return default(bool);
            }
        }

        public static int minimumResolution
        {
            get
            {
                return default(int);
            }
        }

        public static bool clearCacheFiles
        {
            get
            {
                return default(bool);
            }
        }

        public static bool webhookInEditMode
        {
            get
            {
                return default(bool);
            }
        }

        public static string webhookURL
        {
            get
            {
                return null;
            }
        }

        public static string startupScenePath
        {
            get
            {
                return null;
            }
        }

        //public static PreloadRequest[] preloadRequests
        //{
            //get
            //{
                //return null;
            //}
        //}

        public static SerializedMethod preloadMethod
        {
            get
            {
                return default(SerializedMethod);
            }
        }

        public static SerializedMethod[] initializeMethods
        {
            get
            {
                return null;
            }
        }

        public static SerializedMethod[] assetManagerAfterSetupMethods
        {
            get
            {
                return null;
            }
        }

        public static SerializedMethod[] sceneRestoreOperationMethods
        {
            get
            {
                return null;
            }
        }

        public static SerializedMethod[] sceneBeforeActivateOperationMethods
        {
            get
            {
                return null;
            }
        }

        public static ReferenceObject[] permanentObjects
        {
            get
            {
                return null;
            }
        }

        public static string buildVersion
        {
            get
            {
                return null;
            }
        }

        public static string creationTime
        {
            get
            {
                return null;
            }
        }

        public StartupSettings()
        {
        }

        [SerializeField]
        private string _platformName;

        [SerializeField]
        private bool _useSceneBrowser;

        [SerializeField]
        private MessageBoxManifestBase _messageBoxManifest;

        [SerializeField]
        private AssetBundleTarget _assetBundleTarget;

        [SerializeField]
        private string _assetBundleTargetURI;

        [SerializeField]
        private string[] _assetBundlesForEditor;

        [SerializeField]
        private string[] _externalProjectNames;

        [SerializeField]
        private bool _clearCacheFiles;

        [SerializeField]
        private bool _webhookInEditMode;

        [SerializeField]
        private string _webhookURL;

        [SerializeField]
        private int _minimumResolution;

        //[SerializeField]
        //private PreloadRequest[] _preloadRequests;

        [SerializeField]
        private SerializedMethod _preloadMethod;

        [SerializeField]
        private SerializedMethod[] _initializeMethods;

        [SerializeField]
        private SerializedMethod[] _assetManagerAfterSetupMethods;

        [SerializeField]
        private SerializedMethod[] _sceneRestoreOperationMethods;

        [SerializeField]
        private SerializedMethod[] _sceneBeforeActivateOperationMethods;

        [SerializeField]
        private string _startupScenePath;

        [SerializeField]
        private ReferenceObject[] _permanentObjects;

        [SerializeField]
        private bool _runBootSequence;

        [SerializeField]
        private string _creationTime;

        [SerializeField]
        private string _buildVersion;
    }
}
