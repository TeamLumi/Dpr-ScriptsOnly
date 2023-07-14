using System;
using System.Numerics;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using Vector3 = UnityEngine.Vector3;

public class BaseEntity : MonoBehaviour
{
    public virtual string entityType
    {
        get
        {
            return null;
        }
    }

    public virtual AnimationPlayer GetAnimationPlayer()
    {
        return null;
    }

    public Vector3 beforePosition
    {
        get
        {
            return default(Vector3);
        }
        private set
        {
        }
    }

    public void Register()
    {
    }

    public void Unregister()
    {
    }

    public int currentSequence
    {
        get
        {
            return default(int);
        }
        private set
        {
        }
    }

    public int nextSequence
    {
        get
        {
            return default(int);
        }
        set
        {
        }
    }

    public float sequenceTime
    {
        get
        {
            return default(float);
        }
        private set
        {
        }
    }

    public string entityEname
    {
        get
        {
            return null;
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
        private set
        {
        }
    }

    public new Transform transform
    {
        get
        {
            return null;
        }
    }

    protected virtual void Awake()
    {
    }

    protected virtual void OnEnable()
    {
    }

    protected virtual void OnDisable()
    {
    }

    protected virtual void OnDestroy()
    {
    }

    private void OnEarlyUpdate(float deltaTime)
    {
    }

    protected virtual void OnUpdate(float deltaTime)
    {
    }

    protected virtual void OnLateUpdate(float deltaTime)
    {
    }

    private void OnPostLateUpdate(float deltaTime)
    {
    }

    protected virtual bool SwitchToNext()
    {
        return default(bool);
    }

    protected virtual void ProcessSequence(float deltaTime)
    {
    }

    public void SetPositionDirect(Vector3 pos)
    {
    }

    public void SetYawAngleDirect(float angle)
    {
    }

    public BaseEntity()
    {
    }

    [SerializeField]
    private string _enityName;

    private bool _alreadyRegistered;

    [NonSerialized]
    public float yawAngle;

    [NonSerialized]
    public Vector3 worldPosition;

    private float savedYawAngle;

    private Vector3 savedPosition;

    private Transform _cacheTransform;

    public class SequenceID
    {
        public SequenceID()
        {
        }

        public const int Initialize = 0;

        protected const int User = 4096;
    }
}
