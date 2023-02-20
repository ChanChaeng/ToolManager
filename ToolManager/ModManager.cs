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
        public static bool CanRun = false;
        
        public static bool CheckFile() => File.Exists(Properties.Settings.Default.ModManagerPath);

        public static void Run()
        {
            if (!CanRun)
            {
                MessageBox.Show("Mod Manager File Not Found", "Error 404", MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Mod Manager (*.exe) | FIFA Mod Manager.exe";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.ModManagerPath = ofd.FileName;
                    Properties.Settings.Default.Save();
                    return;
                }
                else return;
            }

            string path = Properties.Settings.Default.ModManagerPath;
            string fileName = Path.GetFileName(path);
            foreach (var proc in Process.GetProcesses())
            {
                if (!proc.ProcessName.Contains(fileName)) continue;
                if (proc.MainModule.FileName == path) proc.Kill();
            }
            Process.Start(path);
        }

    }
}
