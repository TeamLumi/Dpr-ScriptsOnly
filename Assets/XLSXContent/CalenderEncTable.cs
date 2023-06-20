using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class CalenderEncTable
    {
        [Serializable]
        public class Sheetdata : ScriptableObject
        {
            public int month;

            public int day;

            public int add_rate;

            public int add_hatching;
        }

        [Serializable]
        public class Sheetweather : ScriptableObject
        {
            public GameObject r212b;

            public GameObject r213;

            public GameObject r216;

            public GameObject l3;

            public GameObject c9;
        }

        public GameObject data;

        public GameObject weather;

        public object this[int index] => null;
    }
}
