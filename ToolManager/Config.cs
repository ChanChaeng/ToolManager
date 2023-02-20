using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ToolManager
{
    class Config
    {
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int Y, int cx, int cy, SetWindowPosFlag wFlags);

        public static string Creator = "ChanChaeng";
        public static string CurrentPath = Application.StartupPath;
        public static string ToolsPath = Path.Combine(CurrentPath, "Tools");

        public static void Setup()
        {
            if (Directory.Exists(ToolsPath)) return;
            Directory.CreateDirectory(ToolsPath);
        }

        [Flags]
        public enum SetWindowPosFlag : uint
        {
            /// <summary>
            /// SWP_ASYNCWINDOWPOS
            /// </summary>
            SWP_ASYNCWINDOWPOS = 0x4000,

            /// <summary>
            /// SWP_DEFERERASE
            /// </summary>
            SWP_DEFERERASE = 0x2000,

            /// <summary>
            /// SWP_DRAWFRAME
            /// </summary>
            SWP_DRAWFRAME = 0x0020,

            /// <summary>
            /// SWP_FRAMECHANGED
            /// </summary>
            SWP_FRAMECHANGED = 0x0020,

            /// <summary>
            /// SWP_HIDEWINDOW
            /// </summary>
            SWP_HIDEWINDOW = 0x0080,

            /// <summary>
            /// SWP_NOACTIVATE
            /// </summary>
            SWP_NOACTIVATE = 0x0010,

            /// <summary>
            /// SWP_NOCOPYBITS
            /// </summary>
            SWP_NOCOPYBITS = 0x0100,

            /// <summary>
            /// SWP_NOMOVE
            /// </summary>
            SWP_NOMOVE = 0x0002,

            /// <summary>
            /// SWP_NOOWNERZORDER
            /// </summary>
            SWP_NOOWNERZORDER = 0x0200,

            /// <summary>
            /// SWP_NOREDRAW
            /// </summary>
            SWP_NOREDRAW = 0x0008,

            /// <summary>
            /// SWP_NOREPOSITION
            /// </summary>
            SWP_NOREPOSITION = 0x0200,

            /// <summary>
            /// SWP_NOSENDCHANGING
            /// </summary>
            SWP_NOSENDCHANGING = 0x0400,

            /// <summary>
            /// SWP_NOSIZE
            /// </summary>
            SWP_NOSIZE = 0x0001,

            /// <summary>
            /// SWP_NOZORDER
            /// </summary>
            SWP_NOZORDER = 0x0004,

            /// <summary>
            /// SWP_SHOWWINDOW
            /// </summary>
            SWP_SHOWWINDOW = 0x0040,
        }
    }
}
