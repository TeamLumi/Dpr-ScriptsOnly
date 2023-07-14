using System;
using UnityEngine;

public class PokemonVariation : MonoBehaviour
{
    public PokemonVariation.PokeType Type
    {
        get
        {
            return PokemonVariation.PokeType.NORMAL;
        }
        set
        {
        }
    }

    public float ScaleVariation
    {
        get
        {
            return default(float);
        }
    }

    private void Start()
    {
    }

    private void Update()
    {
    }

    private void UpdateVariation()
    {
    }

    public void ChangeVariation(string newVri)
    {
    }

    public void ChangePrevVariation()
    {
    }

    public void ChangeNextVariation()
    {
    }

    public void ChangeType(PokemonVariation.PokeType type)
    {
    }

    public PokemonVariation()
    {
    }

    [SerializeField]
    private PokemonVariation.PokeType pokeType;

    public string[] variations;

    public string variation;

    public PokemonVariation.VisibilityParam[] mVisibilitys;

    public PokemonVariation.RendererMaterial[] rendererMaterials;

    [SerializeField]
    private Material[] mBaseMaterials;

    public PokemonVariation.MaterialParam[] mMaterialParams;

    public float[] mVariationScale;

    public bool debugKey;

    public enum PokeType
    {
        NORMAL,
        SHINYCOLOR,
        TEST
    }

    [Serializable]
    public class VisibilityParam
    {
        public VisibilityParam()
        {
        }

        public GameObject[] boneVisibilitys;

        public string variation;
    }

    [Serializable]
    public class MaterialArray
    {
        public MaterialArray(int num)
        {
        }

        public Material[] materials;
    }

    [Serializable]
    public class MaterialVariation
    {
        public Material[] GetMaterials(PokemonVariation.PokeType pt)
        {
            return null;
        }

        public MaterialVariation()
        {
        }

        public PokemonVariation.MaterialArray[] materialArrays;

        public Material[] materials_default;

        public Material[] materials_rare;
    }

    [Serializable]
    public class MaterialParam
    {
        public MaterialParam()
        {
        }

        public MaterialParam(PokemonVariation.MaterialParam source)
        {
        }

        public string variation;

        public PokemonVariation.MaterialVariation materialVariation;
    }

    [Serializable]
    public class RendererMaterial
    {
        public RendererMaterial()
        {
        }

        public Renderer renderer;

        public Material[] materials;

        public int[] materialIndexs;
    }
}
