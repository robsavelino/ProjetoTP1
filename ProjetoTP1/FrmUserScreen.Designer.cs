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
            this.btnAddFriend = new System.Windows.Forms.Button();
            this.txbFriendInput = new System.Windows.Forms.TextBox();
            this.lblFriendInput = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnShowAllUsers = new System.Windows.Forms.Button();
            this.btnCommonGames = new System.Windows.Forms.Button();
            this.txbNewUser = new System.Windows.Forms.TextBox();
            this.txbNewExbName = new System.Windows.Forms.TextBox();
            this.lblNewUser = new System.Windows.Forms.Label();
            this.lblNewExbitionName = new System.Windows.Forms.Label();
            this.btnAddGameToUser = new System.Windows.Forms.Button();
            this.txbGameName = new System.Windows.Forms.TextBox();
            this.lblGame = new System.Windows.Forms.Label();
            this.btnAddFounds = new System.Windows.Forms.Button();
            this.txbAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGames
            // 
            this.btnGames.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGames.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGames.ForeColor = System.Drawing.Color.Gold;
            this.btnGames.Location = new System.Drawing.Point(30, 326);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(167, 44);
            this.btnGames.TabIndex = 1;
            this.btnGames.Text = "Games Library";
            this.btnGames.UseVisualStyleBackColor = false;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnFriends
            // 
            this.btnFriends.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnFriends.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFriends.ForeColor = System.Drawing.Color.Gold;
            this.btnFriends.Location = new System.Drawing.Point(30, 394);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(167, 44);
            this.btnFriends.TabIndex = 2;
            this.btnFriends.Text = "Friends List";
            this.btnFriends.UseVisualStyleBackColor = false;
            this.btnFriends.Click += new System.EventHandler(this.btnFriends_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::Projeto.Properties.Resources.DefaultUser;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = global::Projeto.Properties.Resources.DefaultUser;
            this.pictureBox1.Location = new System.Drawing.Point(43, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReturn.ForeColor = System.Drawing.Color.Gold;
            this.btnReturn.Location = new System.Drawing.Point(1101, 590);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(125, 40);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Back";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lbl_ExibitionName
            // 
            this.lbl_ExibitionName.AutoSize = true;
            this.lbl_ExibitionName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ExibitionName.Location = new System.Drawing.Point(69, 223);
            this.lbl_ExibitionName.Name = "lbl_ExibitionName";
            this.lbl_ExibitionName.Size = new System.Drawing.Size(19, 30);
            this.lbl_ExibitionName.TabIndex = 5;
            this.lbl_ExibitionName.Text = " ";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbl_UserName.Location = new System.Drawing.Point(69, 253);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(12, 17);
            this.lbl_UserName.TabIndex = 6;
            this.lbl_UserName.Text = " ";
            // 
            // lbl_Wallet
            // 
            this.lbl_Wallet.AutoSize = true;
            this.lbl_Wallet.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Wallet.Location = new System.Drawing.Point(69, 288);
            this.lbl_Wallet.Name = "lbl_Wallet";
            this.lbl_Wallet.Size = new System.Drawing.Size(14, 21);
            this.lbl_Wallet.TabIndex = 7;
            this.lbl_Wallet.Text = " ";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(30, 24);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(86, 15);
            this.lblInput.TabIndex = 8;
            this.lblInput.Text = "Type username";
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(30, 51);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(167, 23);
            this.txbInput.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmGameName,
            this.clmGenre,
            this.clmPublisher});
            this.listView1.Location = new System.Drawing.Point(693, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(512, 463);
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
            this.clmGenre.Width = 135;
            // 
            // clmPublisher
            // 
            this.clmPublisher.Text = "Publisher";
            this.clmPublisher.Width = 170;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmUsername,
            this.clmExibitionName});
            this.listView2.Location = new System.Drawing.Point(693, 51);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(512, 463);
            this.listView2.TabIndex = 11;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // clmUsername
            // 
            this.clmUsername.Text = "Username";
            this.clmUsername.Width = 170;
            // 
            // clmExibitionName
            // 
            this.clmExibitionName.Text = "Exibition Name";
            this.clmExibitionName.Width = 170;
            // 
            // btnAddFriend
            // 
            this.btnAddFriend.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddFriend.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddFriend.ForeColor = System.Drawing.Color.Gold;
            this.btnAddFriend.Location = new System.Drawing.Point(463, 176);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(167, 44);
            this.btnAddFriend.TabIndex = 7;
            this.btnAddFriend.Text = "Add Friend";
            this.btnAddFriend.UseVisualStyleBackColor = false;
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // txbFriendInput
            // 
            this.txbFriendInput.Location = new System.Drawing.Point(463, 51);
            this.txbFriendInput.Name = "txbFriendInput";
            this.txbFriendInput.Size = new System.Drawing.Size(167, 23);
            this.txbFriendInput.TabIndex = 6;
            // 
            // lblFriendInput
            // 
            this.lblFriendInput.AutoSize = true;
            this.lblFriendInput.Location = new System.Drawing.Point(463, 24);
            this.lblFriendInput.Name = "lblFriendInput";
            this.lblFriendInput.Size = new System.Drawing.Size(96, 15);
            this.lblFriendInput.TabIndex = 14;
            this.lblFriendInput.Text = "Friend Username";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCreateUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreateUser.ForeColor = System.Drawing.Color.Gold;
            this.btnCreateUser.Location = new System.Drawing.Point(247, 176);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(167, 44);
            this.btnCreateUser.TabIndex = 9;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnShowAllUsers
            // 
            this.btnShowAllUsers.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnShowAllUsers.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShowAllUsers.ForeColor = System.Drawing.Color.Gold;
            this.btnShowAllUsers.Location = new System.Drawing.Point(690, 535);
            this.btnShowAllUsers.Name = "btnShowAllUsers";
            this.btnShowAllUsers.Size = new System.Drawing.Size(141, 38);
            this.btnShowAllUsers.TabIndex = 8;
            this.btnShowAllUsers.Text = "Show All Users";
            this.btnShowAllUsers.UseVisualStyleBackColor = false;
            this.btnShowAllUsers.Click += new System.EventHandler(this.btnShowAllUsers_Click);
            // 
            // btnCommonGames
            // 
            this.btnCommonGames.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCommonGames.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCommonGames.ForeColor = System.Drawing.Color.Gold;
            this.btnCommonGames.Location = new System.Drawing.Point(463, 108);
            this.btnCommonGames.Name = "btnCommonGames";
            this.btnCommonGames.Size = new System.Drawing.Size(167, 44);
            this.btnCommonGames.TabIndex = 3;
            this.btnCommonGames.Text = "Games in Common";
            this.btnCommonGames.UseVisualStyleBackColor = false;
            this.btnCommonGames.Click += new System.EventHandler(this.btnCommonGames_Click);
            // 
            // txbNewUser
            // 
            this.txbNewUser.Location = new System.Drawing.Point(247, 51);
            this.txbNewUser.Name = "txbNewUser";
            this.txbNewUser.Size = new System.Drawing.Size(167, 23);
            this.txbNewUser.TabIndex = 10;
            // 
            // txbNewExbName
            // 
            this.txbNewExbName.Location = new System.Drawing.Point(247, 125);
            this.txbNewExbName.Name = "txbNewExbName";
            this.txbNewExbName.Size = new System.Drawing.Size(167, 23);
            this.txbNewExbName.TabIndex = 11;
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Location = new System.Drawing.Point(247, 24);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(87, 15);
            this.lblNewUser.TabIndex = 20;
            this.lblNewUser.Text = "New Username";
            // 
            // lblNewExbitionName
            // 
            this.lblNewExbitionName.AutoSize = true;
            this.lblNewExbitionName.Location = new System.Drawing.Point(246, 98);
            this.lblNewExbitionName.Name = "lblNewExbitionName";
            this.lblNewExbitionName.Size = new System.Drawing.Size(88, 15);
            this.lblNewExbitionName.TabIndex = 21;
            this.lblNewExbitionName.Text = "Exibition Name";
            // 
            // btnAddGameToUser
            // 
            this.btnAddGameToUser.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddGameToUser.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddGameToUser.ForeColor = System.Drawing.Color.Gold;
            this.btnAddGameToUser.Location = new System.Drawing.Point(246, 373);
            this.btnAddGameToUser.Name = "btnAddGameToUser";
            this.btnAddGameToUser.Size = new System.Drawing.Size(167, 44);
            this.btnAddGameToUser.TabIndex = 5;
            this.btnAddGameToUser.Text = "Add Game to Library";
            this.btnAddGameToUser.UseVisualStyleBackColor = false;
            this.btnAddGameToUser.Click += new System.EventHandler(this.btnAddGameToUser_Click);
            // 
            // txbGameName
            // 
            this.txbGameName.Location = new System.Drawing.Point(246, 326);
            this.txbGameName.Name = "txbGameName";
            this.txbGameName.Size = new System.Drawing.Size(167, 23);
            this.txbGameName.TabIndex = 4;
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(246, 299);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(38, 15);
            this.lblGame.TabIndex = 24;
            this.lblGame.Text = "Game";
            // 
            // btnAddFounds
            // 
            this.btnAddFounds.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAddFounds.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddFounds.ForeColor = System.Drawing.Color.Gold;
            this.btnAddFounds.Location = new System.Drawing.Point(30, 542);
            this.btnAddFounds.Name = "btnAddFounds";
            this.btnAddFounds.Size = new System.Drawing.Size(167, 44);
            this.btnAddFounds.TabIndex = 25;
            this.btnAddFounds.Text = "Add Founds";
            this.btnAddFounds.UseVisualStyleBackColor = false;
            this.btnAddFounds.Click += new System.EventHandler(this.btnAddFounds_Click);
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(30, 491);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(167, 23);
            this.txbAmount.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Type amount";
            // 
            // FrmUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1238, 642);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbAmount);
            this.Controls.Add(this.btnAddFounds);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.txbGameName);
            this.Controls.Add(this.btnAddGameToUser);
            this.Controls.Add(this.lblNewExbitionName);
            this.Controls.Add(this.lblNewUser);
            this.Controls.Add(this.txbNewExbName);
            this.Controls.Add(this.txbNewUser);
            this.Controls.Add(this.btnCommonGames);
            this.Controls.Add(this.btnShowAllUsers);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.lblFriendInput);
            this.Controls.Add(this.txbFriendInput);
            this.Controls.Add(this.btnAddFriend);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Button btnAddFriend;
        private TextBox txbFriendInput;
        private Label lblFriendInput;
        private Button btnCreateUser;
        private Button btnShowAllUsers;
        private Button btnCommonGames;
        private TextBox txbNewUser;
        private TextBox txbNewExbName;
        private Label lblNewUser;
        private Label lblNewExbitionName;
        private Button btnAddGameToUser;
        private TextBox txbGameName;
        private Label lblGame;
        private Button btnAddFounds;
        private TextBox txbAmount;
        private Label label1;
    }
}