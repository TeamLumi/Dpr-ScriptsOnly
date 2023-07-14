using System;
using SmartPoint.AssetAssistant.Forms;
using SmartPoint.AssetAssistant.UnityExtensions;
using UnityEngine;

namespace SmartPoint.AssetAssistant
{
    public class StartupSettings : SingletonScriptableObject<StartupSettings>
    {
        private static StartupSettings instance;

        public static string GetPlatformName()
        {
            var x = GetInstance();
            string platformName = null;

            if (x != null)
            {
                platformName = x.ToString(); // Assuming the instance can be converted to a string
            }
            else
            {
                platformName = ""; // Default value in case instance is null, adjust as needed
            }

            return platformName;
        }

        public static MessageBoxManifestBase messageBoxManifest
        {
            get
            {
                return null;
            }
        }

        public static bool GetUseSceneBrowser()
        {
            var x = GetInstance();

            if (x == null)
            {
                return true;
            }

            // Assuming instance has a property "UseSceneBrowser" of type bool.
            // This will depend on your specific application and might need to be adjusted.
            return (StartupSettings.instance).UseSceneBrowser;
        }

        public static string GetAssetBundleTargetURI()
        {
            var x = GetInstance();
            string assetBundleTargetURI = null;

            if (x != null)
            {
                assetBundleTargetURI = (StartupSettings.instance).AssetBundleTargetURI;
            }
            else
            {
                assetBundleTargetURI = ""; // Default value in case instance is null, adjust as needed
            }

            return assetBundleTargetURI;
        }

        public static string[] GetAssetBundlesForEditor()
        {
            var x = GetInstance();
            string[] assetBundlesForEditor;

            if (x != null)
            {
                assetBundlesForEditor = (StartupSettings.instance).AssetBundlesForEditor;
            }
            else
            {
                assetBundlesForEditor = new string[0]; // Default value in case instance is null, adjust as needed
            }

            return assetBundlesForEditor;
        }

        public static string[] GetExternalProjectNames()
        {
            var x = GetInstance();
            string[] externalProjectNames;

            if (x != null)
            {
                externalProjectNames = (StartupSettings.instance).ExternalProjectNames;
            }
            else
            {
                externalProjectNames = new string[0]; // Default value in case instance is null, adjust as needed
            }

            return externalProjectNames;
        }

        public static AssetBundleTarget GetAssetBundleTarget()
        {
            var x = GetInstance();
            AssetBundleTarget assetBundleTarget;

            if (x != null)
            {
                assetBundleTarget = (StartupSettings.instance).AssetBundleTarget;
            }
            else
            {
                assetBundleTarget = 0; // Default value in case instance is null
            }

            return assetBundleTarget;
        }

        public static AssetBundleTarget assetBundleTarget
        {
            get
            {
                return AssetBundleTarget.AssetDatabase;
            }
        }

        public static bool GetRunBootSequence()
        {
            var x = GetInstance();
            bool runBootSequence;

            if (x != null)
            {
                runBootSequence = (StartupSettings.instance).RunBootSequence;
            }
            else
            {
                runBootSequence = false; // Default value in case instance is null
            }

            return runBootSequence;
        }

        public static int minimumResolution
        {
            get
            {
                return default(int);
            }
        }

        public static bool GetClearCacheFiles()
        {
            var x = GetInstance();
            bool clearCacheFiles;

            if (x != null)
            {
                clearCacheFiles = (StartupSettings.instance).ClearCacheFiles;
            }
            else
            {
                clearCacheFiles = false; // Default value in case instance is null
            }

            return clearCacheFiles;
        }

        public static bool webhookInEditMode
        {
            get
            {
                var instance = GetInstance();
                return instance.WebhookInEditMode;
            }
        }

        public static string webhookURL
        {
            get
            {
                var instance = GetInstance();
                return instance != null ? instance.WebhookURL : null;
            }
        }

        public static string GetStartupScenePath()
        {
            var x = GetInstance();
            string startupScenePath;

            if (x != null)
            {
                startupScenePath = (StartupSettings.instance).StartupScenePath;
            }
            else
            {
                startupScenePath = string.Empty; // Default value in case instance is null
            }

            return startupScenePath;
        }

        public static PreloadRequest[] GetPreloadRequests()
        {
            var x = GetInstance();
            PreloadRequest[] preloadRequests;

            if (x != null)
            {
                preloadRequests = (StartupSettings.instance).PreloadRequests;
            }
            else
            {
                preloadRequests = null; // Default value in case instance is null
            }

            return preloadRequests;
        }

        public static void GetPreloadMethod(out object preloadMethod)
        {
            if (instance == null)
            {
                // Load or initialize instance
                instance = FindObjectOfType<StartupSettings>();
            }

            if (instance == null)
            {
                // Set output to null if instance is still null after trying to find it
                preloadMethod = null;
                return;
            }

            preloadMethod = instance.PreloadMethod;
        }

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
                var instance = GetInstance();
                return instance != null ? instance.InitializeMethods : null;
            }
        }

        public static SerializedMethod[] GetAssetManagerAfterSetupMethods()
        {
            if (instance == null)
            {
                // Load or initialize instance
                instance = FindObjectOfType<StartupSettings>();
            }

            if (instance == null)
            {
                // Create an empty array if instance is still null after trying to find it
                return new SerializedMethod[0];
            }

            return instance.AssetManagerAfterSetupMethods;
        }

        public static SerializedMethod[] assetManagerAfterSetupMethods
        {
            get
            {
                return null;
            }
        }

        public static SerializedMethod[] GetSceneRestoreOperationMethods()
        {
            if (instance == null)
            {
                // Load or initialize instance
                instance = FindObjectOfType<StartupSettings>();
            }

            if (instance == null)
            {
                // Create an empty array if instance is still null after trying to find it
                return new SerializedMethod[0];
            }

            return instance.SceneRestoreOperationMethods;
        }

        public static SerializedMethod[] GetSceneBeforeActivateOperationMethods()
        {
            if (instance == null)
            {
                // Load or initialize instance
                instance = FindObjectOfType<StartupSettings>();
            }

            if (instance == null)
            {
                // Create an empty array if instance is still null after trying to find it
                return new SerializedMethod[0];
            }

            return instance.SceneBeforeActivateOperationMethods;
        }

        public static SerializedMethod[] sceneBeforeActivateOperationMethods
        {
            get
            {
                return null;
            }
        }

        public static ReferenceObject[] GetPermanentObjects()
        {
            if (instance == null)
            {
                // Load or initialize instance
                instance = FindObjectOfType<StartupSettings>();
            }

            if (instance == null)
            {
                // Return null if instance is still null after trying to find it
                return null;
            }

            return instance.PermanentObjects;
        }

        public static StartupSettings GetInstance()
        {
            if (instance == null)
            {
                instance = Resources.Load<StartupSettings>("StartupSettings");

                if (instance == null)
                {
                    instance = ScriptableObject.CreateInstance<StartupSettings>();
                }
            }

            return instance;
        }

        public static string GetBuildVersion()
        {
            if (instance == null)
            {
                // Load or initialize instance
                instance = FindObjectOfType<StartupSettings>();
            }

            if (instance == null)
            {
                // Return default string if instance is still null after trying to find it
                return string.Empty; // Replace with the correct default value
            }

            return instance.BuildVersion;
        }

        public static string GetCreationTime()
        {
            if (instance == null)
            {
                // Load or initialize instance
                instance = FindObjectOfType<StartupSettings>();
            }

            if (instance == null)
            {
                // Return default string if instance is still null after trying to find it
                return "Uninitialized"; // Replace with the correct default value
            }

            return instance.CreationTime;
        }

        [SerializeField]
        public bool UseSceneBrowser;

        [SerializeField]
        public string WebhookURL;

        [SerializeField]
        public PreloadRequest[] PreloadRequests;

        [SerializeField]
        public SerializedMethod[] InitializeMethods;

        [SerializeField]
        public SerializedMethod[] AssetManagerAfterSetupMethods;

        [SerializeField]
        public SerializedMethod[] SceneRestoreOperationMethods;

        [SerializeField]
        public SerializedMethod[] SceneBeforeActivateOperationMethods;

        [SerializeField]
        public string StartupScenePath;

        [SerializeField]
        public ReferenceObject[] PermanentObjects;

        [SerializeField]
        public bool RunBootSequence;

        [SerializeField]
        public string CreationTime;

        [SerializeField]
        public string BuildVersion;

        public StartupSettings()
        {
            UseSceneBrowser = true;
            WebhookURL = string.Empty;
            PreloadRequests = new PreloadRequest[0];
            InitializeMethods = new SerializedMethod[0];
            AssetManagerAfterSetupMethods = new SerializedMethod[0];
            SceneRestoreOperationMethods = new SerializedMethod[0];
            SceneBeforeActivateOperationMethods = new SerializedMethod[0];
            StartupScenePath = string.Empty;
            PermanentObjects = new ReferenceObject[0];
            RunBootSequence = true;
            CreationTime = string.Empty;
            BuildVersion = string.Empty;
        }
        [SerializeField]
        public string _platformName;

        [SerializeField]
        public MessageBoxManifestBase _messageBoxManifest;

        [SerializeField]
        public AssetBundleTarget AssetBundleTarget;

        [SerializeField]
        public string AssetBundleTargetURI;

        [SerializeField]
        public string[] AssetBundlesForEditor;

        [SerializeField]
        public string[] ExternalProjectNames;

        [SerializeField]
        public bool ClearCacheFiles;

        [SerializeField]
        public bool WebhookInEditMode;

        [SerializeField]
        public int MinimumResolution;

        [SerializeField]
        public SerializedMethod PreloadMethod;
    }
}
