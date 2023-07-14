using System;
using UnityEngine;

public class AkAudioListener : MonoBehaviour
{
    public static object DefaultListeners
    {
        get
        {
            return null;
        }
    }

    public void StartListeningToEmitter(object emitter)
    {
    }

    public void StopListeningToEmitter(object emitter)
    {
    }

    public void SetIsDefaultListener(bool isDefault)
    {
    }

    private void Awake()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDisable()
    {
    }

    private void Update()
    {
    }

    public bool GetAkGameObjectID()
    {
        return false;
    }

    public void Migrate14()
    {
    }

    public GameObject defaultListeners;

    public ulong akGameObjectID;

    public GameObject EmittersToStartListeningTo;

    public GameObject EmittersToStopListeningTo;

    public bool isDefaultListener;

    public int listenerId;

    public class BaseListenerList
    {
        public object ListenerList
        {
            get
            {
                return null;
            }
        }

        public virtual bool Add(object listener)
        {
            return false;
        }

        public virtual bool Remove(object listener)
        {
            return false;
        }

        public object GetListenerIds()
        {
            return null;
        }

        public GameObject listenerIdList;

        public GameObject listenerList;
    }

    public class DefaultListenerList
    {
        public virtual bool Add(object listener)
        {
            return false;
        }

        public virtual bool Remove(object listener)
        {
            return false;
        }
    }
}
