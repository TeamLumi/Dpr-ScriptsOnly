using System;
using Dpr.Battle.View;
using Dpr.Battle.View.Systems;
using Dpr.Trainer;
using UnityEngine;

public abstract class BattleObjectEntity : BaseEntity
{
    public Animator Animator
    {
        get
        {
            return null;
        }
    }

    public Renderer[] Renderers
    {
        get
        {
            return null;
        }
    }

    public BattleShadowCastSystem ShadowCastSystem
    {
        get
        {
            return null;
        }
    }

    protected void Awake()
    {
    }

    protected void OnDestroy()
    {
    }

    protected void OnEnable()
    {
    }

    protected void OnDisable()
    {
    }

    protected virtual void OnEarlyLateUpdate(float deltatime)
    {
    }

    protected virtual void OnPostLateUpdate(float deltaTime)
    {
    }

    public Transform GetJoint(JointName jointName)
    {
        return null;
    }

    public Transform GetJointByName(string name)
    {
        return null;
    }

    public BattleObjectEntity.CharaAutomaticBlinkProcess GetAutomaticBlinkProcess()
    {
        return null;
    }

    protected void InitializeRendererInfos()
    {
    }

    protected BattleObjectEntity()
    {
    }

    [SerializeField]
    protected BattleObjectEntity.CharaAutomaticBlinkProcess _blinkProcess;

    [SerializeField]
    protected Renderer[] _renderers;

    [SerializeField]
    protected Transform[] _locators;

    [SerializeField]
    protected BattleObjectEntity.ModelEntityType _modelEntityType;

    protected float _animationSpeed;

    protected BattleShadowCastSystem _shadowCastSystem;

    protected Animator _animator;

    protected RendererInfo[] _rendererInfos;

    public enum ModelEntityType
    {
        Unknown = -1,
        Battle,
        Contest
    }

    [Serializable]
    public class CharaAutomaticBlinkProcess
    {
        public bool IsConstantBlink
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        public void CreateBlinkProcess(BattleObjectEntity entity)
        {
        }

        public void SetConstantBlink(bool isEnable)
        {
        }

        public void SetBlinkEnabled(bool value)
        {
        }

        public bool IsBlinkEnabled()
        {
            return default(bool);
        }

        public bool IsBlinking()
        {
            return default(bool);
        }

        public void SetBlinkTriggerParam(BattleObjectEntity.CharaAutomaticBlinkProcess.BlinkIntParameter param)
        {
        }

        private void SetBlinkState(BattleObjectEntity.CharaAutomaticBlinkProcess.EyeType type)
        {
        }

        public bool IsDefaultEyeTypeAnimState()
        {
            return default(bool);
        }

        public void OnUpdate(float deltaTime)
        {
        }

        private void OnUpdateBlink(float deltaTime)
        {
        }

        private bool UpdateBlink(float deltaTime)
        {
            return default(bool);
        }

        private void StartBlink()
        {
        }

        private void DoSettingOnEndBlink()
        {
        }

        private void ChangeBlinkPhase(BattleObjectEntity.CharaAutomaticBlinkProcess.BlinkPhase phase)
        {
        }

        private void ResetBlinkPhace()
        {
        }

        private BattleObjectEntity.CharaAutomaticBlinkProcess.BlinkPhase DecideNextBlinkPhase()
        {
            return BattleObjectEntity.CharaAutomaticBlinkProcess.BlinkPhase.NONE;
        }

        private bool CanFirstBlinkStart()
        {
            return default(bool);
        }

        private bool CanSecondBlinkStart()
        {
            return default(bool);
        }

        public CharaAutomaticBlinkProcess()
        {
        }

        public const BattleObjectEntity.CharaAutomaticBlinkProcess.EyeType EYE_TYPE_NEUTRAL = BattleObjectEntity.CharaAutomaticBlinkProcess.EyeType.Normal;

        public const float BLINKING_TIME_MAX = 2f;

        private static readonly BattleObjectEntity.CharaAutomaticBlinkProcess.EyeType[] EYE_BLINK_TABLE;

        [SerializeField]
        private BattleObjectEntity.CharaAutomaticBlinkProcess.BlinkType _blinkType;

        [SerializeField]
        private bool _isBlinkEnabled;

        [SerializeField]
        private bool[] _eye01;

        [SerializeField]
        private BattleObjectEntity.CharaAutomaticBlinkProcess.BlinkValue[] _blinkValues;

        [SerializeField]
        private BattleObjectEntity.CharaAutomaticBlinkProcess.EyeType _currentEyeType;

        private int _currentState;

        public TrainerAge trainerAge;

        public int blinkIntervalTimeMin;

        public int blinkIntervalTimeMax;

        public int blinkTwiceRate;

        private bool _isConstantBlink;

        private BattleObjectEntity.CharaAutomaticBlinkProcess.BlinkPhase _prevExecuteBlinkPhase;

        private BattleObjectEntity.CharaAutomaticBlinkProcess.BlinkPhase _blinkPhase;

        private BattleObjectEntity.CharaAutomaticBlinkProcess.BlinkIntParameter _prevParameter;

        private BattleObjectEntity.CharaAutomaticBlinkProcess.BlinkIntParameter _requestParameter;

        private BattleObjectEntity _entity;

        private float _blinkIntervalTime;

        private float _blinkingTime;

        private int _blinkStep;

        public enum BlinkType
        {
            Unknown = -1,
            Pokemon,
            Trainer
        }

        public enum EyeType
        {
            Normal,
            HalfClosed,
            Closed,
            Damage,
            Angry,
            Happy,
            Sad,
            Reserve
        }

        public enum BlinkIntParameter
        {
            Default,
            Sleep = 3
        }

        public enum CurveValueType
        {
            LocalRotation,
            LocalPosition,
            LocalScale
        }

        public enum BlinkPhase
        {
            NONE,
            ONCE,
            TWICE
        }

        [Serializable]
        public class BlinkValue
        {
            public Transform TargetNode
            {
                get
                {
                    return null;
                }
                set
                {
                }
            }

            public BattleObjectEntity.CharaAutomaticBlinkProcess.CurveValueType CurveValueType
            {
                get
                {
                    return BattleObjectEntity.CharaAutomaticBlinkProcess.CurveValueType.LocalRotation;
                }
                set
                {
                }
            }

            public Vector4[] Values
            {
                get
                {
                    return null;
                }
                set
                {
                }
            }

            public BlinkValue()
            {
            }

            [SerializeField]
            private Transform _targetNode;

            [SerializeField]
            private BattleObjectEntity.CharaAutomaticBlinkProcess.CurveValueType _curveValueType;

            [SerializeField]
            private Vector4[] _values;
        }
    }


    public string name;
}
