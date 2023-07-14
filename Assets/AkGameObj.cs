using System;
using UnityEngine;

public class AkGameObj : MonoBehaviour
{

    private void OnDisable()
    {
    }

    public bool IsUsingDefaultListeners
    {
        get
        {
            return false;
        }
    }

    public object ListenerList
    {
        get
        {
            return null;
        }
    }

    internal void AddListener(object listener)
    {
    }

    internal void RemoveListener(object listener)
    {
    }

    public object Register()
    {
        return null;
    }

    private void SetPosition()
    {
    }

    private void Awake()
    {
    }

    private void CheckStaticStatus()
    {
    }

    private void OnEnable()
    {
    }

    private void OnDestroy()
    {
    }

    private void Update()
    {
    }

    //public virtual Vector3 GetPosition()
    //{
        //return null;
    //}

    //public virtual Vector3 GetForward()
    //{
        //return null;
    //}

    //public virtual Vector3 GetUpward()
    //{
        //return null;
    //}

    private void OnTriggerEnter(Collider other)
    {
    }

    private void OnTriggerExit(Collider other)
    {
    }

    public GameObject m_listeners;

    public bool isEnvironmentAware;

    public bool isStaticObject;

    public GameObject m_Collider;

    public GameObject m_envData;

    public GameObject m_posData;

    public GameObject m_positionOffsetData;

    public bool isRegistered;

    public GameObject m_posOffsetData;

    public int AK_NUM_LISTENERS;

    public int listenerMask;
}
