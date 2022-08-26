namespace FrmProjeto
{
    partial class FrmProjectStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjectStart));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnGoToUsers = new System.Windows.Forms.Button();
            this.btnGoToStore = new System.Windows.Forms.Button();
            this.ptb01 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb01)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(405, 375);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 43);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Voltar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(557, 375);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 43);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGoToUsers
            // 
            this.btnGoToUsers.Location = new System.Drawing.Point(46, 59);
            this.btnGoToUsers.Name = "btnGoToUsers";
            this.btnGoToUsers.Size = new System.Drawing.Size(143, 40);
            this.btnGoToUsers.TabIndex = 2;
            this.btnGoToUsers.Text = "Usuarios";
            this.btnGoToUsers.UseVisualStyleBackColor = true;
            this.btnGoToUsers.Click += new System.EventHandler(this.btnGoToUsers_Click);
            // 
            // btnGoToStore
            // 
            this.btnGoToStore.Location = new System.Drawing.Point(46, 141);
            this.btnGoToStore.Name = "btnGoToStore";
            this.btnGoToStore.Size = new System.Drawing.Size(143, 41);
            this.btnGoToStore.TabIndex = 3;
            this.btnGoToStore.Text = "Loja";
            this.btnGoToStore.UseVisualStyleBackColor = true;
            this.btnGoToStore.Click += new System.EventHandler(this.btnGoToStore_Click);
            // 
            // ptb01
            // 
            this.ptb01.Image = ((System.Drawing.Image)(resources.GetObject("ptb01.Image")));
            this.ptb01.Location = new System.Drawing.Point(437, 59);
            this.ptb01.Name = "ptb01";
            this.ptb01.Size = new System.Drawing.Size(222, 197);
            this.ptb01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb01.TabIndex = 4;
            this.ptb01.TabStop = false;
            // 
            // FrmProjectStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ptb01);
            this.Controls.Add(this.btnGoToStore);
            this.Controls.Add(this.btnGoToUsers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReturn);
            this.Name = "FrmProjectStart";
            this.Text = "FrmProjectStart";
            this.Load += new System.EventHandler(this.FrmProjectStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb01)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnReturn;
        private Button btnClose;
        private Button btnGoToUsers;
        private Button btnGoToStore;
        private PictureBox ptb01;
    }
}