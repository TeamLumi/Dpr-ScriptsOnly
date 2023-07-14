using System;
using System.Collections.Generic;
using System.Drawing;
using Dpr;
using Dpr.Battle.View;
using Dpr.Battle.View.Objects;
using Pml.PokePara;
using SmartPoint.Components;
using UnityEngine;
using UnityEngine.Rendering;
using XLSXContent;
using Color = UnityEngine.Color;
using Size = Pml.PokePara.Size;

public sealed class BattlePokemonEntity : BattleObjectEntity
{
    //private AnimationPlayer _animationPlayer;
    private float _scale = 1.0f;
    //private int _animationState = 0x23;
    private RenderingParam _renderingParam;
    //private PokeAnimSound _pokeAnimSound;
    private UnityEngine.Color _fixMultiplierColor;
    private Vector3 _adjustScale;
    private Dictionary<int, int> _renderObjectMasks;
    private float _motionBlendTime = 0.14f;
    //private bool _isPokeAnimSoundEnable = true;
    //private CharaAutomaticBlinkProcess _blinkProcess;
    private long _modelEntityType = 0x3f800000ffffffff;

    public BattleDataTable.SheetPokemonMotionBlendTime PokemonMotionBlendTimeData
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public override string entityType
    {
        get
        {
            return null;
        }
    }

    public Pml.PokePara.Size Size
    {
        get
        {
            return Pml.PokePara.Size.XS;
        }
    }

    public LandingType LandingType
    {
        get
        {
            return LandingType.NONE;
        }
    }

    public BattlePokemonEntity.AnimationState CurrentAnimationState
    {
        get
        {
            return BattlePokemonEntity.AnimationState.WaitA01;
        }
        private set
        {
        }
    }

    public bool PokeAnimSoundEnable
    {
        get => _isPokeAnimSoundEnable;
        set
        {
            _isPokeAnimSoundEnable = value;
            _pokeAnimSound.Enable = value;
        }
    }

    public UnityEngine.Color FixMultiplierColor
    {
        get
        {
            return default(UnityEngine.Color);
        }
        set
        {
        }
    }

    private PokemonVariation PokemonVariation
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public PokemonCustomNodeAnim PokemonCustomNodeAnim
    {
        get
        {
            return null;
        }
        private set
        {
        }
    }

    private PokemonAnime PokemonAnime
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    private PokemonPrefabInfo PokemonPrefabInfo
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    private PatcheelPattern patcheelPattern
    {
        get
        {
            return null;
        }
        set
        {
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

    protected void OnUpdate(float deltaTime)
    {
    }

    protected void OnEarlyLateUpdate(float deltatime)
    {
    }

    private void LateUpdate()
    {
    }

    protected void OnLateUpdate(float deltaTime)
    {
    }

    protected void ProcessSequence(float deltaTime)
    {
    }

    public void Initialize(PokemonInfo.SheetCatalog catalog, bool isContest = false)
    {
    }

    private void CreateShadowCastSystem()
    {
    }

    public SimpleParam GetSimpleParam()
    {
        return default(SimpleParam);
    }

    public void ResetAnimation()
    {
    }

    public AnimationPlayer GetAnimationPlayer()
    {
        return null;
    }

    public void RequestAnimationState(BattlePokemonEntity.AnimationState state, float duration = 0f, float startTime = 0f)
    {
    }

    public void SetAnimationSpeed(float animationSpeed)
    {
    }

    public float GetAnimationSpeed()
    {
        return default(float);
    }

    public void SetBlinkEnabled(bool value)
    {
    }

    public void SetBlinkIntParameter(BattleObjectEntity.CharaAutomaticBlinkProcess.BlinkIntParameter param)
    {
    }

    public PokeAnimSound GetPokeAnimSound()
    {
        return null;
    }

    private void AK_EffectStart00(int value)
    {
    }

    private void AK_EffectStart01(int value)
    {
    }

    private void AK_ButuriStart01(int value)
    {
    }

    private void AK_SEStart01(int value)
    {
    }

    private void AK_SEStart02(int value)
    {
    }

    private void AK_SEStart03(int value)
    {
    }

    private void AK_SEStart04(int value)
    {
    }

    private void AK_PartsMaterial01(int value)
    {
    }

    private void AK_PartsSkel01(int value)
    {
    }

    public void SetRenderActive(bool isActive)
    {
    }

    private void UpdateFixMultiplyColor()
    {
    }

    public BattlePokemonEntity.RenderingParam GetRenderingParam()
    {
        return default(BattlePokemonEntity.RenderingParam);
    }

    public void SetStencilWriteValue(bool f, int value)
    {
    }

    private void AdjustModel()
    {
    }

    public BattleObjectEntity.ModelEntityType GetModelEntityType()
    {
        return BattleObjectEntity.ModelEntityType.Battle;
    }

    public void SetPatcheelPattern(uint rand)
    {
    }

    public BattlePokemonEntity()
    {
        _animationPlayer = new AnimationPlayer();
        _renderingParam = new RenderingParam();
        _pokeAnimSound = new PokeAnimSound();
        _fixMultiplierColor = UnityEngine.Color.white;
        _adjustScale = Vector3.one;
        _renderObjectMasks = new Dictionary<int, int>();
        _blinkProcess = new CharaAutomaticBlinkProcess();
    }

    public const float DEFAULT_MOTION_TRANSITION_TIME = 0f;

    public const float DEFAULT_MOTION_START_TIME = 0f;

    private const float DEFAULT_MOTION_BLEND_TIME = 0.14f;

    [SerializeField]
    private AnimationPlayer _animationPlayer;

    [SerializeField]
    private Size _size;

    //[SerializeField]
    //private float _scale;

    [SerializeField]
    private LandingType _landingType;

    [SerializeField]
    public BattlePokemonEntity.AnimationState _animationState
    {
        get => _animationState;
        set => _animationState = value;
    }

    //[SerializeField]
    //private BattlePokemonEntity.RenderingParam _renderingParam;

    [SerializeField]
    private SkinnedMeshRendererCluster[] _rendererClusters;

    [SerializeField]
    private PokeAnimSound _pokeAnimSound;

    private MaterialPropertyBlock _propertyBlock;

    //private UnityEngine.Color _fixMultiplierColor;

    private SimpleParam _simpleParam;

    //private Vector3 _adjustScale;

    private Transform _origin;

    //private Dictionary<int, int> _renderObjectMasks;

    //private float _motionBlendTime;

    public bool isAnimationWaitAWhenDisable;

    private int waitALoopCount;

    public bool _isPokeAnimSoundEnable;

    public bool isZIBAKOIRU;

    public new class SequenceID : BaseEntity.SequenceID
    {
        public SequenceID()
        {
        }

        public const int Active = 4096;

        protected new const int User = 8192;

        public const int Attack = 12288;

        public const int Animation = 16384;

        public const int ToDown = 20480;

        public const int ToLandState = 24576;

        public const int ToBlend = 28672;

        public const int ToWaitB = 32768;

        public const int ToWaitC = 36864;
    }

    public enum AnimationState
    {
        WaitA01,
        WaitB01,
        LandA01,
        LandB01,
        LandC01,
        Buturi01,
        Buturi02,
        Buturi03,
        Tokusyu01,
        Tokusyu02,
        Tokusyu03,
        BodyBlow,
        Punch,
        Kick,
        Tail,
        Bite,
        Peck,
        Radial,
        Cry,
        Dust,
        Shot,
        Guard,
        TurnNormal,
        TurnSmile,
        Damage,
        Down,
        Roar01,
        F_Walk,
        F_Happy,
        F_Hate,
        F_Eat,
        F_Happy_A,
        F_Happy_C,
        WaitC01,
        Wait04,
        Max
    }

    [Serializable]
    public struct RenderingParam
    {
        public static BattlePokemonEntity.RenderingParam Factory()
        {
            return default(BattlePokemonEntity.RenderingParam);
        }

        public int stencilRef;

        public CompareFunction stencilComp;

        public StencilOp stencilOp;
    }
}
