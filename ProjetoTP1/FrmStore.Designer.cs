namespace Projeto
{
    partial class FrmStore
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOpenStore = new System.Windows.Forms.Button();
            this.btnSearchGameInStore = new System.Windows.Forms.Button();
            this.btnAddGameToStore = new System.Windows.Forms.Button();
            this.btnRemoveGameFromStore = new System.Windows.Forms.Button();
            this.lsvStoreFull = new System.Windows.Forms.ListView();
            this.gameName = new System.Windows.Forms.ColumnHeader();
            this.gamePrice = new System.Windows.Forms.ColumnHeader();
            this.gameGenre = new System.Windows.Forms.ColumnHeader();
            this.gamePublisher = new System.Windows.Forms.ColumnHeader();
            this.txbGameInput = new System.Windows.Forms.TextBox();
            this.lblAddGameName = new System.Windows.Forms.Label();
            this.txbAddGameName = new System.Windows.Forms.TextBox();
            this.txbAddGamePrice = new System.Windows.Forms.TextBox();
            this.lblAddPriceGame = new System.Windows.Forms.Label();
            this.txbAddGameGenre = new System.Windows.Forms.TextBox();
            this.lblAddGameGenre = new System.Windows.Forms.Label();
            this.txbAddGamePublisher = new System.Windows.Forms.TextBox();
            this.lblAddPublisher = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(18, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Loja de Jogos";
            // 
            // btnOpenStore
            // 
            this.btnOpenStore.Location = new System.Drawing.Point(18, 75);
            this.btnOpenStore.Name = "btnOpenStore";
            this.btnOpenStore.Size = new System.Drawing.Size(113, 50);
            this.btnOpenStore.TabIndex = 1;
            this.btnOpenStore.Text = "Open Store";
            this.btnOpenStore.UseVisualStyleBackColor = true;
            this.btnOpenStore.Click += new System.EventHandler(this.btnOpenStore_Click);
            // 
            // btnSearchGameInStore
            // 
            this.btnSearchGameInStore.Location = new System.Drawing.Point(169, 20);
            this.btnSearchGameInStore.Name = "btnSearchGameInStore";
            this.btnSearchGameInStore.Size = new System.Drawing.Size(111, 23);
            this.btnSearchGameInStore.TabIndex = 2;
            this.btnSearchGameInStore.Text = "Search Game";
            this.btnSearchGameInStore.UseVisualStyleBackColor = true;
            this.btnSearchGameInStore.Click += new System.EventHandler(this.btnSearchGameInStore_Click);
            // 
            // btnAddGameToStore
            // 
            this.btnAddGameToStore.Location = new System.Drawing.Point(18, 144);
            this.btnAddGameToStore.Name = "btnAddGameToStore";
            this.btnAddGameToStore.Size = new System.Drawing.Size(113, 50);
            this.btnAddGameToStore.TabIndex = 3;
            this.btnAddGameToStore.Text = "Add Game to Store";
            this.btnAddGameToStore.UseVisualStyleBackColor = true;
            this.btnAddGameToStore.Click += new System.EventHandler(this.btnAddGameToStore_Click);
            // 
            // btnRemoveGameFromStore
            // 
            this.btnRemoveGameFromStore.Location = new System.Drawing.Point(513, 20);
            this.btnRemoveGameFromStore.Name = "btnRemoveGameFromStore";
            this.btnRemoveGameFromStore.Size = new System.Drawing.Size(135, 23);
            this.btnRemoveGameFromStore.TabIndex = 4;
            this.btnRemoveGameFromStore.Text = "Remove game";
            this.btnRemoveGameFromStore.UseVisualStyleBackColor = true;
            this.btnRemoveGameFromStore.Click += new System.EventHandler(this.btnRemoveGameFromStore_Click);
            // 
            // lsvStoreFull
            // 
            this.lsvStoreFull.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gameName,
            this.gamePrice,
            this.gameGenre,
            this.gamePublisher});
            this.lsvStoreFull.Location = new System.Drawing.Point(169, 49);
            this.lsvStoreFull.Name = "lsvStoreFull";
            this.lsvStoreFull.Size = new System.Drawing.Size(479, 327);
            this.lsvStoreFull.TabIndex = 5;
            this.lsvStoreFull.UseCompatibleStateImageBehavior = false;
            this.lsvStoreFull.View = System.Windows.Forms.View.Details;
            // 
            // gameName
            // 
            this.gameName.Text = "Name";
            this.gameName.Width = 200;
            // 
            // gamePrice
            // 
            this.gamePrice.Text = "Price";
            // 
            // gameGenre
            // 
            this.gameGenre.Text = "Gênero";
            // 
            // gamePublisher
            // 
            this.gamePublisher.Text = "Empresa";
            this.gamePublisher.Width = 150;
            // 
            // txbGameInput
            // 
            this.txbGameInput.Location = new System.Drawing.Point(286, 20);
            this.txbGameInput.Name = "txbGameInput";
            this.txbGameInput.Size = new System.Drawing.Size(221, 23);
            this.txbGameInput.TabIndex = 6;
            // 
            // lblAddGameName
            // 
            this.lblAddGameName.AutoSize = true;
            this.lblAddGameName.Location = new System.Drawing.Point(18, 200);
            this.lblAddGameName.Name = "lblAddGameName";
            this.lblAddGameName.Size = new System.Drawing.Size(73, 15);
            this.lblAddGameName.TabIndex = 7;
            this.lblAddGameName.Text = "Game Name";
            this.lblAddGameName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbAddGameName
            // 
            this.txbAddGameName.Location = new System.Drawing.Point(18, 218);
            this.txbAddGameName.Name = "txbAddGameName";
            this.txbAddGameName.Size = new System.Drawing.Size(113, 23);
            this.txbAddGameName.TabIndex = 8;
            // 
            // txbAddGamePrice
            // 
            this.txbAddGamePrice.Location = new System.Drawing.Point(18, 271);
            this.txbAddGamePrice.Name = "txbAddGamePrice";
            this.txbAddGamePrice.Size = new System.Drawing.Size(113, 23);
            this.txbAddGamePrice.TabIndex = 10;
            // 
            // lblAddPriceGame
            // 
            this.lblAddPriceGame.AutoSize = true;
            this.lblAddPriceGame.Location = new System.Drawing.Point(18, 253);
            this.lblAddPriceGame.Name = "lblAddPriceGame";
            this.lblAddPriceGame.Size = new System.Drawing.Size(33, 15);
            this.lblAddPriceGame.TabIndex = 9;
            this.lblAddPriceGame.Text = "Price";
            this.lblAddPriceGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbAddGameGenre
            // 
            this.txbAddGameGenre.Location = new System.Drawing.Point(18, 325);
            this.txbAddGameGenre.Name = "txbAddGameGenre";
            this.txbAddGameGenre.Size = new System.Drawing.Size(113, 23);
            this.txbAddGameGenre.TabIndex = 12;
            // 
            // lblAddGameGenre
            // 
            this.lblAddGameGenre.AutoSize = true;
            this.lblAddGameGenre.Location = new System.Drawing.Point(18, 307);
            this.lblAddGameGenre.Name = "lblAddGameGenre";
            this.lblAddGameGenre.Size = new System.Drawing.Size(38, 15);
            this.lblAddGameGenre.TabIndex = 11;
            this.lblAddGameGenre.Text = "Genre";
            this.lblAddGameGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txbAddGamePublisher
            // 
            this.txbAddGamePublisher.Location = new System.Drawing.Point(18, 379);
            this.txbAddGamePublisher.Name = "txbAddGamePublisher";
            this.txbAddGamePublisher.Size = new System.Drawing.Size(113, 23);
            this.txbAddGamePublisher.TabIndex = 16;
            // 
            // lblAddPublisher
            // 
            this.lblAddPublisher.AutoSize = true;
            this.lblAddPublisher.Location = new System.Drawing.Point(18, 361);
            this.lblAddPublisher.Name = "lblAddPublisher";
            this.lblAddPublisher.Size = new System.Drawing.Size(56, 15);
            this.lblAddPublisher.TabIndex = 15;
            this.lblAddPublisher.Text = "Publisher";
            this.lblAddPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(549, 398);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(125, 40);
            this.btnReturn.TabIndex = 17;
            this.btnReturn.Text = "Voltar";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // FrmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.txbAddGamePublisher);
            this.Controls.Add(this.lblAddPublisher);
            this.Controls.Add(this.txbAddGameGenre);
            this.Controls.Add(this.lblAddGameGenre);
            this.Controls.Add(this.txbAddGamePrice);
            this.Controls.Add(this.lblAddPriceGame);
            this.Controls.Add(this.txbAddGameName);
            this.Controls.Add(this.lblAddGameName);
            this.Controls.Add(this.txbGameInput);
            this.Controls.Add(this.lsvStoreFull);
            this.Controls.Add(this.btnRemoveGameFromStore);
            this.Controls.Add(this.btnAddGameToStore);
            this.Controls.Add(this.btnSearchGameInStore);
            this.Controls.Add(this.btnOpenStore);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store";
            this.Load += new System.EventHandler(this.FrmStore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnOpenStore;
        private Button btnSearchGameInStore;
        private Button btnAddGameToStore;
        private Button btnRemoveGameFromStore;
        private ListView lsvStoreFull;
        private ColumnHeader gameName;
        private ColumnHeader gamePrice;
        private ColumnHeader gameGenre;
        private ColumnHeader gamePublisher;
        private TextBox txbGameInput;
        private Label lblAddGameName;
        private TextBox txbAddGameName;
        private TextBox txbAddGamePrice;
        private Label lblAddPriceGame;
        private TextBox txbAddGameGenre;
        private Label lblAddGameGenre;
        private TextBox txbAddGamePublisher;
        private Label lblAddPublisher;
        private Button btnReturn;
    }
}