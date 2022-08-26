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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGames
            // 
            this.btnGames.Location = new System.Drawing.Point(1001, 115);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(225, 44);
            this.btnGames.TabIndex = 1;
            this.btnGames.Text = "Games Library";
            this.btnGames.UseVisualStyleBackColor = true;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // btnFriends
            // 
            this.btnFriends.Location = new System.Drawing.Point(1001, 191);
            this.btnFriends.Name = "btnFriends";
            this.btnFriends.Size = new System.Drawing.Size(225, 44);
            this.btnFriends.TabIndex = 2;
            this.btnFriends.Text = "Friends List";
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
            this.btnReturn.Location = new System.Drawing.Point(1124, 549);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 43);
            this.btnReturn.TabIndex = 12;
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
            this.lbl_ExibitionName.Size = new System.Drawing.Size(0, 25);
            this.lbl_ExibitionName.TabIndex = 5;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_UserName.Location = new System.Drawing.Point(49, 236);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(0, 17);
            this.lbl_UserName.TabIndex = 6;
            // 
            // lbl_Wallet
            // 
            this.lbl_Wallet.AutoSize = true;
            this.lbl_Wallet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Wallet.Location = new System.Drawing.Point(50, 266);
            this.lbl_Wallet.Name = "lbl_Wallet";
            this.lbl_Wallet.Size = new System.Drawing.Size(0, 17);
            this.lbl_Wallet.TabIndex = 7;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(1001, 33);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(60, 15);
            this.lblInput.TabIndex = 8;
            this.lblInput.Text = "Username";
            // 
            // txbInput
            // 
            this.txbInput.Location = new System.Drawing.Point(1001, 51);
            this.txbInput.Name = "txbInput";
            this.txbInput.Size = new System.Drawing.Size(225, 23);
            this.txbInput.TabIndex = 0;
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
            // btnAddFriend
            // 
            this.btnAddFriend.Location = new System.Drawing.Point(1001, 470);
            this.btnAddFriend.Name = "btnAddFriend";
            this.btnAddFriend.Size = new System.Drawing.Size(225, 44);
            this.btnAddFriend.TabIndex = 7;
            this.btnAddFriend.Text = "Add Friend";
            this.btnAddFriend.UseVisualStyleBackColor = true;
            this.btnAddFriend.Click += new System.EventHandler(this.btnAddFriend_Click);
            // 
            // txbFriendInput
            // 
            this.txbFriendInput.Location = new System.Drawing.Point(1001, 441);
            this.txbFriendInput.Name = "txbFriendInput";
            this.txbFriendInput.Size = new System.Drawing.Size(225, 23);
            this.txbFriendInput.TabIndex = 6;
            // 
            // lblFriendInput
            // 
            this.lblFriendInput.AutoSize = true;
            this.lblFriendInput.Location = new System.Drawing.Point(1001, 423);
            this.lblFriendInput.Name = "lblFriendInput";
            this.lblFriendInput.Size = new System.Drawing.Size(96, 15);
            this.lblFriendInput.TabIndex = 14;
            this.lblFriendInput.Text = "Friend Username";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(219, 575);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(118, 23);
            this.btnCreateUser.TabIndex = 9;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnShowAllUsers
            // 
            this.btnShowAllUsers.Location = new System.Drawing.Point(219, 520);
            this.btnShowAllUsers.Name = "btnShowAllUsers";
            this.btnShowAllUsers.Size = new System.Drawing.Size(110, 23);
            this.btnShowAllUsers.TabIndex = 8;
            this.btnShowAllUsers.Text = "Show All Users";
            this.btnShowAllUsers.UseVisualStyleBackColor = true;
            this.btnShowAllUsers.Click += new System.EventHandler(this.btnShowAllUsers_Click);
            // 
            // btnCommonGames
            // 
            this.btnCommonGames.Location = new System.Drawing.Point(1001, 266);
            this.btnCommonGames.Name = "btnCommonGames";
            this.btnCommonGames.Size = new System.Drawing.Size(225, 44);
            this.btnCommonGames.TabIndex = 3;
            this.btnCommonGames.Text = "Games in Common";
            this.btnCommonGames.UseVisualStyleBackColor = true;
            this.btnCommonGames.Click += new System.EventHandler(this.btnCommonGames_Click);
            // 
            // txbNewUser
            // 
            this.txbNewUser.Location = new System.Drawing.Point(369, 576);
            this.txbNewUser.Name = "txbNewUser";
            this.txbNewUser.Size = new System.Drawing.Size(129, 23);
            this.txbNewUser.TabIndex = 10;
            // 
            // txbNewExbName
            // 
            this.txbNewExbName.Location = new System.Drawing.Point(523, 575);
            this.txbNewExbName.Name = "txbNewExbName";
            this.txbNewExbName.Size = new System.Drawing.Size(129, 23);
            this.txbNewExbName.TabIndex = 11;
            // 
            // lblNewUser
            // 
            this.lblNewUser.AutoSize = true;
            this.lblNewUser.Location = new System.Drawing.Point(369, 557);
            this.lblNewUser.Name = "lblNewUser";
            this.lblNewUser.Size = new System.Drawing.Size(87, 15);
            this.lblNewUser.TabIndex = 20;
            this.lblNewUser.Text = "New Username";
            // 
            // lblNewExbitionName
            // 
            this.lblNewExbitionName.AutoSize = true;
            this.lblNewExbitionName.Location = new System.Drawing.Point(523, 557);
            this.lblNewExbitionName.Name = "lblNewExbitionName";
            this.lblNewExbitionName.Size = new System.Drawing.Size(88, 15);
            this.lblNewExbitionName.TabIndex = 21;
            this.lblNewExbitionName.Text = "Exibition Name";
            // 
            // btnAddGameToUser
            // 
            this.btnAddGameToUser.Location = new System.Drawing.Point(1001, 376);
            this.btnAddGameToUser.Name = "btnAddGameToUser";
            this.btnAddGameToUser.Size = new System.Drawing.Size(225, 44);
            this.btnAddGameToUser.TabIndex = 5;
            this.btnAddGameToUser.Text = "Add Game to Library";
            this.btnAddGameToUser.UseVisualStyleBackColor = true;
            this.btnAddGameToUser.Click += new System.EventHandler(this.btnAddGameToUser_Click);
            // 
            // txbGameName
            // 
            this.txbGameName.Location = new System.Drawing.Point(1001, 347);
            this.txbGameName.Name = "txbGameName";
            this.txbGameName.Size = new System.Drawing.Size(225, 23);
            this.txbGameName.TabIndex = 4;
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Location = new System.Drawing.Point(1001, 329);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(38, 15);
            this.lblGame.TabIndex = 24;
            this.lblGame.Text = "Game";
            // 
            // btnAddFounds
            // 
            this.btnAddFounds.Location = new System.Drawing.Point(49, 321);
            this.btnAddFounds.Name = "btnAddFounds";
            this.btnAddFounds.Size = new System.Drawing.Size(118, 23);
            this.btnAddFounds.TabIndex = 25;
            this.btnAddFounds.Text = "Add Founds";
            this.btnAddFounds.UseVisualStyleBackColor = true;
            this.btnAddFounds.Click += new System.EventHandler(this.btnAddFounds_Click);
            // 
            // txbAmount
            // 
            this.txbAmount.Location = new System.Drawing.Point(50, 292);
            this.txbAmount.Name = "txbAmount";
            this.txbAmount.Size = new System.Drawing.Size(129, 23);
            this.txbAmount.TabIndex = 26;
            // 
            // FrmUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1238, 642);
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
    }
}