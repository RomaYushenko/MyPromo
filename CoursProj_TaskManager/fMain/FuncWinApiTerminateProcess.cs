using System;
using System.Runtime.InteropServices;

using System.ComponentModel;


namespace fMain
{
    class FuncWinApiTerminateProcess
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, IntPtr dwProcessId);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool CloseHandle(IntPtr hObject);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool TerminateProcess(int hProcess, uint uExitCode);

        const uint PROCESS_TERMINATE = 0x1;

        private static volatile FuncWinApiTerminateProcess singleton;
        private static readonly object syncroot = new object();

        public static FuncWinApiTerminateProcess CreateInstanceT()
        {
            if (singleton == null)
                lock (syncroot)
                    if (singleton == null)
                        singleton = new FuncWinApiTerminateProcess();
            return singleton;
        }

        public void TerminateProcess(IntPtr PID)
        {
            IntPtr hProcess = OpenProcess(PROCESS_TERMINATE, false, PID);

            if (hProcess == IntPtr.Zero)
                throw new Win32Exception(
                    Marshal.GetLastWin32Error());

            if (!TerminateProcess((int)hProcess, 0))
                throw new Win32Exception(
                    Marshal.GetLastWin32Error());

            CloseHandle(hProcess);
        }
    }
}
