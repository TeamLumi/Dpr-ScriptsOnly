using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using static SmartPoint.AssetAssistant.SceneDatabase;
using UnityEngine.SceneManagement;

namespace SmartPoint.AssetAssistant
{
    public class SceneEntity
    {
        public SceneProperty Property { get; set; }
        public GameObject Cluster { get; set; }
        public List<SceneEntity> Includes { get; set; }
        public bool IsRequested { get; set; }
        public bool IsLoaded { get; set; }
        private Dictionary<MonoBehaviour, Queue<Operation>> ActivateOperations { get; set; }
        public bool CanDeactivate() { return true; }

        public bool CanActivate()
        {
            if (!this.IsLoaded)
            {
                return false;
            }

            if (this.ActivateOperations.Count > 0)
            {
                bool anyOperationInProgress = false;

                foreach (var operationQueue in this.ActivateOperations.Values)
                {
                    if (operationQueue.Count > 0)
                    {
                        var operation = operationQueue.Peek();

                        if (operation.IsFinished())
                        {
                            operationQueue.Dequeue();
                        }

                        anyOperationInProgress |= operationQueue.Count > 0;
                    }
                }

                if (!anyOperationInProgress)
                {
                    this.ActivateOperations.Clear();
                }

                return !anyOperationInProgress;
            }

            return true;
        }

        public SceneEntity(Scene scene)
        {
            this.Includes = new List<SceneEntity>();
            this.ActivateOperations = new Dictionary<MonoBehaviour, Queue<Operation>>();
            this.Property = new SceneProperty(scene.path);
        }

        public SceneEntity(string sceneName)
        {
            this.Includes = new List<SceneEntity>();
            this.ActivateOperations = new Dictionary<MonoBehaviour, Queue<Operation>>();
            this.Property = SceneDatabase.Instance.GetProperty(sceneName); // Changed GetSceneProperty to GetProperty
        }

        public string Path
        {
            get { return Property.ScenePath; } // Changed _property to Property
        }

        public class _Property
        {
            public string ScenePath { get; set; }
            // Other properties...
        }

        public GameObject cluster
        {
            get
            {
                return null;
            }
        }

        public object includes
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public bool isRequested
        {
            get
            {
                return false;
            }
            set
            {
            }
        }

        public Transform ClusterRootTransform
        {
            get
            {
                return this.Cluster != null ? this.Cluster.transform : null;
            }
        }

        public bool isLoaded
        {
            get { return _isLoaded; }
            set
            {
                if (_isLoaded != value)
                {
                    _isLoaded = value;
                    if (_isLoaded)
                    {
                        // Load scene
                    }
                    else
                    {
                        // Unload scene
                    }
                }
            }
        }

        public bool IsActivatable
        {
            get
            {
                foreach (var include in this.Includes)
                {
                    if (!include.CanActivate())
                    {
                        return false;
                    }
                }

                return this.CanActivate();
            }
        }

        public MonoBehaviour[] FindScripts()
        {
            List<MonoBehaviour> scripts = new List<MonoBehaviour>();

            foreach (var include in this.Includes)
            {
                GameObject[] rootGameObjects = include.GetRootGameObjects();
                foreach (var rootGameObject in rootGameObjects)
                {
                    scripts.AddRange(rootGameObject.GetComponentsInChildren<MonoBehaviour>());
                }
            }

            return scripts.ToArray();
        }

        public GameObject[] GetRootGameObjects()
        {
            Scene scene = SceneManager.GetSceneByPath(this.Property.ScenePath);
            if (scene.IsValid() && scene.isLoaded)
            {
                return scene.GetRootGameObjects();
            }
            else
            {
                return new GameObject[0];
            }
        }

        public void Suspend()
        {
            if (_suspendObject == null)
            {
                // Suspend operations
            }
        }

        public void Resume()
        {
            if (_suspendObject != null)
            {
                // Resume operations
            }
        }

        public GameObject _property;

        public GameObject _scene;

        public bool _isRequested;

        public bool _isLoaded;

        public GameObject _suspendObject;

        public GameObject _includes;

        public GameObject _activateOperations;

        private class Operation : ScriptableObject
        {
            public GameObject behaviour;

            public MethodInfo method;

            public GameObject coroutine;
            public bool IsFinished()
            {
                return false;
            }
        }
    }
}
