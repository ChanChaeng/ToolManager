
namespace ToolManager
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox_tools = new System.Windows.Forms.GroupBox();
            this.checkBox_CE = new System.Windows.Forms.CheckBox();
            this.checkBox_LE = new System.Windows.Forms.CheckBox();
            this.checkBox_MM = new System.Windows.Forms.CheckBox();
            this.groupBox_controller = new System.Windows.Forms.GroupBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_run = new System.Windows.Forms.Button();
            this.groupBox_tools.SuspendLayout();
            this.groupBox_controller.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox_tools
            // 
            this.groupBox_tools.Controls.Add(this.checkBox_CE);
            this.groupBox_tools.Controls.Add(this.checkBox_LE);
            this.groupBox_tools.Controls.Add(this.checkBox_MM);
            this.groupBox_tools.Enabled = false;
            this.groupBox_tools.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_tools.Location = new System.Drawing.Point(12, 12);
            this.groupBox_tools.Name = "groupBox_tools";
            this.groupBox_tools.Size = new System.Drawing.Size(353, 60);
            this.groupBox_tools.TabIndex = 4;
            this.groupBox_tools.TabStop = false;
            this.groupBox_tools.Text = "Tools";
            // 
            // checkBox_CE
            // 
            this.checkBox_CE.AutoSize = true;
            this.checkBox_CE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_CE.Location = new System.Drawing.Point(236, 26);
            this.checkBox_CE.Name = "checkBox_CE";
            this.checkBox_CE.Size = new System.Drawing.Size(114, 23);
            this.checkBox_CE.TabIndex = 0;
            this.checkBox_CE.Text = "Cheat Engine";
            this.checkBox_CE.UseVisualStyleBackColor = true;
            this.checkBox_CE.CheckedChanged += new System.EventHandler(this.checkBox_CE_CheckedChanged);
            // 
            // checkBox_LE
            // 
            this.checkBox_LE.AutoSize = true;
            this.checkBox_LE.Enabled = false;
            this.checkBox_LE.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_LE.Location = new System.Drawing.Point(134, 26);
            this.checkBox_LE.Name = "checkBox_LE";
            this.checkBox_LE.Size = new System.Drawing.Size(96, 23);
            this.checkBox_LE.TabIndex = 0;
            this.checkBox_LE.Text = "Live Editor";
            this.checkBox_LE.UseVisualStyleBackColor = true;
            this.checkBox_LE.CheckedChanged += new System.EventHandler(this.checkBox_LE_CheckedChanged);
            // 
            // checkBox_MM
            // 
            this.checkBox_MM.AutoSize = true;
            this.checkBox_MM.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_MM.Location = new System.Drawing.Point(9, 26);
            this.checkBox_MM.Name = "checkBox_MM";
            this.checkBox_MM.Size = new System.Drawing.Size(119, 23);
            this.checkBox_MM.TabIndex = 0;
            this.checkBox_MM.Text = "Mod Manager";
            this.checkBox_MM.UseVisualStyleBackColor = true;
            this.checkBox_MM.CheckedChanged += new System.EventHandler(this.checkBox_MM_CheckedChanged);
            // 
            // groupBox_controller
            // 
            this.groupBox_controller.Controls.Add(this.button_reset);
            this.groupBox_controller.Controls.Add(this.button_run);
            this.groupBox_controller.Enabled = false;
            this.groupBox_controller.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_controller.Location = new System.Drawing.Point(12, 78);
            this.groupBox_controller.Name = "groupBox_controller";
            this.groupBox_controller.Size = new System.Drawing.Size(353, 86);
            this.groupBox_controller.TabIndex = 5;
            this.groupBox_controller.TabStop = false;
            this.groupBox_controller.Text = "Controller";
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(179, 26);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(168, 50);
            this.button_reset.TabIndex = 0;
            this.button_reset.Text = "RESET";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(6, 26);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(168, 50);
            this.button_run.TabIndex = 0;
            this.button_run.Text = "RUN";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 175);
            this.Controls.Add(this.groupBox_controller);
            this.Controls.Add(this.groupBox_tools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolManager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_tools.ResumeLayout(false);
            this.groupBox_tools.PerformLayout();
            this.groupBox_controller.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox_CE;
        private System.Windows.Forms.CheckBox checkBox_MM;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_run;
        public System.Windows.Forms.CheckBox checkBox_LE;
        public System.Windows.Forms.GroupBox groupBox_tools;
        public System.Windows.Forms.GroupBox groupBox_controller;
        public System.Windows.Forms.Timer timer1;
    }
}

