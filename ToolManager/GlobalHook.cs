using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolManager
{
    class GlobalHook
    {
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        public static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern IntPtr CallNextHookEx(IntPtr idHook, int nCode, int wParam, IntPtr lParam);

        [DllImport("kernel32.dll")]
        static extern IntPtr LoadLibrary(string lpFileName);

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("User32", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string IpClassName, string IpWindowName);

        [DllImport("user32.dll")]
        public static extern void keybd_event(uint vk, uint scan, uint flags, uint extraInfo);

        [DllImport("user32.dll")]
        private static extern uint MapVirtualKey(int wCode, int wMapType);

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;
        const int WM_KEYUP = 0x101;

        private static LowLevelKeyboardProc _proc = hookProc;

        private static IntPtr hhook = IntPtr.Zero;

        private static bool CheckFIFA()
        {
            return FindWindow(null, "FIFA 23") == GetForegroundWindow();
        }

        private static IntPtr hookProc(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && wParam == (IntPtr)WM_KEYDOWN && CheckFIFA())
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if (vkCode == 46) // del = 46
                {
                    keybd_event(0, MapVirtualKey((int)Keys.NumPad4, 0), 0x00, 0);
                }
                if (vkCode == 34) // PgDn = 34
                {
                    keybd_event(0, MapVirtualKey((int)Keys.NumPad6, 0), 0x00, 0);
                }
            }

            if (code >= 0 && wParam == (IntPtr)WM_KEYUP && CheckFIFA())
            {
                int vkCode = Marshal.ReadInt32(lParam);
                if (vkCode == 46) // del = 46
                {
                    keybd_event(0, MapVirtualKey((int)Keys.NumPad4, 0), 0x02, 0);
                }
                if (vkCode == 34) // PgDn = 34
                {
                    keybd_event(0, MapVirtualKey((int)Keys.NumPad6, 0), 0x02, 0);
                }
            }

            return CallNextHookEx(hhook, code, (int)wParam, lParam);
        }

        public static void SetHook()
        {
            IntPtr hInstance = LoadLibrary("User32");
            hhook = SetWindowsHookEx(WH_KEYBOARD_LL, _proc, hInstance, 0);
        }

        public static void UnHook()
        {
            UnhookWindowsHookEx(hhook);
        }
        //앱 종료시 UnHook은 필수적으로 해주는게 좋다.
    }
}
