using System;
using System.Runtime.InteropServices;
using System.Drawing;
using System.IO;
using System.Windows.Media.Imaging;

namespace fMain
{
    static class GetIcon
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        private class FuncWinApiGetIcon
        {
            public const uint SHGFI_ICON = 0x100;
            public const uint SHGFI_LARGEICON = 0x0;
            public const uint SHGFI_SMALLICON = 0x1;

            [DllImport("shell32.dll")]
            public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);
        }

        public static BitmapImage GetImageBitmapImage(string filename)
        {
            try
            {
                SHFILEINFO shinfo = new SHFILEINFO();
                IntPtr ptr = FuncWinApiGetIcon.SHGetFileInfo(filename, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), FuncWinApiGetIcon.SHGFI_ICON | FuncWinApiGetIcon.SHGFI_SMALLICON);
                Icon icon = Icon.FromHandle(shinfo.hIcon);

                MemoryStream ms = new MemoryStream();
                icon.Save(ms);
                ms.Position = 0;

                BitmapImage bi = new BitmapImage();
                bi.BeginInit();
                bi.StreamSource = ms;
                bi.EndInit();

                return bi;
            }
            catch
            {
                return null;
            }
        }

        public static Icon GetImageIcon(string filename)
        {
            try
            {
                SHFILEINFO shinfo = new SHFILEINFO();
                IntPtr ptr = FuncWinApiGetIcon.SHGetFileInfo(filename, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), FuncWinApiGetIcon.SHGFI_ICON | FuncWinApiGetIcon.SHGFI_SMALLICON);
                Icon icon = Icon.FromHandle(shinfo.hIcon);

                return icon;
            }
            catch
            {
                return null;
            }
        }

        private static Bitmap BitmapImage2Bitmap(BitmapImage bitmapImage)
        {
            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(bitmapImage));
                enc.Save(outStream);
                System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(outStream);
                return new Bitmap(bitmap);
            }
        }
    }
}
