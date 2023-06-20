using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BattleCharacterEntity : BattleObjectEntity
{
    private const float LOSE_LOOP_START_TIME = 2.0f;

    [SerializeField]
    protected GameObject _animationPlayer; // BattleAnimationPlayer
    [SerializeField]
    protected GameObject _colorVariation; // ColorVariation
    [SerializeField]
    protected float _motionBlendTime;
    protected bool _isEnableAnimationPlayer;
    private float _speakStartTime;

    public override string entityType
    {
        get
        {
            return "";
        }
    }

    public GameObject TrainerSimpleParam // TrainerSimpleParam
    {
        get
        {
            return null;
        }
        set
        {

        }
    }
}
