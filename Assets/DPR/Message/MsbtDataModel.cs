using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dpr.Message
{
    public class MsbtDataModel
    {
        private bool bIsCreate;
        private bool bIsResident;
        private int langID;
        private int hash;
        private string fileName;
        private LabelData[] labelDataArray;
        private Dictionary<int, int> labelIndexTable;
        private int currentIndex;

        public bool IsCreate
        {
            get { return bIsCreate; }
        }

        public bool IsResident
        {
            get { return bIsResident; }
        }

        public MsbtDataModel(LabelData[] labelDataArray, int langID, int hash, string fileName, bool isResident)
        {
            this.bIsCreate = false;
            this.langID = langID;
            this.hash = hash;
            this.fileName = fileName.ToLower();
            this.labelDataArray = labelDataArray;
            this.bIsResident = isResident;
        }

        public void ClearData()
        {
            this.labelDataArray = null;
            this.labelIndexTable.Clear();
        }

        public void CreateLabelTable()
        {
            if (this.labelIndexTable == null)
            {
                this.labelIndexTable = new Dictionary<int, int>(this.labelDataArray.Length);
            }

            if (this.currentIndex < this.labelDataArray.Length)
            {
                for (; this.currentIndex < this.labelDataArray.Length; this.currentIndex++)
                {
                    var labelData = this.labelDataArray[this.currentIndex];
                    if (!string.IsNullOrEmpty(labelData.labelName))
                    {
                        var key = labelData.labelName.GetHashCode();
                        if (!this.labelIndexTable.ContainsKey(key))
                        {
                            this.labelIndexTable.Add(key, labelData.arrayIndex);
                        }
                    }
                }
            }

            this.bIsCreate = true;
        }

        public LabelData[] LabelDataArray
        {
            get { return this.labelDataArray; }
        }

        public int GetTextNum()
        {
            return this.labelDataArray.Length;
        }

        public LabelData GetLabelDataByIndex(int labelIndex)
        {
            if (labelIndex >= 0 && labelIndex < this.labelDataArray.Length)
            {
                return this.labelDataArray[labelIndex];
            }
            else
            {
                // Log error message
                // EmitLog($"Index {labelIndex} is out of range for file {this.fileName} with length {this.labelDataArray.Length}", 0);
                return null;
            }
        }
    }
}
