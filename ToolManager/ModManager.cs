using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolManager
{
    class ModManager
    {
        public static bool CheckFile() => File.Exists(Properties.Settings.Default.MMPath);

        public static bool Setup()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Mod Manager (*.exe) | FIFA Mod Manager.exe";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.MMPath = ofd.FileName;
                Properties.Settings.Default.Save();
                return true;
            }

            return false;
        }

        public static void Run()
        {
            foreach (var proc in Process.GetProcesses())
                if (proc.ProcessName.Contains("Mod Manager") && 
                    proc.MainModule.FileName == Properties.Settings.Default.MMPath) return;

            Process.Start(Properties.Settings.Default.MMPath);
        }

    }
}
