using Octokit;
using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolManager
{
    class LiveEditor
    {
        public static bool CanRun = false;
        public static string Creator = "xAranaktu";
        public static string ProjectName = "FIFA-23-Live-Editor";

        private static string zipPath = Path.Combine(Config.ToolsPath, "LiveEditor.zip");
        private static string dirName;
        private static string dirPath;

        public static bool CheckFile()
        {
            foreach (var dir in Directory.GetDirectories(Config.ToolsPath))
            {
                string tmpPathName = Path.GetFileName(dir);
                if (tmpPathName.Contains("Live Editor") && tmpPathName.Contains(Properties.Settings.Default.LEVersion)) return true;
            }

            Form1.form1.checkBox_LE.Checked = false;
            return false;
        }

        public static void Run()
        {
            foreach (var proc in Process.GetProcesses())
                if (proc.ProcessName.Contains("Launcher") && 
                    proc.MainModule.FileName == Properties.Settings.Default.LELauncherPath) return;

            Process.Start(Properties.Settings.Default.LELauncherPath);
        }

        public static async Task AutoUpdate()
        {
            Config.Setup();
            var client = new GitHubClient(new ProductHeaderValue(Config.Creator));
            var releases = await client.Repository.Release.GetAll(Creator, ProjectName);
            Properties.Settings.Default.LEVersion = releases[0].TagName;
            Properties.Settings.Default.Save();

            foreach (var dir in Directory.GetDirectories(Config.ToolsPath))
            {
                string tmpPathName = Path.GetFileName(dir);
                if (tmpPathName.Contains("Live Editor") && tmpPathName.Contains(releases[0].TagName))
                {
                    Form1.form1.checkBox_LE.Enabled = true;
                    Form1.form1.groupBox_tools.Enabled = true;
                    Form1.form1.groupBox_controller.Enabled = true;
                    Form1.form1.checkBox_LE.Checked = Properties.Settings.Default.LEChecked;
                    return;
                }
            }

            Form1.form1.checkBox_LE.Checked = false;
            Form1.form1.checkBox_LE.Enabled = false;
            Form1.form1.groupBox_tools.Enabled = false;
            Form1.form1.groupBox_controller.Enabled = false;
            Directory.Delete(Config.ToolsPath, true);
            Config.Setup();
            dirName = releases[0].Name;
            dirPath = Path.Combine(Config.ToolsPath, dirName);
            string downloadURL = string.Empty;
            foreach (var asset in releases[0].Assets)
            {
                if (asset.Name.Contains(".zip")) downloadURL = asset.BrowserDownloadUrl;
            }

            WebClient webClient = new WebClient();
            webClient.DownloadFileCompleted += WebClient_DownloadFileCompleted;
            webClient.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36 Edg/110.0.1587.49");
            await webClient.DownloadFileTaskAsync(new Uri(downloadURL), zipPath);
        }

        private static void WebClient_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            ZipFile.ExtractToDirectory(zipPath, dirPath);
            File.Delete(zipPath);
            Properties.Settings.Default.LELauncherPath = Path.Combine(dirPath, "Launcher.exe");
            Properties.Settings.Default.Save();
            Form1.form1.checkBox_LE.Enabled = true;
            Form1.form1.groupBox_tools.Enabled = true;
            Form1.form1.groupBox_controller.Enabled = true;
            Form1.form1.checkBox_LE.Checked = Properties.Settings.Default.LEChecked;
            MessageBox.Show("Complete Update", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Form1.form1.timer1.Start();
        }
    }
}
