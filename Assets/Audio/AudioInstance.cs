using SmartPoint.AssetAssistant;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Audio
{
    public class AudioInstance //: IObjectPoolInstance
    {
        public UnityAction<AudioInstance> OnFinished;
        public bool IsManualRemoved;
        public GameObject AkGameObj;
        public float Volume;
        public uint PlayEventId;
        public uint PlayId;
        public bool IsDurtyRtpc;
        public uint StateBits;

        //private AkGameObj _akGameObj;
        private int _listenerType;
        private uint _playEventId;
        private uint _stopEventId;
        private uint _playId;
        private float _duration;
        private bool _isCleanup;
        //private UnityObject _attachedTransform;

        //public AkGameObj akGameObj => _akGameObj;
        //public int listenerType => _listenerType;
        //public uint playEventId => _playEventId;
        //public uint stopEventId => _stopEventId;
        //public uint postEventNumber => _playId;
        //public float duration => _duration;

        public bool isCleanup => _isCleanup;

        public void SetGameObject(GameObject obj)
        {
            //_akGameObj = obj.GetComponent<AkGameObj>();
        }

        public GameObject GetGameObject()
        {
            //return _akGameObj.gameObject;
            return null;
        }

        public void OnCreate()
        {
            // Empty method
        }

        public void OnRelease()
        {
            // Empty method
        }

        //public void Setup(int listenerType, uint playEventId, uint stopEventId, Vector3 position, Quaternion rotation, UnityObject attachedTransform)
        //{
            //_attachedTransform = attachedTransform;
            //_listenerType = listenerType;
            //_playEventId = playEventId;
            //_stopEventId = stopEventId;

            //if (attachedTransform != null)
            //{
                //_localRotation = rotation;
                //_localPosition = position;
                //UpdateTransform();
            //}
            //else
            //{
                //_akGameObj.transform.localRotation = rotation;
                //_akGameObj.transform.localPosition = position;
                //_akGameObj.SetPosition();
            //}
        //}

        void UpdateTransform()
        {
            // Some initializations and object retrievals
            //Vector3 vector1 = Vector3.get_one();
            //Matrix4x4 matrix1 = Matrix4x4.TRS(vector1, vector1, vector1);

            // Some matrix operations
            //Matrix4x4 matrix2 = Matrix4x4.op_Multiply(matrix1, matrix1);

            // Retrieve column vectors from the matrix
            //Vector4 columnVector1 = matrix2.GetColumn(3);
            //Vector4 columnVector2 = matrix2.GetColumn(2);

            // Implicit conversion from Vector4 to Vector3
            //Vector3 vector2 = Vector4.op_Implicit(columnVector1);
            //Vector3 vector3 = Vector4.op_Implicit(columnVector2);

            // Set position and rotation of some object
            //Transform transform = GetTransform(); // Placeholder for actual method to get the transform
            //transform.set_localRotation(vector2);
            //transform.set_localPosition(vector3);

            // Set position of some game object
            //AkGameObj akGameObject = GetAkGameObject(); // Placeholder for actual method to get the AkGameObj
            //akGameObject.SetPosition(transform);
        }

        internal void _Setup(object listenerType, uint playEventId, uint stopEventId, Vector3 position, Quaternion rotation, object attachedTransform)
        {
        }

        /*
        public AudioInstance Play(UnityAction<AudioInstance> onFinished, bool isManualRemoved)
        {
            this.OnFinished = onFinished;
            this.StateBits |= 2;
            this.IsManualRemoved = isManualRemoved;
            GameObject gameObject = this.AkGameObj.gameObject;
            gameObject.SetActive(true);
            this.Volume = Volume;
            AudioManager instance = SingletonMonoBehaviour<AudioManager>.Instance;
            instance.SetInstanceVolume(this);
            this.UpdateTransform();
            uint eventId = this.PlayEventId;
            //EventCallback callback = new EventCallback();
            //this.PlayId = AkSoundEngine.PostEvent(eventId, gameObject, 0x100009, callback, this);
            if (this.PlayId == 0)
            {
                OpDelayPlayComplete();
            }
            return this;
        }
        */

        private IEnumerator OpDelayPlayComplete()
        {
            return null;
        }

        private static void OnPostEvent(object in_cookie, object in_type, object in_info)
        {
        }

        public void Stop()
        {
        }

        private static void OnStopComplete(object in_cookie, object in_type, object in_info)
        {
        }

        public void SetLocalPosition(Vector3 localPos)
        {
        }

        internal void _Update()
        {
            UpdateTransform();
        }

        public bool GetPlayPosition(bool isExtrapolate)
        {
            return false;
        }

        public bool GetVolume()
        {
            return false;
        }

        public void SetVolume(float volume)
        {
            this.Volume = volume;
            //AudioManager instance = SingletonMonoBehaviour<AudioManager>.Instance;
            //instance.SetInstanceVolume(this);
        }

        public bool GetRTPCValue(uint gameParamId)
        {
            return false;
        }

        public void SetRTPCValue(uint gameParamId, bool value)
        {
        }

        public uint GetSwitch(uint groupId)
        {
            return 0U;
        }

        public void SetSwitch(uint groupId, uint state)
        {
        }

        public GameObject _akGameObj;

        public Transform _attachedTransform;

        public Vector3 _localPosition;

        public GameObject _localRotation;

        public GameObject _onFinished;

        public float _volume;

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
    }
}
