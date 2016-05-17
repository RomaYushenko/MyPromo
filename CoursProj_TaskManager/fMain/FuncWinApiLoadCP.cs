using System.Runtime.InteropServices;
using System.Security;

namespace fMain
{
    class FuncWinApiLoadCP
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool GetSystemTimes(
                    out double lpIdleTime,
                    out double lpKernelTime,
                    out double lpUserTime
                    );

        private double idleTimeOld, kernelTimeOld, userTimeOld;

        public string GetIdleTime()
        {
            double idleTime, kernelTime, userTime;
            GetSystemTimes(out idleTime, out kernelTime, out userTime);

            double usr = userTime - userTimeOld
                , ker = kernelTime - kernelTimeOld
                , idl = idleTime - idleTimeOld;

            double sys = ker + usr;

            string result = ((int)((sys - idl) / sys * 100)).ToString();

            idleTimeOld = idleTime;
            kernelTimeOld = kernelTime;
            userTimeOld = userTime;

            return result;
        }

        private static volatile FuncWinApiLoadCP singleton;
        private static readonly object syncroot = new object();

        public static FuncWinApiLoadCP CreateInstanceCP()
        {
            if (singleton == null)
                lock (syncroot)
                    if (singleton == null)
                        singleton = new FuncWinApiLoadCP();
            return singleton;
        }
    }
}
