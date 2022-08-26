namespace FrmProjeto.Menu
{
    partial class FrmAboutUs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAboutUs));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ptb01 = new System.Windows.Forms.PictureBox();
            this.lbl_PT = new System.Windows.Forms.Label();
            this.lbl_CopyRightPT = new System.Windows.Forms.Label();
            this.lbl_EN = new System.Windows.Forms.Label();
            this.btn_EN = new System.Windows.Forms.Button();
            this.btn_PT = new System.Windows.Forms.Button();
            this.lbl_CopyRightEN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb01)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.Color.Gold;
            this.btnReturn.Location = new System.Drawing.Point(545, 463);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(125, 40);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Back";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Gold;
            this.btnClose.Location = new System.Drawing.Point(687, 463);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ptb01
            // 
            this.ptb01.Image = ((System.Drawing.Image)(resources.GetObject("ptb01.Image")));
            this.ptb01.Location = new System.Drawing.Point(12, 40);
            this.ptb01.Name = "ptb01";
            this.ptb01.Size = new System.Drawing.Size(180, 180);
            this.ptb01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb01.TabIndex = 2;
            this.ptb01.TabStop = false;
            // 
            // lbl_PT
            // 
            this.lbl_PT.AutoSize = true;
            this.lbl_PT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_PT.ForeColor = System.Drawing.Color.White;
            this.lbl_PT.Location = new System.Drawing.Point(210, 40);
            this.lbl_PT.Name = "lbl_PT";
            this.lbl_PT.Size = new System.Drawing.Size(592, 391);
            this.lbl_PT.TabIndex = 3;
            this.lbl_PT.Text = resources.GetString("lbl_PT.Text");
            this.lbl_PT.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_CopyRightPT
            // 
            this.lbl_CopyRightPT.AutoSize = true;
            this.lbl_CopyRightPT.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_CopyRightPT.Location = new System.Drawing.Point(268, 488);
            this.lbl_CopyRightPT.Name = "lbl_CopyRightPT";
            this.lbl_CopyRightPT.Size = new System.Drawing.Size(223, 15);
            this.lbl_CopyRightPT.TabIndex = 4;
            this.lbl_CopyRightPT.Text = "Todos os direitos reservados © Let\'s Play ";
            // 
            // lbl_EN
            // 
            this.lbl_EN.AutoSize = true;
            this.lbl_EN.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_EN.ForeColor = System.Drawing.Color.White;
            this.lbl_EN.Location = new System.Drawing.Point(210, 40);
            this.lbl_EN.Name = "lbl_EN";
            this.lbl_EN.Size = new System.Drawing.Size(491, 391);
            this.lbl_EN.TabIndex = 5;
            this.lbl_EN.Text = resources.GetString("lbl_EN.Text");
            this.lbl_EN.Click += new System.EventHandler(this.lbl_EN_Click);
            // 
            // btn_EN
            // 
            this.btn_EN.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_EN.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_EN.ForeColor = System.Drawing.Color.Gold;
            this.btn_EN.Location = new System.Drawing.Point(45, 355);
            this.btn_EN.Name = "btn_EN";
            this.btn_EN.Size = new System.Drawing.Size(125, 40);
            this.btn_EN.TabIndex = 6;
            this.btn_EN.Text = "English";
            this.btn_EN.UseVisualStyleBackColor = false;
            this.btn_EN.Click += new System.EventHandler(this.btn_EN_Click);
            // 
            // btn_PT
            // 
            this.btn_PT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_PT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_PT.ForeColor = System.Drawing.Color.Gold;
            this.btn_PT.Location = new System.Drawing.Point(45, 282);
            this.btn_PT.Name = "btn_PT";
            this.btn_PT.Size = new System.Drawing.Size(125, 40);
            this.btn_PT.TabIndex = 7;
            this.btn_PT.Text = "Português";
            this.btn_PT.UseVisualStyleBackColor = false;
            this.btn_PT.Click += new System.EventHandler(this.btn_PT_Click);
            // 
            // lbl_CopyRightEN
            // 
            this.lbl_CopyRightEN.AutoSize = true;
            this.lbl_CopyRightEN.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_CopyRightEN.Location = new System.Drawing.Point(268, 488);
            this.lbl_CopyRightEN.Name = "lbl_CopyRightEN";
            this.lbl_CopyRightEN.Size = new System.Drawing.Size(170, 15);
            this.lbl_CopyRightEN.TabIndex = 8;
            this.lbl_CopyRightEN.Text = "All rights reserved © Let\'s Play ";
            // 
            // FrmAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(824, 515);
            this.Controls.Add(this.lbl_CopyRightEN);
            this.Controls.Add(this.btn_PT);
            this.Controls.Add(this.btn_EN);
            this.Controls.Add(this.lbl_EN);
            this.Controls.Add(this.lbl_CopyRightPT);
            this.Controls.Add(this.lbl_PT);
            this.Controls.Add(this.ptb01);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReturn);
            this.Name = "FrmAboutUs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.Load += new System.EventHandler(this.FrmAboutUs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnReturn;
        private Button btnClose;
        private PictureBox ptb01;
        private Label lbl_PT;
        private Label lbl_CopyRightPT;
        private Label lbl_EN;
        private Button btn_EN;
        private Button btn_PT;
        private Label lbl_CopyRightEN;
    }
}