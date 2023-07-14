using System;

namespace nn
{
    public static partial class Nn
    {
#if UNITY_EDITOR
        // This is for spoofing purposes
        internal const string DllName = "NintendoSDKPlugin";

        public static void Abort(string message)
        {
            Logger.Log(message);
        }
#else
        internal const string DllName = "__Internal";

        [DllImport(Nn.DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nn_Abort")]
        public static extern void Abort(string message);
#endif
        public static void Abort(string message, params object[] args)
        {
            Abort(string.Format(message, args));
        }

        public static void Abort(bool condition, string message)
        {
            if (!condition)
            {
                Abort(message);
            }
        }

        public static void Abort(bool condition, string message, params object[] args)
        {
            if (!condition)
            {
                Abort(string.Format(message, args));
            }
        }
    }
}
