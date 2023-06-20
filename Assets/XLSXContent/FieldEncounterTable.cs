using System;
using System.Linq;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class FieldEncountTable
    {
        [Serializable]
        public class Sheettable : ScriptableObject
        {
            public GameObject zoneID;

            public int encRate_gr;

            public GameObject ground_mons;

            public GameObject tairyo;

            public GameObject day;

            public GameObject night;

            public GameObject swayGrass;

            public GameObject FormProb;

            public GameObject Nazo;

            public GameObject AnnoonTable;

            public GameObject gbaRuby;

            public GameObject gbaSapp;

            public GameObject gbaEme;

            public GameObject gbaFire;

            public GameObject gbaLeaf;

            public int encRate_wat;

            public GameObject water_mons;

            public int encRate_turi_boro;

            public GameObject boro_mons;

            public int encRate_turi_ii;

            public GameObject ii_mons;

            public int encRate_sugoi;

            public GameObject sugoi_mons;
        }

        [Serializable]
        public class Sheeturayama : ScriptableObject
        {
            public GameObject monsNo;
        }

        [Serializable]
        public class Sheetmistu : ScriptableObject
        {
            public int Rate;

            public GameObject Normal;

            public GameObject Rare;

            public GameObject SuperRare;
        }

        [Serializable]
        public class Sheethoneytree : ScriptableObject
        {
            public int Normal;

            public int Rare;
        }

        [Serializable]
        public class Sheetsafari : ScriptableObject
        {
            public GameObject MonsNo;
        }

        [Serializable]
        public class Sheetmvpoke : ScriptableObject
        {
            public GameObject zoneID;

            public int nextCount;

            public GameObject nextZoneID;
        }

        [Serializable]
        public class Sheetlegendpoke : ScriptableObject
        {
            public GameObject monsNo;

            public int formNo;

            public bool isFixedEncSeq;

            public string encSeq;

            public bool isFixedBGM;

            public string bgmEvent;

            public bool isFixedBtlBg;

            public GameObject btlBg;

            public bool isFixedSetupEffect;

            public GameObject setupEffect;
        }

        [Serializable]
        public class Sheetzui : ScriptableObject
        {
            public GameObject zoneID;

            public GameObject form;
        }

        public GameObject table;

        public GameObject urayama;

        public GameObject mistu;

        public GameObject honeytree;

        public GameObject safari;

        public GameObject mvpoke;

        public GameObject legendpoke;

        public GameObject zui;

        public object this[int index] => null;
    }
}
