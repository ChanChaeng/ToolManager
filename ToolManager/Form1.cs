using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Octokit;

namespace ToolManager
{
    public partial class Form1 : Form
    {
        public static Form1 form1;

        public Form1()
        {
            InitializeComponent();
            form1 = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Config.Setup();
            checkBox_MM.Checked = ModManager.CheckFile() ? Properties.Settings.Default.MMChecked : false;
            checkBox_LE.Checked = LiveEditor.CheckFile() ? Properties.Settings.Default.LEChecked : false;
            checkBox_CE.Checked = CEngine.CheckFile() ? Properties.Settings.Default.CETChecked : false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.MMChecked = checkBox_MM.Checked;
            Properties.Settings.Default.LEChecked = checkBox_LE.Checked;
            Properties.Settings.Default.CETChecked = checkBox_CE.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBox_MM_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_MM.Checked) return;
            if (!ModManager.CheckFile() && !ModManager.Setup()) checkBox_MM.Checked = false;
        }

        private async void checkBox_LE_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_LE.Checked) return;
            if (!LiveEditor.CanRun)
            {
                groupBox_tools.Enabled = false;
                groupBox_controller.Enabled = false;
                await LiveEditor.AutoUpdate();
            }
        }

        private void checkBox_CE_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox_CE.Checked) return;
            if (!CEngine.CheckFile() && !CEngine.Setup()) checkBox_CE.Checked = false;
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            if (checkBox_MM.Checked) ModManager.Run();
            if (checkBox_LE.Checked) LiveEditor.Run();
            if (checkBox_CE.Checked) CEngine.Run();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            if (!checkBox_MM.Checked && !checkBox_CE.Checked) return;

            if (checkBox_MM.Checked)
            {
                Properties.Settings.Default.MMPath = string.Empty;
                Properties.Settings.Default.MMChecked = false;
                checkBox_MM.Checked = false;
            }

            if (checkBox_CE.Checked)
            {
                Properties.Settings.Default.CETrainerPath = string.Empty;
                Properties.Settings.Default.CETChecked = false;
                checkBox_CE.Checked = false;
            }

            Properties.Settings.Default.Save();
            MessageBox.Show("Complete Reset", "Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LiveEditor.CanRun = LiveEditor.CheckFile();

            if (LiveEditor.CanRun)
            {
                groupBox_tools.Enabled = true;
                groupBox_controller.Enabled = true;
            }
            else checkBox_LE.Checked = false;
        }
    }
}
