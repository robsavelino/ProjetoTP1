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
            this.btnReturn.Location = new System.Drawing.Point(507, 395);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(125, 40);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.Text = "Voltar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(651, 395);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnGoToUsers
            // 
            this.btnGoToUsers.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoToUsers.Location = new System.Drawing.Point(114, 147);
            this.btnGoToUsers.Name = "btnGoToUsers";
            this.btnGoToUsers.Size = new System.Drawing.Size(200, 80);
            this.btnGoToUsers.TabIndex = 2;
            this.btnGoToUsers.Text = "Users";
            this.btnGoToUsers.UseVisualStyleBackColor = true;
            this.btnGoToUsers.Click += new System.EventHandler(this.btnGoToUsers_Click);
            // 
            // btnGoToStore
            // 
            this.btnGoToStore.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGoToStore.Location = new System.Drawing.Point(498, 147);
            this.btnGoToStore.Name = "btnGoToStore";
            this.btnGoToStore.Size = new System.Drawing.Size(200, 80);
            this.btnGoToStore.TabIndex = 3;
            this.btnGoToStore.Text = "Store";
            this.btnGoToStore.UseVisualStyleBackColor = true;
            this.btnGoToStore.Click += new System.EventHandler(this.btnGoToStore_Click);
            // 
            // ptb01
            // 
            this.ptb01.Image = ((System.Drawing.Image)(resources.GetObject("ptb01.Image")));
            this.ptb01.Location = new System.Drawing.Point(204, 22);
            this.ptb01.Name = "ptb01";
            this.ptb01.Size = new System.Drawing.Size(400, 400);
            this.ptb01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb01.TabIndex = 4;
            this.ptb01.TabStop = false;
            this.ptb01.Click += new System.EventHandler(this.ptb01_Click);
            // 
            // FrmProjectStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoToStore);
            this.Controls.Add(this.btnGoToUsers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.ptb01);
            this.Name = "FrmProjectStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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