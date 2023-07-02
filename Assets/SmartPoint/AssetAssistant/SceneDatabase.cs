using System;
using System.Collections.Generic;
using UnityEngine;

namespace SmartPoint.AssetAssistant
{
    public class SceneDatabase : SingletonScriptableObject<SceneDatabase>
    {
        public static SceneDatabase Instance { get { return instance; } }
        private Dictionary<string, SceneProperty> sceneProperties;
        private List<SceneProperty> _properties;

        public SceneDatabase()
        {
            sceneProperties = new Dictionary<string, SceneProperty>();
            _properties = new List<SceneProperty>();
        }

        public void OnEnable()
        {
            base.OnEnable();
            InternalUpdate();
        }

        private void InternalUpdate()
        {
            sceneProperties = new Dictionary<string, SceneProperty>();
            foreach (var property in _properties)
            {
                sceneProperties.Add(property.scenePath, property);
            }
        }

        public string GUIDToPath(string guid)
        {
            foreach (var value in sceneProperties.Values)
            {
                if (value.guid == guid)
                {
                    return value.scenePath;
                }
            }
            return string.Empty;
        }

        public SceneProperty GetProperty(string scenePath)
        {
            if (sceneProperties.TryGetValue(scenePath, out SceneProperty sceneProperty))
            {
                return sceneProperty;
            }
            return null;
        }

        public bool Contains(string scenePath)
        {
            return sceneProperties.ContainsKey(scenePath);
        }

        public bool IsExist(string scenePath)
        {
            return sceneProperties.ContainsKey(scenePath);
        }

        public string GetAssetBundleName(string scenePath)
        {
            if (sceneProperties.TryGetValue(scenePath, out SceneProperty sceneProperty))
            {
                return string.IsNullOrEmpty(sceneProperty.assetBundleName) ? string.Empty : sceneProperty.assetBundleName;
            }
            return string.Empty;
        }

        public void AddProperty(string path)
        {
            if (!sceneProperties.ContainsKey(path))
            {
                sceneProperties.Add(path, new SceneProperty(path));
            }
        }

        public Dictionary<string, SceneProperty> GetAllSceneProperty()
        {
            return sceneProperties;
        }

        public class SceneProperty
        {
            public string scenePath;
            public string guid;
            public string assetBundleName;
            public bool dontDiscard;
            public bool leaveHistory;
            public string[] includes;

            public SceneProperty(string path)
            {
                scenePath = path;
                guid = string.Empty;
                assetBundleName = string.Empty;
                dontDiscard = false;
                leaveHistory = true;
                includes = new string[0];
            }

            public string ScenePath { get { return scenePath; } }
            public string Guid { get { return guid; } }
            public string AssetBundleName { get { return assetBundleName; } }
            public bool DontDiscard { get { return dontDiscard; } }
            public bool LeaveHistory { get { return leaveHistory; } }
            public string[] Includes { get { return includes; } }
        }
    }
}
