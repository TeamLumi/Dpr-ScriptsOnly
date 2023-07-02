using SmartPoint.AssetAssistant;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.SmartPoint.AssetAssistant
{
    internal class SceneBrowser
    {
        /*
        public bool IsFinishedPrepareForSceneSwitching()
        {
            if (ChangeSceneCoroutines == null)
            {
                ChangeSceneCoroutines = new List<Coroutine>();

                if (PrepareForSceneSwitching != null)
                {
                    foreach (var handler in PrepareForSceneSwitching.GetInvocationList())
                    {
                        var coroutine = Sequencer.Start((IEnumerator)handler.DynamicInvoke(CurrentScene, TargetScene));
                        ChangeSceneCoroutines.Add(coroutine);
                    }
                }

                var scripts = TargetScene.FindScripts();
                foreach (var script in scripts)
                {
                    var method = GetSceneBeforeActivateOperationMethod(script.GetType());
                    if (method != null)
                    {
                        var coroutine = Sequencer.Start((IEnumerator)method.Invoke(script, new object[] { TargetScene.ClusterRootTransform }));
                        ChangeSceneCoroutines.Add(coroutine);
                    }
                }
            }
            else
            {
                var newCoroutines = new List<Coroutine>();
                foreach (var coroutine in ChangeSceneCoroutines)
                {
                    if (!Sequencer.IsFinished(coroutine))
                    {
                        newCoroutines.Add(coroutine);
                    }
                }

                ChangeSceneCoroutines = newCoroutines.Count > 0 ? newCoroutines : null;
            }

            return ChangeSceneCoroutines == null;
        }
        */
    }
}
