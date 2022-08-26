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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserScreen));
            this.btnGames = new System.Windows.Forms.Button();
            this.btnFriends = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lbl_ExibitionName = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Wallet = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.txbInput = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.clmGameName = new System.Windows.Forms.ColumnHeader();
            this.clmGenre = new System.Windows.Forms.ColumnHeader();
            this.clmPublisher = new System.Windows.Forms.ColumnHeader();
            this.listView2 = new System.Windows.Forms.ListView();
            this.clmUsername = new System.Windows.Forms.ColumnHeader();
            this.clmExibitionName = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGames
            // 
            this.btnGames.Location = new System.Drawing.Point(1056, 115);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(170, 44);
            this.btnGames.TabIndex = 0;
            this.btnGames.Text = "Jogos";
            this.btnGames.UseVisualStyleBackColor = true;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnFriends
            // 
            this.btnFriends.Location = new System.Drawing.Point(1056, 191);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(170, 44);
            this.btnFriends.TabIndex = 1;
            this.btnFriends.Text = "Amigos";
            this.btnFriends.UseVisualStyleBackColor = true;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Projeto.Properties.Resources.DefaultUser;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = global::Projeto.Properties.Resources.DefaultUser;
            this.pictureBox1.Location = new System.Drawing.Point(50, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1124, 365);
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
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(1056, 33);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(60, 15);
            this.lblInput.TabIndex = 8;
            this.lblInput.Text = "Username";
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(1056, 51);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(170, 23);
            this.txbInput.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmGameName,
            this.clmGenre,
            this.clmPublisher});
            this.listView1.Location = new System.Drawing.Point(219, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(704, 463);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // clmGameName
            // 
            this.clmGameName.Text = "Game";
            this.clmGameName.Width = 200;
            // 
            // clmGenre
            // 
            this.clmGenre.Text = "Genre";
            this.clmGenre.Width = 200;
            // 
            // clmPublisher
            // 
            this.clmPublisher.Text = "Publisher";
            this.clmPublisher.Width = 300;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmUsername,
            this.clmExibitionName});
            this.listView2.Location = new System.Drawing.Point(219, 51);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(704, 463);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // clmUsername
            // 
            this.clmUsername.Text = "Username";
            this.clmUsername.Width = 200;
            // 
            // clmExibitionName
            // 
            this.clmExibitionName.Text = "Exibition Name";
            this.clmExibitionName.Width = 200;
            // 
            // FrmUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1238, 642);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txbInput);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lbl_Wallet);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_ExibitionName);
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
        private Button btnReturn;
        private Label lbl_ExibitionName;
        private Label lbl_UserName;
        private Label lbl_Wallet;
        private Label lblInput;
        private TextBox txbInput;
        private ListView listView1;
        private ColumnHeader clmGameName;
        private ColumnHeader clmGenre;
        private ColumnHeader clmPublisher;
        private ListView listView2;
        private ColumnHeader clmUsername;
        private ColumnHeader clmExibitionName;
    }
}