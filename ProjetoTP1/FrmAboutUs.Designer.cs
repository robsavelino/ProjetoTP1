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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_CopyRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb01)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(545, 463);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(125, 40);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Voltar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(687, 463);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(210, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 391);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_CopyRight
            // 
            this.lbl_CopyRight.AutoSize = true;
            this.lbl_CopyRight.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_CopyRight.Location = new System.Drawing.Point(268, 488);
            this.lbl_CopyRight.Name = "lbl_CopyRight";
            this.lbl_CopyRight.Size = new System.Drawing.Size(223, 15);
            this.lbl_CopyRight.TabIndex = 4;
            this.lbl_CopyRight.Text = "Todos os direitos reservados © Let\'s Play ";
            // 
            // FrmAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(824, 515);
            this.Controls.Add(this.lbl_CopyRight);
            this.Controls.Add(this.label1);
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
        private Label label1;
        private Label lbl_CopyRight;
    }
}