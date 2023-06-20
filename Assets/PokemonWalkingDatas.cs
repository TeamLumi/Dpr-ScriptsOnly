using System;
using UnityEngine;

[Serializable]
public class PokemonWalkingDatas : ScriptableObject
{
    public Parameters currentData
    {
        get
        {
            return null;
        }
    }

    public Preset GetPreset(int size)
    {
        return null;
    }

    public PokemonWalkingDatas()
    {
    }

    [SerializeField]
    public Preset presetS;

    [SerializeField]
    public Preset presetM;

    [SerializeField]
    public Preset presetL;

    [SerializeField]
    public Preset presetLL;

    [SerializeField]
    public Parameters[] list;

    [NonSerialized]
    public int currentIndex;

    [NonSerialized]
    public bool debugBoundsEnable;

    [Serializable]
    public class Preset
    {
        public Preset()
        {
        }

        public float scale;
        public float radius;
        public float falloffNear;
        public float falloffFar;
        public float walkSpeed;
        public float runSpeed;
        public float walkThreshold;
        public float runThreshold;
        public float eraseThreshold;
    }

    [Serializable]
    public class Parameters
    {
        public Parameters()
        {
        }

        public int index;
        public int size;
        public float scale;
        public float radius;
        public float falloffNear;
        public float falloffFar;
        public float walkSpeed;
        public float runSpeed;
        public float walkThreshold;
        public float runThreshold;
        public float eraseThreshold;
        public bool footEffectEnable;
    }
}
