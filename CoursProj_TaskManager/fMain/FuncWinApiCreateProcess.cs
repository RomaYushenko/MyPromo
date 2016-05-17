using System;
using System.Runtime.InteropServices;

namespace fMain
{
    class FuncWinApiCreateProcess
    {

        [DllImport("kernel32.dll")]
        static extern bool CreateProcess(
            string lpApplicationName,
            string lpCommandLine,
            IntPtr lpProcessAttributes,
            IntPtr lpThreadAttributes,
            bool bInheritHandles,
            uint dwCreationFlags,
            IntPtr lpEnvironment,
            string lpCurrentDirectory,
            ref STARTUPINFO lpStartupInfo,
            out PROCESS_INFORMATION lpProcessInformation);

        public struct PROCESS_INFORMATION
        {
            public IntPtr hProcess;
            public IntPtr hThread;
            public uint dwProcessId;
            public uint dwThreadId;
        }



        public struct STARTUPINFO
        {
            public uint cb;
            public string lpReserved;
            public string lpDesktop;
            public string lpTitle;
            public uint dwX;
            public uint dwY;
            public uint dwXSize;
            public uint dwYSize;
            public uint dwXCountChars;
            public uint dwYCountChars;
            public uint dwFillAttribute;
            public uint dwFlags;
            public short wShowWindow;
            public short cbReserved2;
            public IntPtr lpReserved2;
            public IntPtr hStdInput;
            public IntPtr hStdOutput;
            public IntPtr hStdError;
        }



        public struct SECURITY_ATTRIBUTES
        {
            public int length;
            public IntPtr lpSecurityDescriptor;
            public bool bInheritHandle;
        }


        private static volatile FuncWinApiCreateProcess singleton;
        private static readonly object syncroot = new object();

        public static FuncWinApiCreateProcess CreateInstanceCrProc()
        {
            if (singleton == null)
                lock (syncroot)
                    if (singleton == null)
                        singleton = new FuncWinApiCreateProcess();
            return singleton;
        }

        /// <summary>
        /// Метод которые открывает новый процесс. То того какой будет переменная flag, от того и будет происходит разное открытие.
        /// Если flag == true. Значит берется полная директория нахождения программы, и она открывается
        /// Eсли flag == false Значит в строку ввели только название программы которая находится в папке System32 и это название подставляется в готовую строку директории.
        /// </summary>
        /// <param name="nameProg">строка в которой хранится имя или директория программы</param>
        /// <param name="flag"> буллевая переменная </param>
        public void CreateProcessInPC(string nameProg, bool flag)
        {
            STARTUPINFO si = new STARTUPINFO();
            PROCESS_INFORMATION pi = new PROCESS_INFORMATION();
            
            if (flag)
            {
                CreateProcess(nameProg, 
                    @"C:\", IntPtr.Zero, IntPtr.Zero, false, 0, IntPtr.Zero, null, ref si, out pi);
            }
            else
            {
                CreateProcess( "C:\\WINDOWS\\SYSTEM32\\" + nameProg + ".exe",
                    @"C:\", IntPtr.Zero, IntPtr.Zero, false, 0, IntPtr.Zero, null, ref si, out pi);
            }
        }
    }
}
