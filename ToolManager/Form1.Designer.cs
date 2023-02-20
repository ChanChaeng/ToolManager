
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
            this.button_mm = new System.Windows.Forms.Button();
            this.button_le = new System.Windows.Forms.Button();
            this.button_ce = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_mmle = new System.Windows.Forms.Button();
            this.button_mmlece = new System.Windows.Forms.Button();
            this.button_lece = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_mmr = new System.Windows.Forms.Button();
            this.button_cer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_mm
            // 
            this.button_mm.Location = new System.Drawing.Point(6, 20);
            this.button_mm.Name = "button_mm";
            this.button_mm.Size = new System.Drawing.Size(160, 60);
            this.button_mm.TabIndex = 0;
            this.button_mm.Text = "Mod Manager";
            this.button_mm.UseVisualStyleBackColor = true;
            this.button_mm.Click += new System.EventHandler(this.button_mm_Click);
            // 
            // button_le
            // 
            this.button_le.Enabled = false;
            this.button_le.Location = new System.Drawing.Point(6, 86);
            this.button_le.Name = "button_le";
            this.button_le.Size = new System.Drawing.Size(160, 60);
            this.button_le.TabIndex = 1;
            this.button_le.Text = "Live Editor";
            this.button_le.UseVisualStyleBackColor = true;
            this.button_le.Click += new System.EventHandler(this.button_le_Click);
            // 
            // button_ce
            // 
            this.button_ce.Location = new System.Drawing.Point(6, 152);
            this.button_ce.Name = "button_ce";
            this.button_ce.Size = new System.Drawing.Size(160, 60);
            this.button_ce.TabIndex = 2;
            this.button_ce.Text = "Cheat Engine";
            this.button_ce.UseVisualStyleBackColor = true;
            this.button_ce.Click += new System.EventHandler(this.button_ce_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_mm);
            this.groupBox1.Controls.Add(this.button_le);
            this.groupBox1.Controls.Add(this.button_ce);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tools";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_mmle);
            this.groupBox2.Controls.Add(this.button_mmlece);
            this.groupBox2.Controls.Add(this.button_lece);
            this.groupBox2.Location = new System.Drawing.Point(194, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Combine";
            // 
            // button_mmle
            // 
            this.button_mmle.Enabled = false;
            this.button_mmle.Location = new System.Drawing.Point(6, 20);
            this.button_mmle.Name = "button_mmle";
            this.button_mmle.Size = new System.Drawing.Size(160, 60);
            this.button_mmle.TabIndex = 0;
            this.button_mmle.Text = "MM + LE";
            this.button_mmle.UseVisualStyleBackColor = true;
            this.button_mmle.Click += new System.EventHandler(this.button_mmle_Click);
            // 
            // button_mmlece
            // 
            this.button_mmlece.Enabled = false;
            this.button_mmlece.Location = new System.Drawing.Point(6, 152);
            this.button_mmlece.Name = "button_mmlece";
            this.button_mmlece.Size = new System.Drawing.Size(160, 60);
            this.button_mmlece.TabIndex = 2;
            this.button_mmlece.Text = "MM + LE + CE";
            this.button_mmlece.UseVisualStyleBackColor = true;
            this.button_mmlece.Click += new System.EventHandler(this.button_mmlece_Click);
            // 
            // button_lece
            // 
            this.button_lece.Enabled = false;
            this.button_lece.Location = new System.Drawing.Point(6, 86);
            this.button_lece.Name = "button_lece";
            this.button_lece.Size = new System.Drawing.Size(160, 60);
            this.button_lece.TabIndex = 1;
            this.button_lece.Text = "LE + CE";
            this.button_lece.UseVisualStyleBackColor = true;
            this.button_lece.Click += new System.EventHandler(this.button_lece_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_cer);
            this.groupBox3.Controls.Add(this.button_mmr);
            this.groupBox3.Location = new System.Drawing.Point(12, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 74);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reset";
            // 
            // button_mmr
            // 
            this.button_mmr.Location = new System.Drawing.Point(6, 20);
            this.button_mmr.Name = "button_mmr";
            this.button_mmr.Size = new System.Drawing.Size(160, 46);
            this.button_mmr.TabIndex = 0;
            this.button_mmr.Text = "Mod Manager";
            this.button_mmr.UseVisualStyleBackColor = true;
            this.button_mmr.Click += new System.EventHandler(this.button_mmr_Click);
            // 
            // button_cer
            // 
            this.button_cer.Location = new System.Drawing.Point(188, 20);
            this.button_cer.Name = "button_cer";
            this.button_cer.Size = new System.Drawing.Size(160, 46);
            this.button_cer.TabIndex = 0;
            this.button_cer.Text = "Cheat Engine";
            this.button_cer.UseVisualStyleBackColor = true;
            this.button_cer.Click += new System.EventHandler(this.button_cer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 325);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToolManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_mm;
        private System.Windows.Forms.Button button_le;
        private System.Windows.Forms.Button button_ce;
        private System.Windows.Forms.Button button_mmle;
        private System.Windows.Forms.Button button_mmlece;
        private System.Windows.Forms.Button button_lece;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_cer;
        private System.Windows.Forms.Button button_mmr;
    }
}

