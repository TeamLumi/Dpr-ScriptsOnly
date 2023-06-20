using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EventCamera
{
    private FieldCamera camera;
    private GameObject cameraData; // EventCameraData
    private Vector3 workPosition;
    private Vector3 workRotate;
    private Vector3 retrunDefaultPosition;
    private Vector3 returnDefaultRotate;
	private GameObject _dof; // DepthOfField
    private float[] default_dof;
    private float[] work_dof;
    private Vector3 default_dof_offset;
    private Vector3 before_dof_offset;
    private Vector3 work_dof_offset;
    private GameObject _cameraTbl; // EventCameraTable
    private float workFov;
    private float beforeFov;
    private float defaultFov;

    public Vector3 defaultPosition
    {
        get
        {
            return Vector3.one;
        }
        set
        {

        }
    }

    public Vector3 defaultRotate
    {
        get
        {
            return Vector3.one;
        }
        set
        {

        }
    }

    public Vector3 beforePosition
    {
        get
        {
            return Vector3.one;
        }
        set
        {

        }
    }

    public Vector3 beforeRotate
    {
        get
        {
            return Vector3.one;
        }
        set
        {

        }
    }

    public bool IsEnd
    {
        get
        {
            return true;
        }
        set
        {

        }
    }

    public void SetCameraData(EventCameraTable tbl, int index)
    {

    }
}
