using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FieldCamera : MonoBehaviour
{
    private Transform _target;
    private Camera _camera;
    [SerializeField]
    private float _pitch;
    [SerializeField]
    private float _fov;
    [SerializeField]
    private float _targetRange;
    [SerializeField]
    private float _defocusStart;
    [SerializeField]
    private float _defocusEnd;
    private float _start_pitch;
    private float _start_fov;
    private float _start_targetRange;
    private float _start_defocusStart;
    private float _start_defocusEnd;
    private float _end_pitch;
    private float _end_fov;
    private float _end_targetRange;
    private float _end_defocusStart;
    private float _end_defocusEnd;
    private float _pitch_time;
    private float _pitch_work_wait;
    private Vector3 oldPosition;
    [SerializeField]
    private float _cameraLerpRate;
    public Camera EncountEffectCamera;
    public bool IsUpdateStop;
    private bool isPanCamera;
    private GameObject _panCamera; // FieldPanCamera
    private GameObject DarkWindow;
    private float _scriptFardepth;
    private float _scriptFardepthTime;
    private float _scriptFardepthTimeVectol;
    private float _fovOffset;
    private float _fovOffsetStart;
    private float _fovOffsetEnd;
    private float _fovOffsetTime;
    private float _fovOffsetTimeScale;
    private Transform returnDofTransform;
    private GameObject tempDofTransform;
    private bool IsStopDofTarget;

    public Vector3 offset
    {
        get
        {
            return Vector3.one;
        }
        set
        {

        }
    }

    public Vector3 offsetAngle
    {
        get
        {
            return Vector3.one;
        }
        set
        {

        }
    }

    public Transform Target
    {
        get
        {
            return null;
        }
        set
        {

        }
    }

    public EventCamera EventCamera
    {
        get
        {
            return null;
        }
        set
        {

        }
    }

    public GameObject FieldCameraShake // FieldCameraShake
    {
        get
        {
            return null;
        }
        set
        {

        }
    }

    public GameObject TargetRangeOffset // FieldFloatMove
    {
        get
        {
            return null;
        }
        set
        {

        }
    }

    public float Fov
    {
        get
        {
            return 0.0f;
        }
        set
        {

        }
    }

    public GameObject AfterImage // AfterImage
    {
        get
        {
            return null;
        }
        set
        {

        }
    }

    public float TargetRange
    {
        get
        {
            return 0.0f;
        }
        set
        {

        }
    }
}
