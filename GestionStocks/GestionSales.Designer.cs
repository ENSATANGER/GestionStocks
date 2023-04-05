namespace GestionStocks
{
    partial class GestionSales
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
            this.ClientLabel = new System.Windows.Forms.Label();
            this.ProduitLabel = new System.Windows.Forms.Label();
            this.QuantitLabel = new System.Windows.Forms.Label();
            this.ClientTBOX = new System.Windows.Forms.TextBox();
            this.ProduitTBOX = new System.Windows.Forms.TextBox();
            this.QuantiteTBOX = new System.Windows.Forms.TextBox();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalTBOX = new System.Windows.Forms.TextBox();
            this.Rechercher = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.SalesTable = new System.Windows.Forms.DataGridView();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SalesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(54, 36);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(73, 13);
            this.ClientLabel.TabIndex = 0;
            this.ClientLabel.Text = "Nom du Client";
            this.ClientLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProduitLabel
            // 
            this.ProduitLabel.AutoSize = true;
            this.ProduitLabel.Location = new System.Drawing.Point(54, 76);
            this.ProduitLabel.Name = "ProduitLabel";
            this.ProduitLabel.Size = new System.Drawing.Size(80, 13);
            this.ProduitLabel.TabIndex = 1;
            this.ProduitLabel.Text = "Nom du Produit";
            // 
            // QuantitLabel
            // 
            this.QuantitLabel.AutoSize = true;
            this.QuantitLabel.Location = new System.Drawing.Point(54, 119);
            this.QuantitLabel.Name = "QuantitLabel";
            this.QuantitLabel.Size = new System.Drawing.Size(49, 13);
            this.QuantitLabel.TabIndex = 2;
            this.QuantitLabel.Text = "Quanitité";
            // 
            // ClientTBOX
            // 
            this.ClientTBOX.Location = new System.Drawing.Point(238, 29);
            this.ClientTBOX.Name = "ClientTBOX";
            this.ClientTBOX.Size = new System.Drawing.Size(100, 20);
            this.ClientTBOX.TabIndex = 3;
            // 
            // ProduitTBOX
            // 
            this.ProduitTBOX.Location = new System.Drawing.Point(238, 69);
            this.ProduitTBOX.Name = "ProduitTBOX";
            this.ProduitTBOX.Size = new System.Drawing.Size(100, 20);
            this.ProduitTBOX.TabIndex = 4;
            // 
            // QuantiteTBOX
            // 
            this.QuantiteTBOX.Location = new System.Drawing.Point(238, 112);
            this.QuantiteTBOX.Name = "QuantiteTBOX";
            this.QuantiteTBOX.Size = new System.Drawing.Size(100, 20);
            this.QuantiteTBOX.TabIndex = 5;
            this.QuantiteTBOX.Text = "0";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(57, 163);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(31, 13);
            this.TotalLabel.TabIndex = 6;
            this.TotalLabel.Text = "Total";
            // 
            // TotalTBOX
            // 
            this.TotalTBOX.Location = new System.Drawing.Point(238, 156);
            this.TotalTBOX.Name = "TotalTBOX";
            this.TotalTBOX.Size = new System.Drawing.Size(100, 20);
            this.TotalTBOX.TabIndex = 7;
            this.TotalTBOX.Text = "00.00";
            this.TotalTBOX.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Rechercher
            // 
            this.Rechercher.Location = new System.Drawing.Point(479, 153);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(145, 23);
            this.Rechercher.TabIndex = 16;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = true;
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(479, 109);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(145, 23);
            this.Supprimer.TabIndex = 15;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(479, 66);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(145, 23);
            this.Modifier.TabIndex = 14;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(479, 26);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(145, 23);
            this.Ajouter.TabIndex = 13;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            // 
            // SalesTable
            // 
            this.SalesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomClient,
            this.nomProduit,
            this.Quantite,
            this.Prix,
            this.total});
            this.SalesTable.Location = new System.Drawing.Point(57, 228);
            this.SalesTable.Name = "SalesTable";
            this.SalesTable.Size = new System.Drawing.Size(567, 191);
            this.SalesTable.TabIndex = 21;
            this.SalesTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProduitsTable_CellContentClick);
            // 
            // nomClient
            // 
            this.nomClient.HeaderText = "Nom du Client";
            this.nomClient.Name = "nomClient";
            this.nomClient.Width = 110;
            // 
            // nomProduit
            // 
            this.nomProduit.HeaderText = "Nom du Produit";
            this.nomProduit.Name = "nomProduit";
            this.nomProduit.Width = 110;
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantité";
            this.Quantite.Name = "Quantite";
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // GestionSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.SalesTable);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.TotalTBOX);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.QuantiteTBOX);
            this.Controls.Add(this.ProduitTBOX);
            this.Controls.Add(this.ClientTBOX);
            this.Controls.Add(this.QuantitLabel);
            this.Controls.Add(this.ProduitLabel);
            this.Controls.Add(this.ClientLabel);
            this.Name = "GestionSales";
            this.Text = "Gestion Sales";
            this.Load += new System.EventHandler(this.GestionSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.Label ProduitLabel;
        private System.Windows.Forms.Label QuantitLabel;
        private System.Windows.Forms.TextBox ClientTBOX;
        private System.Windows.Forms.TextBox ProduitTBOX;
        private System.Windows.Forms.TextBox QuantiteTBOX;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalTBOX;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.DataGridView SalesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}