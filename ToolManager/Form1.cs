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

        private async void Form1_Load(object sender, EventArgs e)
        {
            Config.Setup();
            await LiveEditor.AutoUpdate();
        }

        private void button_mm_Click(object sender, EventArgs e)
        {
            ModManager.Run();
        }

        private void button_le_Click(object sender, EventArgs e)
        {
            LiveEditor.Run();
        }

        private void button_ce_Click(object sender, EventArgs e)
        {
            CEngine.Run();
        }

        private void button_mmle_Click(object sender, EventArgs e)
        {
            ModManager.Run();
            LiveEditor.Run();
        }

        private void button_lece_Click(object sender, EventArgs e)
        {
            LiveEditor.Run();
            CEngine.Run();
        }

        private void button_mmlece_Click(object sender, EventArgs e)
        {
            ModManager.Run();
            LiveEditor.Run();
            CEngine.Run();
        }

        private void button_mmr_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ModManagerPath = string.Empty;
            Properties.Settings.Default.Save();
        }

        private void button_cer_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CETrainerPath = string.Empty;
            Properties.Settings.Default.Save();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.button_le.Enabled = LiveEditor.CanRun;

            ModManager.CanRun = ModManager.CheckFile();
            CEngine.CanRun = CEngine.CheckFile();

            this.button_mmle.Enabled = ModManager.CanRun && LiveEditor.CanRun;
            this.button_lece.Enabled = LiveEditor.CanRun && CEngine.CanRun;
            this.button_mmlece.Enabled = ModManager.CanRun && LiveEditor.CanRun && CEngine.CanRun;
        }
    }
}
