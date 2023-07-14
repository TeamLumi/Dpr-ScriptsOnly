using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Audio
{
    public class AudioManager : MonoBehaviour
    {
        public bool duration
        {
            get
            {
                return false;
            }
        }

        private void OnDestroy()
        {
        }

        private IEnumerator Start()
        {
            return null;
        }

        private void OnSettingValueChanged(object configId, int value)
        {
        }

        public bool GetVolume(object type, object volumeType)
        {
            return false;
        }

        public void SetVolume(object type, bool volume, object volumeType)
        {
        }

        private void SetVolumeInternal(object type)
        {
        }

        internal void _SetInstanceVolume(object instance)
        {
        }

        private void SetInstanceVolume(object instance, object listenerParam)
        {
        }

        public bool IsMute(object type)
        {
            return false;
        }

        public void EnableMute(object type, bool isMute)
        {
        }

        public void Load(object loadParam, object onLoaded)
        {
        }

        private IEnumerator OpWaitLoad(object audioData, object onLoaded)
        {
            return null;
        }

        internal static void _Unload(object audioData)
        {
        }

        public object FindAudioData(string bankName)
        {
            return null;
        }

        public object FindAudioData(uint bankId)
        {
            return null;
        }

        public void PlayBgm()
        {
        }

        public void StopBgm()
        {
        }

        public void SetBgmEvent(string eventName)
        {
        }

        public void SetBgmEvent(uint eventId)
        {
        }

        public void SetBgmState(string stateName)
        {
        }

        public uint GetIdByName(string name)
        {
            return 0U;
        }

        public object PlaySe(uint playEventId, object onFinished)
        {
            return null;
        }

        public object PlaySe(uint playEventId, uint stopEventId, object onFinished)
        {
            return null;
        }

        public object CreateSe(uint playEventId, object stopEventId)
        {
            return null;
        }

        public object CreateSe(uint playEventId, uint stopEventId, Vector3 position, Quaternion rotation, object attachedTransform)
        {
            return null;
        }

        public object PlayVoice(uint playEventId, object onFinished)
        {
            return null;
        }

        public object PlayVoice(uint playEventId, Transform t, object onFinished)
        {
            return null;
        }

        public object PlayVoice(uint playEventId, uint stopEventId, object onFinished)
        {
            return null;
        }

        public object CreateVoice(uint playEventId, object stopEventId)
        {
            return null;
        }

        public object CreateVoice(uint playEventId, uint stopEventId, Vector3 position, Quaternion rotation, object attachedTransform)
        {
            return null;
        }

        private object CreateInstance(object listenerType, uint playEventId, uint stopEventId, Vector3 position, Quaternion rotation, object attachedTransform)
        {
            return null;
        }

        public uint GetCurrentStateId(uint groupId)
        {
            return 0U;
        }

        //public Vector3 GetListenerPosition()
        //{
            //return null;
        //}

        public void SetListenerPosition(Vector3 pos)
        {
        }

        //public Quaternion GetListenerRotation()
        //{
            //return null;
        //}

        public void SetListenerRotation(Quaternion rotation)
        {
        }

        public bool GetBgmPlayPosition()
        {
            return false;
        }

        internal void _RemoveInstance(object instance)
        {
        }

        public uint PostEvent(uint eventId, object callbackFlags)
        {
            return 0U;
        }

        private uint PostEventInternal(uint eventId, uint callbackFlags)
        {
            return 0U;
        }

        private static void OnPostEvent(object in_cookie, object in_type, object in_info)
        {
        }

        public uint RePostEvent(uint eventId, object callbackFlags)
        {
            return 0U;
        }

        private uint RePostEventInternal(uint eventId, uint callbackFlags)
        {
            return 0U;
        }

        private void LateUpdate()
        {
        }

        public void EnableUpdateListenerByMainCamera(bool enabled)
        {
        }

        public bool IsEnableUpdateListenerByMainCamera()
        {
            return false;
        }

        private void UpdateListenerByMainCamera()
        {
        }

        public bool GetRTPCValue(uint gameParamId)
        {
            return false;
        }

        public void SetRTPCValue(uint gameParamId, bool value)
        {
        }

        public void CreateVoiceRTPCDatas()
        {
        }

        public object GetVoiceRtpcData(string eventName)
        {
            return null;
        }

        public GameObject _prefab;

        public object _poolCounts;

        public Transform _listenerRoot;

        public string _commonBankName;

        public GameObject _voiceRtpc;

        public GameObject _listenerParams;

        public GameObject _audioInstances;

        public GameObject _objectPool;

        public GameObject _audioDatas;

        public uint _eventId;

        public uint _bgmPlayId;

        public bool _isUpdateListenerCamera;

        public float _duration;

        public GameObject onFinishBgm;

        public GameObject onLoaded;
    }

    //public uint bankId;

//public string eventName;

class ListenerParam
{ 
    public bool GetVolume()
    {
        return false;
    }

    public GameObject _listener;

    public GameObject _volumes;

    public bool _isMute;
}

public sealed class ListenerType : ScriptableObject
{
    public int value__;

    public GameObject Bgm;

    public GameObject Se;

    public GameObject Voice;
}

[StructLayout(LayoutKind.Sequential)]
public sealed class LoadParam : ScriptableObject
{
    public string bankName;
}

/*
private sealed class PoolType : ScriptableObject
{
    public GameObject Se;

    public GameObject Voice;
}


public sealed class VolumeType : ScriptableObject
{
    public GameObject Config;

    public GameObject Normal;
}
*/

}