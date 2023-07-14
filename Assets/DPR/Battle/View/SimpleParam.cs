using System;
using Pml;
using poketool;
using XLSXContent;

namespace Dpr.Battle.View
{
    public struct SimpleParam
    {
        //public SimpleParam(MonsNo monsNo = MonsNo.NULL, int formNo = 0, Sex sex = Sex.MALE, bool isRare = false, bool isEgg = false, float scale = 1f, int perRand = 0, PokeGType gType = PokeGType.NONE, int adjustHeight = 100, int speciesValue = -1)
        //{
        //}

        //public SimpleParam(PokemonInfo.SheetCatalog catalog, bool isContest)
        //{
        //}

        //public SimpleParam(SimpleParam other)
        //{
        //}

        public MonsNo monsNo;

        public int formNo;

        public Sex sex;

        public bool isRare;

        public bool isEgg;

        public float scale;

        public int perRand;

        public PokeGType gType;

        public int adjustHeight;

        public int speciesValue;
    }
}
