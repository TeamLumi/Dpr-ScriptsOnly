using System;
using SmartPoint.AssetAssistant.UnityExtensions;
using UnityEngine;
using UnityEngine.Rendering;

namespace Dpr.Battle.View.Systems
{
    public struct ShadowCastObject
    {
        public Transform originObject
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public Renderer[] renderers
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public ShadowCastingMode[] initializeModes
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        public bool isDelete
        {
            get
            {
                return default(bool);
            }
            set
            {
            }
        }

        //public Pair<Renderer, Renderer>[] linkRenderes
        //{
            //get
            //{
                //return null;
            //}
            //set
            //{
            //}
        //}

        public static ShadowCastObject Factory(Transform originObject, Renderer[] renderers)
        {
            return default(ShadowCastObject);
        }

        public void Initialize(Material shadowCastMaterial)
        {
        }

        public void UnInitialize()
        {
        }

        public void SetDraw(bool isDraw)
        {
        }

        public void Draw()
        {
        }

        public Material sharedMaterial;
    }
}
