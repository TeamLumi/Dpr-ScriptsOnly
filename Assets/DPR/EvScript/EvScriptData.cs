using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dpr.EvScript
{
    public class EvScriptData
    {
        private List<EvData.Script> _scripts;
        private int _labelIndex;

        public EvScriptData(EvData ev)
        {
            EvData = ev;
            _scripts = ev.Scripts;
        }

        public EvData.Script GetScript
        {
            get
            {
                if (_scripts.Count <= _labelIndex)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return _scripts[_labelIndex];
            }
        }

        public int FindLabelIndex(string label)
        {
            return _scripts.FindIndex(script => script.Label == label);
        }

        public EvData.Script FindLabelScript(string label)
        {
            return _scripts.Find(script => script.Label == label);
        }

        public void Destroy()
        {
            EvData = null;
        }

        public EvData EvData { get; set; }

        public int LabelIndex
        {
            get => _labelIndex;
            set
            {
                if (value < 0 || value >= _scripts.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _labelIndex = value;
            }
        }

        public int CommandIndex { get; set; }

        public int RetIndex { get; set; }
    }
}
