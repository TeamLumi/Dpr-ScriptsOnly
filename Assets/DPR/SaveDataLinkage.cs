using System;

namespace Dpr
{
    public class SaveDataLinkage
    {
        public static bool IsEnable(SaveDataLinkage.LinkageApp app)
        {
            return default(bool);
        }

        public static void CheckSaveData()
        {
        }

        private static bool CheckSaveDataCore(byte[] buf)
        {
            return default(bool);
        }

        public SaveDataLinkage()
        {
        }

        private const ulong APP_ID_E = 72084463414370304UL;

        private const ulong APP_ID_K = 72246641462509568UL;

        private const ulong APP_ID_P = 72061923425992704UL;

        private const ulong APP_ID_T = 72213381238669312UL;

        private const ulong APP_ID_H = 72092022778863616UL;

        private const uint H_CODE_TRUE = 1777065704U;

        private const uint H_CODE_FALSE = 3290706629U;

        private const string H_MOUNT_NAME = "HB";

        private const string H_SAVEDATA_PATH = "HB:/main2";

        private static bool _hLinkageEnable;

        public enum LinkageApp
        {
            B,
            O,
            H
        }
    }
}
