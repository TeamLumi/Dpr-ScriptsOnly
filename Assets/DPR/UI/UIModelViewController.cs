using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI
{
    public class UIModelViewController : MonoBehaviour
    {
        public object modelParam
        {
            get
            {
                return null;
            }
        }

        public RectTransform modelBgRoot
        {
            get
            {
                return null;
            }
        }

        public void SetModelViewType(object type)
        {
        }

        public object GetModelViewParameters(object type, object pokemonParam)
        {
            return null;
        }

        public int GetModelViewParameterIdleAnimation(object type, object pokemonParam)
        {
            return 0;
        }

        public void SaveEnvironmentController()
        {
        }

        public void EnableModelLight(bool enabled, object type)
        {
        }

        private object GetEnvironmentSettings(object type)
        {
            return null;
        }

        private bool IsEnableGlobalEnvironmentController()
        {
            return false;
        }

        private void EnableGlobalEnvironmentController(bool enabled)
        {
        }

        public void ModelViewSize(bool width, bool height)
        {
        }

        public void ModelCameraFov(bool fov)
        {
        }

        public void ModelReflection(bool alpha)
        {
        }

        public void ModelCameraCenterOffsetX(bool offsetX)
        {
        }

        public void ModelCameraCenterOffset(Vector2 offset)
        {
        }

        public void SetModelOffset(Vector3 offset)
        {
        }

        public void SetModelRotation(Vector3 rotation)
        {
        }
        //public Vector3 GetModelRotation()
        //{
            //return null;
        //}

        public void SetModelScale(bool scale)
        {
        }

        public void SetModelAttachOffset(Vector3 offset)
        {
        }

        public bool GetCameraRotationX()
        {
            return false;
        }

        public void SetCameraRotationX(bool x)
        {
        }

        //public Vector3 GetModelCameraPosition()
        //{
            //return null;
        //}

        public int ResetCaches(int num, bool isUnload)
        {
            return 0;
        }

        public IEnumerator OpLoadModel(object modelViewType, int uniqueId, string assetBundleName, bool isDontClear, object onSetupParam, UnityAction onSetup)
        {
            return null;
        }

        private void CacheParamMoveLast(object modelParam)
        {
        }

        public IEnumerator OpLoadCharacterModel(int uniqueId, string assetBundleName, bool isDontClear, object onSetup, object trainerType)
        {
            return null;
        }

        public void EnableMainCameraByUiMode(bool enabled)
        {
        }

        private void SetupCharacterModel(object trainerType)
        {
        }

        public IEnumerator OpLoadPokemonModel(object pokemonParam, bool isApplyOffset, bool isDontClear, object onSetup)
        {
            return null;
        }

        private void ModelAttachTransforms(object modelParam)
        {
        }

        private void SetupPokemonModel(object pokemonParam, bool isApplyOffset)
        {
        }

        internal void _SetupPokemonModel(object pokemonParam, bool isApplyOffset, Vector3 modelOffset, Vector3 modelRotation, bool modelScale, Vector3 modelAttachOffset)
        {
        }

        public object ComputeBoundingSphereByPokemon(GameObject pokemonObj)
        {
            return null;
        }

        public void PlayAnimation(int anim, bool forceLoop)
        {
        }

        public void StopAnimation()
        {
        }

        public bool GetCurrentRemaingTime()
        {
            return false;
        }

        public int GetAnimationIndexByClipName(string clipName)
        {
            return 0;
        }

        public bool IsPlayAnimation()
        {
            return false;
        }

        public void PauseAnimation(bool paused)
        {
        }

        public void LoopAnimation(bool looped)
        {
        }

        internal void _UpdateModelView()
        {
        }

        public void SetupModelViewCameras(bool enableModelCamera)
        {
        }

        private void SetupModelViewCamera(bool enableModelCamera, Camera camera)
        {
        }

        private void UpdateModelViewCameras()
        {
        }

        //private Matrix4x4 ComputeReflectionMatrix(Vector4 n)
        //{
            //return null;
        //}

        private void OnViewportChange(int screenWidth, int screenHeight)
        {
        }

        public RenderTexture GetModelViewRenderTexture()
        {
            return null;
        }

        public void ClearModelView(bool isFinish)
        {
        }

        private void SetActive(bool enabled)
        {
        }

        private void DestroyCaches(bool isUnload)
        {
        }

        private void UnloadUnused()
        {
        }

        public GameObject _modelBgRoot;

        public Transform _modelRoot;

        public GameObject _modelBgCamera;

        public GameObject _modelCamera;

        public GameObject _reflectionCamera;

        public GameObject _modelEnvironmentController;

        public GameObject _environmentCharacter;

        public GameObject _environmentPokemon;

        public GameObject _environmentControllerSaver;

        public bool _isActived;

        public GameObject _modelViewSize;

        public float _modelCameraFov;

        public float _modelReflectionAlpha;

        public GameObject _modelCameraCenterOffset;

        public Vector3 _modelOffset;

        public Vector3 _modelRotation;

        public Vector3 _modelAttachOffset;

        public float _modelScale;

        public float _cameraRotationX;

        public int _loadRequestModelId;

        public GameObject _modelParam;

        public GameObject _saveCameraParam;

        public int defaultCacheModelNum;

        public GameObject _cacheParams;

        public GameObject _modelViewType;

    public GameObject modelViewType;

    public int uniqueId;

    public GameObject cacheParam;

            public GameObject onSetupParam;

    public GameObject onSetup;

public GameObject trainerType;

public GameObject pokemonParam;

public bool isApplyOffset;

public string attachTransName;

public string motionName;

public string clipName;

private void Dispose()
{
}

private bool MoveNext()
{
    return false;
}

private object Current
{
    get
    {
        return null;
    }
}

private void Reset()
{
}

public string assetBundleName;

public bool isDontClear;

    public bool loaded;

    public GameObject assetBundleUnloader;

    public GameObject gameObject;

    public GameObject baseEntity;

    public GameObject root;

    public GameObject attachTo;

    public GameObject attachFrom;

    public float attachPosY;

public sealed class ModelViewType : ScriptableObject
{
    public int value__;

    public GameObject None;

    public GameObject Pokemon;

    public GameObject Character;

    public GameObject Party;

    public GameObject Zukan;

    public GameObject Box;

    public GameObject Boutique;

    public GameObject Habitat;

    public GameObject Moving;

    public GameObject Compare;
}

private class SaveCameraParam : ScriptableObject
{
    public GameObject camera;

    public bool actived;

    public int cullMask;

    public GameObject subCameraParams;
}
	}
}