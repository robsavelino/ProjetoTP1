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
            this.btnOpenStore.Text = "Abrir Loja";
            this.btnOpenStore.UseVisualStyleBackColor = true;
            this.btnOpenStore.Click += new System.EventHandler(this.btnOpenStore_Click);
            // 
            // btnSearchGameInStore
            // 
            this.btnSearchGameInStore.Location = new System.Drawing.Point(18, 147);
            this.btnSearchGameInStore.Name = "btnSearchGameInStore";
            this.btnSearchGameInStore.Size = new System.Drawing.Size(113, 50);
            this.btnSearchGameInStore.TabIndex = 2;
            this.btnSearchGameInStore.Text = "Pesquisar Jogo";
            this.btnSearchGameInStore.UseVisualStyleBackColor = true;
            // 
            // btnAddGameToStore
            // 
            this.btnAddGameToStore.Location = new System.Drawing.Point(18, 221);
            this.btnAddGameToStore.Name = "btnAddGameToStore";
            this.btnAddGameToStore.Size = new System.Drawing.Size(113, 50);
            this.btnAddGameToStore.TabIndex = 3;
            this.btnAddGameToStore.Text = "Adicionar Jogo a Loja";
            this.btnAddGameToStore.UseVisualStyleBackColor = true;
            // 
            // btnRemoveGameFromStore
            // 
            this.btnRemoveGameFromStore.Location = new System.Drawing.Point(18, 298);
            this.btnRemoveGameFromStore.Name = "btnRemoveGameFromStore";
            this.btnRemoveGameFromStore.Size = new System.Drawing.Size(113, 50);
            this.btnRemoveGameFromStore.TabIndex = 4;
            this.btnRemoveGameFromStore.Text = "Remover Jogo da Loja";
            this.btnRemoveGameFromStore.UseVisualStyleBackColor = true;
            // 
            // lsvStoreFull
            // 
            this.lsvStoreFull.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.gameName,
            this.gamePrice,
            this.gameGenre,
            this.gamePublisher});
            this.lsvStoreFull.Location = new System.Drawing.Point(217, 75);
            this.lsvStoreFull.Name = "lsvStoreFull";
            this.lsvStoreFull.Size = new System.Drawing.Size(348, 273);
            this.lsvStoreFull.TabIndex = 5;
            this.lsvStoreFull.UseCompatibleStateImageBehavior = false;
            this.lsvStoreFull.View = System.Windows.Forms.View.Details;
            // 
            // gameName
            // 
            this.gameName.Text = "Name";
            this.gameName.Width = 120;
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
            this.gamePublisher.Width = 100;
            // 
            // FrmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(686, 450);
            this.Controls.Add(this.lsvStoreFull);
            this.Controls.Add(this.btnRemoveGameFromStore);
            this.Controls.Add(this.btnAddGameToStore);
            this.Controls.Add(this.btnSearchGameInStore);
            this.Controls.Add(this.btnOpenStore);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmStore";
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
    }
}