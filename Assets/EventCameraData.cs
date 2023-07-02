using System;
using System.Collections.Generic;
using UnityEngine;

public class EventCameraData : ScriptableObject
{
    public float baseTime;
    public float timeScale;
    public int length;
    public List<EventType> type;
    public List<bool> isEnd;
    public List<float> startTime;
    public List<FadeData> fadeData;
    public List<PathData> pathData;
    public List<DofData> dofData;
    public List<PathData2> pathData2;
    public List<RotationData> rotationData;
    public List<ReturnDefault> returnDefault;
    public List<ReturnDefault> returnDefaultRotate;
    public List<FovData> fovData;

    public EventCameraData()
    {
        type = new List<EventType>();
        isEnd = new List<bool>();
        startTime = new List<float>();
        fadeData = new List<FadeData>();
        pathData = new List<PathData>();
        dofData = new List<DofData>();
        pathData2 = new List<PathData2>();
        rotationData = new List<RotationData>();
        returnDefault = new List<ReturnDefault>();
        returnDefaultRotate = new List<ReturnDefault>();
        fovData = new List<FovData>();
    }

    [Serializable]
    public class DofData
    {
        public float workTime;
        public float workTimeScale;
        public List<bool> use;
        public List<DofValType> typeStart;
        public List<DofValType> typeEnd;
        public List<float> valStart;
        public List<float> valEnd;
        public Vector3 targetOffset;

        public DofData()
        {
            use = new List<bool>();
            typeStart = new List<DofValType>();
            typeEnd = new List<DofValType>();
            valStart = new List<float>();
            valEnd = new List<float>();
        }
    }

    public sealed class DofValType
    {
        public int value__;
        public GameObject Input;
        public GameObject Defaul;
        public GameObject Work;
    }

    public sealed class EventType
    {
        public int value__;
        public GameObject Path;
        public GameObject Fade;
        public GameObject EventEnd;
        public GameObject StopEnd;
        public GameObject DofLength;
        public GameObject NewPath;
        public GameObject Rotation;
        public GameObject ReturnDefaultCamera;
        public GameObject ReturnDefaultRotate;
        public GameObject FieldOfView;
    }

    [Serializable]
    public class FadeData
    {
        public FadeType type;
        public Color color;
        public float duration;
    }

    public sealed class FadeType
    {
        public int value__;
        public GameObject In;
        public GameObject Out;
    }

    [Serializable]
    public class FovData
    {
        public int curveIndex;
        public float workTime;
        public float workTimeScale;
        public float field_of_view_start;
        public float field_of_view;
        public bool is_default_start;
        public bool is_default_end;
    }

    [Serializable]
    public class PathData
    {
        public float workTime;
        public float workTimeScale;
        public VectorType vTypeStart;
        public VectorType vTypeEnd;
        public Vector3 startPosition;
        public Vector3 Vectol;
        public Vector3 endPosition;
        public bool isDefaultRotate;
        public Vector3 startRotation;
        public Vector3 endRotation;
    }

    [Serializable]
    public class PathData2
    {
        public int curveIndex;
        public float workTime;
        public float workTimeScale;
        public VectorType vTypeStart;
        public VectorType vTypeEnd;
        public Vector3 Pos1;
        public Vector3 Pos2;
        public Vector3 Pos3;
    }

    [Serializable]
    public class ReturnDefault
    {
        public int curveIndex;
        public float workTime;
        public float workTimeScale;
    }

    [Serializable]
    public class RotationData
    {
        public int curveIndex;
        public float workTime;
        public float workTimeScale;
        public bool isDefaultRotate;
        public Vector3 Angle1;
        public Vector3 Angle2;
    }

    public sealed class VectorType
    {
        public int value__;
        public GameObject Local;
        public GameObject World;
        public GameObject Default;
        public GameObject Before;
    }
}
