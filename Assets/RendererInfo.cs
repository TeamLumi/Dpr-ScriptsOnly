using System;
using UnityEngine;

public class RendererInfo
{
    private UnityEngine.Renderer _renderer;
    private int _materialCount;

    public Renderer Renderer
    {
        get => _renderer;
        set => _renderer = value;
    }

    public int MaterialCount
    {
        get => _materialCount;
        set => _materialCount = value;
    }

    public RendererInfo(UnityEngine.Renderer renderer)
    {
        _renderer = renderer;
        _materialCount = renderer.sharedMaterials.Length;
    }
}
