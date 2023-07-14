using System;
using DG.Tweening;
using System.Runtime.InteropServices;
using UnityEngine;

namespace SmartPoint.Components
{
    [Serializable]
    public struct SkinnedMeshRendererCluster
    {
        [SerializeField]
        public Transform node;

        [SerializeField]
        public SkinnedMeshRenderer[] renderers;
    }
}
