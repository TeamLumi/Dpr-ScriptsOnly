using System.Runtime.InteropServices;

namespace nn.account
{
    public static partial class Account
    {
        public const int UserCountMax = 8;
        public const int ProfileImageBytesMax = 128 * 1024;
        public const int SaveDataThumbnailImageBytesMax = 256 * 144 * 4;

#if UNITY_EDITOR
        public static Result GetUserCount(ref int pOutCount)
        {
            pOutCount = 0;
            return new Result();
        }

        public static Result GetUserExistence(ref bool pOutExistence, Uid user)
        {
            pOutExistence = false;
            return new Result();
        }

        public static Result ListAllUsers(ref int pOutActualLength, Uid[] outUsers)
        {
            pOutActualLength = 0;
            return new Result();
        }

        public static Result ListOpenUsers(ref int pOutActualLength, Uid[] outUsers)
        {
            pOutActualLength = 0;
            return new Result();
        }

        public static Result GetLastOpenedUser(ref Uid pOutUser)
        {
            return new Result();
        }

        public static Result GetNickname(ref Nickname pOut, Uid user)
        {
            return new Result();
        }

        public static Result LoadProfileImage(ref long pOutActualSize, byte[] outImage, Uid user)
        {
            return new Result();
        }
#else
        [DllImport(Nn.DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nn_account_GetUserCount")]
        public static extern Result GetUserCount(ref int pOutCount);

        [DllImport(Nn.DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nn_account_GetUserExistence")]
        public static extern Result GetUserExistence([MarshalAs(UnmanagedType.U1)] ref bool pOutExistence, Uid user);

        public static Result ListAllUsers(ref int pOutActualLength, Uid[] outUsers)
        {
            return Account.ListAllUsers(ref pOutActualLength, outUsers, outUsers.Length);
        }

        [DllImport(Nn.DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nn_account_ListAllUsers")]
        private static extern Result ListAllUsers(ref int pOutActualLength, [Out] Uid[] outUsers, int arrayLength);

        public static Result ListOpenUsers(ref int pOutActualLength, Uid[] outUsers)
        {
            return Account.ListOpenUsers(ref pOutActualLength, outUsers, outUsers.Length);
        }

        [DllImport(Nn.DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nn_account_ListOpenUsers")]
        private static extern Result ListOpenUsers(ref int pOutActualLength, [Out] Uid[] outUsers, int arrayLength);

        [DllImport(Nn.DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nn_account_GetLastOpenedUser")]
        public static extern Result GetLastOpenedUser(ref Uid pOutUser);

        [DllImport(Nn.DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nn_account_GetNickname")]
        public static extern Result GetNickname(ref Nickname pOut, Uid user);

        public static Result LoadProfileImage(ref long pOutActualSize, byte[] outImage, Uid user)
        {
            return Account.LoadProfileImage(ref pOutActualSize, outImage, outImage.LongLength, user);
        }

        [DllImport(Nn.DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nn_account_LoadProfileImage")]
        private static extern Result LoadProfileImage(ref long pOutActualSize, byte[] outImage, long bufferSize, Uid user);
#endif
    }
}
