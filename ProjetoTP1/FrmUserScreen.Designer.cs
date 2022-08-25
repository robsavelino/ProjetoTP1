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
            this.btnFriends.Location = new System.Drawing.Point(523, 250);
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
            // FrmUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFriends);
            this.Controls.Add(this.btnGames);
            this.Name = "FrmUserScreen";
            this.Text = "FrmUserScreen";
            this.Load += new System.EventHandler(this.FrmUserScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BtnGames;
        private Button BtnFriends;
        private PictureBox pictureBox1;
        private Button btnGames;
        private Button btnFriends;
    }
}