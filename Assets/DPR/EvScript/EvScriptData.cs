using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

namespace Dpr.EvScript
{
    public class EvScriptData
    {
        public EvData EvData;
        public int LabelIndex;
        public int CommandIndex;
        public int RetIndex;

        public EvData.Script GetScript
        {
            get
            {
                return null;
            }
        }

        public EvScriptData(EvData ev)
        {
            // TODO
        }

        public int FindLabelIndex(string label)
        {
            // TODO
            return 0;
        }

        public EvData.Script FindLabelScript(string label)
        {
            // TODO
            return null;
        }

        public void Destroy()
        {
            // TODO
        }
    }
}