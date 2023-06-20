using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BattleObjectEntity : BaseEntity
{
    [SerializeField]
    protected GameObject _blinkProcess; // BattleObjectEntity.CharaAutomaticBlinkProcess
    [SerializeField]
    protected Renderer[] _renderers;
    [SerializeField]
    protected Transform[] _locators;
    [SerializeField]
    protected GameObject _modelEntityType; // BattleObjectEntity.ModelEntityType
    protected float _animationSpeed;
    protected GameObject _shadowCastSystem; // BattleShadowCastSystem
    protected Animator _animator;
    protected GameObject[] _rendererInfos; // RendererInfo[]

    public Animator Animator
    {
        get
        {
            return _animator;
        }
    }

    public Renderer[] Renderers
    {
        get
        {
            return _renderers;
        }
    }

    public GameObject ShadowCastSystem // BattleShadowCastSystem
    {
        get
        {
            return _shadowCastSystem;
        }
    }
}
