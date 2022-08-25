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
            this.BtnGames = new System.Windows.Forms.Button();
            this.BtnFriends = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGames
            // 
            this.BtnGames.Location = new System.Drawing.Point(523, 115);
            this.BtnGames.Name = "BtnGames";
            this.BtnGames.Size = new System.Drawing.Size(170, 44);
            this.BtnGames.TabIndex = 0;
            this.BtnGames.Text = "Jogos";
            this.BtnGames.UseVisualStyleBackColor = true;
            // 
            // BtnFriends
            // 
            this.BtnFriends.Location = new System.Drawing.Point(523, 250);
            this.BtnFriends.Name = "BtnFriends";
            this.BtnFriends.Size = new System.Drawing.Size(170, 44);
            this.BtnFriends.TabIndex = 1;
            this.BtnFriends.Text = "Amigos";
            this.BtnFriends.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.BtnFriends);
            this.Controls.Add(this.BtnGames);
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
    }
}