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
    class CEngine
    {
        public static bool CheckFile() => File.Exists(Properties.Settings.Default.CETrainerPath);

        public static bool Setup()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CETRAINER FILE (*.CETRAINER) | *.CETRAINER";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.CETrainerPath = ofd.FileName;
                Properties.Settings.Default.Save();
                return true;
            }

            return false;
        }

        public static void Run()
        {
            foreach (var proc in Process.GetProcesses())
                if (proc.ProcessName.Contains("cheatengine")) proc.Kill();

            Process.Start(Properties.Settings.Default.CETrainerPath);
        }

    }
}
