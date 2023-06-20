using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[DisallowMultipleComponent]
public class BaseEntity : MonoBehaviour
{
    [SerializeField]
    private string _enityName;
    private bool _alreadyRegistered;
    public float yawAngle;
    public Vector3 worldPosition;
    private float savedYawAngle;
    private Vector3 savedPosition;
    private Transform _cacheTransform;

    public virtual string entityType
    {
        get
        {
            return "";
        }
    }

    public Vector3 beforePosition
    {
        get
        {
            return Vector3.one;
        }
        set
        {

        }
    }

    public int currentSequence
    {
        get
        {
            return 0;
        }
        set
        {

        }
    }

    public int nextSequence
    {
        get
        {
            return 0;
        }
        set
        {

        }
    }

    public float sequenceTime
    {
        get
        {
            return 0.0f;
        }
        set
        {

        }
    }

    public string entityEname
    {
        get
        {
            return "";
        }
        set
        {

        }
    }

    public BaseEntity target
    {
        get
        {
            return null;
        }
        set
        {

        }
    }

    public Transform transform
    {
        get
        {
            return null;
        }
    }
}
