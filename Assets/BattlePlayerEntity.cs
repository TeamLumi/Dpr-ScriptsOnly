using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattlePlayerEntity : BattleCharacterEntity
{
    [SerializeField]
    private Renderer _watchRenderer;
    [SerializeField]
    private Renderer[] _hatRenderers;
    [SerializeField]
    private Renderer[] _shoesRenderers;
    public int HatVariationParam;
    public int ShoesVariationParam;
    private bool isCaputureDemo;

    public GameObject ColorVariation // ColorVariation
    {
        get
        {
            return null;
        }
    }

    public override string entityType
    {
        get
        {
            return "";
        }
    }

    public bool watchVisibility
    {
        get
        {
            return true;
        }
        set
        {

        }
    }

    public int HatVariation
    {
        get
        {
            return 0;
        }
        set
        {

        }
    }

    public int ShoesVariation
    {
        get
        {
            return 0;
        }
        set
        {

        }
    }
}
