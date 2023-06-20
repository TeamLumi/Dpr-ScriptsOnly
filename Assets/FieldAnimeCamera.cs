using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldAnimeCamera : MonoBehaviour
{
    public static FieldAnimeCamera instance;

    private Camera _camera;
    private Animator _animator;
    private bool _isPlay;
    private Transform transform;
    private string assetbundleName;

    public void Play(string statename)
    {
        _animator.Play(statename);
        _isPlay = true;
    }
}
