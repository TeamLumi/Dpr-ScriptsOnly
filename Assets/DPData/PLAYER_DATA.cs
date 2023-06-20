using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DPData
{
    [Serializable]
    public sealed class PLAYER_DATA : ScriptableObject
    {
        public GameObject config;

        public GameObject mystatus;

        public GameObject playtime;

        public GameObject contestdata;
    }
}
