namespace Projeto
{
    partial class FrmUserScreen
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
            this.btnGames = new System.Windows.Forms.Button();
            this.btnFriends = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lbl_ExibitionName = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Wallet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGames
            // 
            this.btnGames.Location = new System.Drawing.Point(523, 115);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(170, 44);
            this.btnGames.TabIndex = 0;
            this.btnGames.Text = "Jogos";
            this.btnGames.UseVisualStyleBackColor = true;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnFriends
            // 
            this.btnFriends.Location = new System.Drawing.Point(523, 217);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(170, 44);
            this.btnFriends.TabIndex = 1;
            this.btnFriends.Text = "Amigos";
            this.btnFriends.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Projeto.Properties.Resources.DefaultUser;
            this.pictureBox1.InitialImage = global::Projeto.Properties.Resources.DefaultUser;
            this.pictureBox1.Location = new System.Drawing.Point(49, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(591, 343);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 43);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Sair";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(439, 343);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 43);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Voltar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lbl_ExibitionName
            // 
            this.lbl_ExibitionName.AutoSize = true;
            this.lbl_ExibitionName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ExibitionName.Location = new System.Drawing.Point(49, 198);
            this.lbl_ExibitionName.Name = "lbl_ExibitionName";
            this.lbl_ExibitionName.Size = new System.Drawing.Size(164, 25);
            this.lbl_ExibitionName.TabIndex = 5;
            this.lbl_ExibitionName.Text = "Nome de exibição";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_UserName.Location = new System.Drawing.Point(49, 236);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(110, 17);
            this.lbl_UserName.TabIndex = 6;
            this.lbl_UserName.Text = "Nome de usuário";
            // 
            // lbl_Wallet
            // 
            this.lbl_Wallet.AutoSize = true;
            this.lbl_Wallet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Wallet.Location = new System.Drawing.Point(50, 266);
            this.lbl_Wallet.Name = "lbl_Wallet";
            this.lbl_Wallet.Size = new System.Drawing.Size(54, 17);
            this.lbl_Wallet.TabIndex = 7;
            this.lbl_Wallet.Text = "Carteira";
            // 
            // FrmUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Wallet);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_ExibitionName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFriends);
            this.Controls.Add(this.btnGames);
            this.Name = "FrmUserScreen";
            this.Text = "FrmUserScreen";
            this.Load += new System.EventHandler(this.FrmUserScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnGames;
        private Button BtnFriends;
        private PictureBox pictureBox1;
        private Button btnGames;
        private Button btnFriends;
        private Button btnClose;
        private Button btnReturn;
        private Label lbl_ExibitionName;
        private Label lbl_UserName;
        private Label lbl_Wallet;
    }
}