using System;
using UnityEngine;

namespace XLSXContent
{
    [Serializable]
    public class UgFatherShopTable : ScriptableObject
    {
        public UgFatherShopTable.Sheetbuy01 Item
        {
            get
            {
                return null;
            }
        }

        public UgFatherShopTable()
        {
        }

        public UgFatherShopTable.Sheetbuy01[] buy01;

        public UgFatherShopTable.Sheetbuy01diz[] buy01diz;

        public UgFatherShopTable.Sheetbuy02[] buy02;

        public UgFatherShopTable.Sheetbuy02diz[] buy02diz;

        public UgFatherShopTable.Sheetsale01[] sale01;

        public UgFatherShopTable.Sheetsale02[] sale02;

        public UgFatherShopTable.SheetshopListData[] shopListData;

        [Serializable]
        public class Sheetbuy01 : UgFatherShopTable.SheetBuyBase
        {
            public Sheetbuy01()
            {
            }
        }

        [Serializable]
        public class Sheetbuy01diz : UgFatherShopTable.SheetBuydizBase
        {
            public Sheetbuy01diz()
            {
            }
        }

        [Serializable]
        public class Sheetbuy02 : UgFatherShopTable.SheetBuyBase
        {
            public Sheetbuy02()
            {
            }
        }

        [Serializable]
        public class Sheetbuy02diz : UgFatherShopTable.SheetBuydizBase
        {
            public Sheetbuy02diz()
            {
            }
        }

        public class SheetBuydizBase : UgFatherShopTable.SheetBuyBase
        {
            public SheetBuydizBase()
            {
            }

            public bool Sunday;

            public bool Monday;

            public bool Tuesday;

            public bool Wednesday;

            public bool Thursday;

            public bool Friday;

            public bool Saturday;
        }

        public class SheetBuyBase
        {
            public SheetBuyBase()
            {
            }

            public int UgItemID;

            public int Category;

            public int unit;

            public int Badge;

            public bool zukanflag;

            public int ExchangeItemID;

            public int lotteryrate;

            public int[] DExchangeItem;

            public int[] PExchangeItem;

            public string MsItemLabel;

            public string MsItemInfoLabel;
        }

        [Serializable]
        public class Sheetsale01
        {
            public Sheetsale01()
            {
            }

            public int UgItemID;

            public int ExchangeItemID;

            public int DExchangeItem;

            public int PExchangeItem;

            public string MsItemLabel;

            public string MsItemInfoLabel;
        }

        [Serializable]
        public class Sheetsale02
        {
            public Sheetsale02()
            {
            }

            public int UgItemID;

            public int ExchangeItemID;

            public int ExchangeItem;

            public string MsItemLabel;

            public string MsItemInfoLabel;
        }

        [Serializable]
        public class SheetshopListData
        {
            public SheetshopListData()
            {
            }

            public int[] categoryItemNum;
        }
    }
}
