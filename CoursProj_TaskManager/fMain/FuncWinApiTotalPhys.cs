using System.Runtime.InteropServices;
using System.Security;

namespace fMain
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    public class FuncWinApiTotalPhys
    {
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        internal static extern bool GlobalMemoryStatusEx([In, Out] FuncWinApiTotalPhys lpBuffer);

        private uint dwLength;
        public uint MemoryLoad;
        public ulong TotalPhys;
        public ulong AvailPhys;
        public ulong TotalPageFile;
        public ulong AvailPageFile;
        public ulong TotalVirtual;
        public ulong AvailVirtual;
        public ulong AvailExtendedVirtual;

        private static volatile FuncWinApiTotalPhys singleton;
        private static readonly object syncroot = new object();

        public static FuncWinApiTotalPhys CreateInstance()
        {
            if (singleton == null)
                lock (syncroot)
                    if (singleton == null)
                        singleton = new FuncWinApiTotalPhys();
            return singleton;
        }

        [SecurityCritical]
        private FuncWinApiTotalPhys()
        {
            dwLength = (uint)Marshal.SizeOf(typeof(FuncWinApiTotalPhys));
            GlobalMemoryStatusEx(this);
        }


        
    }
}
