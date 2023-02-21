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
        public static string Creator = "ChanChaeng";
        public static string CurrentPath = Application.StartupPath;
        public static string ToolsPath = Path.Combine(CurrentPath, "Tools");

        public static void Setup()
        {
            if (Directory.Exists(ToolsPath)) return;
            Directory.CreateDirectory(ToolsPath);
        }
    }
}
