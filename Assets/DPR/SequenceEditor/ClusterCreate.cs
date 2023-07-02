using System;
using UnityEngine;

namespace Dpr.SequenceEditor
{
    public class ClusterCreate : ScriptableObject
    {
        public ClusterCreate(object macro)
        {
        }

        public string file;

        public string fileAnm;

        public bool useAnm;

        public GameObject drawType;

        public GameObject rotOrder;

        public int spawnMax;

        public int spawnTime;

        public int spawnInterval;

        public int spawnNum;

        public int spawnRate;

        public int spawnLife;

        public GameObject spawnType;

        public GameObject spawnAxis;

        public Vector3 spawnSize;

        public int spawnDegS;

        public int spawnDegE;

        public int spawnLen;

        public bool isMulti;
    }
}
