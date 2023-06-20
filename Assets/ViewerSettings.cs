using System;
using UnityEngine;

[Serializable]
public class ViewerSettings
{
    public float _cameraFov;

    public float _focalLength;

    public float _farDepth;

    public float _blurry;

    public Color _clearColor;

    public bool _autoRotate;

    public bool _effectEnable;

    public bool _saveField;

    public bool _appendOpenMode;

    public string _fieldAssetBundleName;

    public int _timeZone;

    public bool _hideBoundingBox;

    public bool _autoFit;

    public bool _sequentialShooting;

    public bool _avatarTakeover;

    public int _trackColorVariation;

    public bool _trackShadowAdjust;

    public float _sensorScale;

    public GameObject _camera;

    public GameObject _dof;

    public string _lastSelectionName;

    //protected override string key => "";

    public static Camera camera
    {
        set
        {
        }
    }

    public static bool fieldOfView
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static Transform cameraTarget
    {
        get
        {
            return null;
        }
        set
        {
        }
    }

    public static bool farDepth
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool sequentialShooting
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool avatarTakeover
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static int trackColorVariation
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static bool trackShadowAdjust
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool clearColorR
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool clearColorG
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool clearColorB
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool sensorScale
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool autoRotate
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool effectEnable
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool saveField
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static int timeZone
    {
        get
        {
            return 0;
        }
        set
        {
        }
    }

    public static bool appendOpenMode
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool hideBoundingBox
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static bool autoFit
    {
        get
        {
            return false;
        }
        set
        {
        }
    }

    public static string fieldAssetBundleName
    {
        get
        {
            return "";
        }
        set
        {
        }
    }

    public static string lastSelectionName
    {
        get
        {
            return "";
        }
        set
        {
        }
    }
}
