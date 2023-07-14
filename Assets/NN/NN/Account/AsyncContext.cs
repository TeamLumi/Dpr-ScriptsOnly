using System;
using System.Runtime.InteropServices;

namespace nn.account
{
    public sealed class AsyncContext : IDisposable
    {
        internal IntPtr _context = IntPtr.Zero;

        public AsyncContext()
        {
#if !UNITY_EDITOR
            _context = Create();
#endif
        }

        ~AsyncContext()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

#if UNITY_EDITOR
        private void Dispose(bool disposing)
        {
        }

        public Result Cancel()
        {
            return new Result();
        }

        public Result HasDone(ref bool pOut)
        {
            pOut = true;
            return new Result();
        }

        public Result GetResult()
        {
            return new Result();
        }
#else
        private void Dispose(bool disposing)
        {
            if (_context != IntPtr.Zero)
            {
                Destroy(_context);
                _context = IntPtr.Zero;
            }
        }

        public Result Cancel()
        {
            return Cancel(_context);
        }

        public Result HasDone(ref bool pOut)
        {
            return HasDone(_context, ref pOut);
        }

        public Result GetResult()
        {
            return GetResult(_context);
        }

        [DllImport(Nn.DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nn_account_AsyncContextCreate")]
        private static extern IntPtr Create();

        [DllImport(Nn.DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nn_account_AsyncContextDestroy")]
        private static extern void Destroy(IntPtr context);

        [DllImport(Nn.DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nn_account_AsyncContextCancel")]
        private static extern Result Cancel(IntPtr context);

        [DllImport(Nn.DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nn_account_AsyncContextHasDone")]
        private static extern Result HasDone(IntPtr context, [MarshalAs(UnmanagedType.U1)] ref bool pOut);

        [DllImport(Nn.DllName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "nn_account_AsyncContextGetResult")]
        private static extern Result GetResult(IntPtr context);
#endif
    }
}
