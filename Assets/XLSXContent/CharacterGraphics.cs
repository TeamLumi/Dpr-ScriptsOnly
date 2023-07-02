using System;
using UnityEditor;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class CharacterGraphics : ScriptableObject
    {
        public SheetData[] Data;

        [Serializable]
        public class SheetData
        {
            public string ID;

            public string FieldGraphic;

            public float Scale;

            public float HandScale;

            public MonoBehaviour animTbl;
        }
    }
}
