using System;
using System.Runtime.InteropServices;

namespace fMain
{
    static class FuncWinApiShutdownReboot
    {
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct TokPriv1Luid
        {
            public int Count;
            public long Luid;
            public int Attr;
        }

        [DllImport("kernel32.dll", ExactSpelling = true)]
        internal static extern IntPtr GetCurrentProcess();

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr
        phtok);

        [DllImport("advapi32.dll", SetLastError = true)]
        internal static extern bool LookupPrivilegeValue(string host, string name,
        ref long pluid);

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall,
        ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]
        internal static extern bool ExitWindowsEx(int flg, int rea);

        internal const int SE_PRIVILEGE_ENABLED = 0x00000002;
        internal const int TOKEN_QUERY = 0x00000008;
        internal const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;
        internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";
        internal const int EWX_LOGOFF = 0x00000000;
        internal const int EWX_SHUTDOWN = 0x00000001;
        internal const int EWX_REBOOT = 0x00000002;
        internal const int EWX_FORCE = 0x00000004;
        internal const int EWX_POWEROFF = 0x00000008;
        internal const int EWX_FORCEIFHUNG = 0x00000010;

        //Это установка процесса в привилеригированный режим. Можно один раз при загрузке использовать
        public static bool setBoss()
        {
            bool ok;
            TokPriv1Luid tp;
            IntPtr hproc = GetCurrentProcess();
            IntPtr htok = IntPtr.Zero;
            ok = OpenProcessToken(hproc, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, ref htok);
            tp.Count = 1;
            tp.Luid = 0;
            tp.Attr = SE_PRIVILEGE_ENABLED;
            ok = LookupPrivilegeValue(null, SE_SHUTDOWN_NAME, ref tp.Luid);
            ok = AdjustTokenPrivileges(htok, false, ref tp, 0, IntPtr.Zero, IntPtr.Zero);
            return ok;
        }

        /// <summary>
        /// Отключить от сети Аналог - войти из системы под другим именим
        /// </summary>
        /// <returns></returns>
        public static bool logoffPC()
        {
            bool ok;
            ok = ExitWindowsEx(EWX_LOGOFF, 0);
            return ok;
        }

        /// <summary>
        /// Завершить работу системы и если возможность выключает компьютер
        /// </summary>
        /// <returns></returns>
        public static bool poweroffPC()
        {
            bool ok;
            ok = ExitWindowsEx(EWX_POWEROFF, 0);
            return ok;
        }

        /// <summary>
        /// Перезагрузка компьютера
        /// </summary>
        /// <returns></returns>
        public static bool rebootPC()
        {
            bool ok;
            ok = ExitWindowsEx(EWX_REBOOT, 0);
            return ok;
        }

        /// <summary>
        /// Закрыть все программы без приглашения сохранить файл
        /// </summary>
        /// <returns></returns>
        public static bool forcePC()
        {
            bool ok;
            ok = ExitWindowsEx(EWX_FORCE, 0);
            return ok;
        }

        /// <summary>
        /// Завершает и выключает питание, записывает все файловые буфера на диск, останавливает все работающие системные процессы
        /// </summary>
        /// <returns></returns>
        public static bool shutdownPC()
        {
            bool ok;
            ok = ExitWindowsEx(EWX_SHUTDOWN, 0);
            return ok;
        }


    }
}
