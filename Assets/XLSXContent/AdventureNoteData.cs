using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class AdventureNoteData : ScriptableObject
    {
        public SheetData[] Data;

        public SheetTIPS[] TIPS;

        [Serializable]
        public class SheetData
        {
            public int Index;

            public int Version;

            public int Category;

            public string TitleLabel;

            public string TextLabel;

            public string TextLabelPatch;

            public bool NoteShowFlag;

            public string Image;

            public int OpenFlag;
        }

        [Serializable]
        public class SheetTIPS
        {
            public int Category;

            public string FieldDisplay;

            public string MessageLabel;

            public string TipsTitleName;
        }
    }
}
