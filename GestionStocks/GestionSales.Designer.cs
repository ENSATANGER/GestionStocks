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
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalTBOX = new System.Windows.Forms.TextBox();
            this.Rechercher = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.SalesTable = new System.Windows.Forms.DataGridView();
            this.NClient = new System.Windows.Forms.ComboBox();
            this.NProduit = new System.Windows.Forms.ComboBox();
            this.NQuantite = new System.Windows.Forms.NumericUpDown();
            this.nomClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SalesTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.Location = new System.Drawing.Point(55, 48);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(73, 13);
            this.ClientLabel.TabIndex = 0;
            this.ClientLabel.Text = "Nom du Client";
            this.ClientLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProduitLabel
            // 
            this.ProduitLabel.AutoSize = true;
            this.ProduitLabel.Location = new System.Drawing.Point(55, 88);
            this.ProduitLabel.Name = "ProduitLabel";
            this.ProduitLabel.Size = new System.Drawing.Size(80, 13);
            this.ProduitLabel.TabIndex = 1;
            this.ProduitLabel.Text = "Nom du Produit";
            // 
            // QuantitLabel
            // 
            this.QuantitLabel.AutoSize = true;
            this.QuantitLabel.Location = new System.Drawing.Point(55, 131);
            this.QuantitLabel.Name = "QuantitLabel";
            this.QuantitLabel.Size = new System.Drawing.Size(49, 13);
            this.QuantitLabel.TabIndex = 2;
            this.QuantitLabel.Text = "Quanitité";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(55, 175);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(31, 13);
            this.TotalLabel.TabIndex = 6;
            this.TotalLabel.Text = "Total";
            // 
            // TotalTBOX
            // 
            this.TotalTBOX.Location = new System.Drawing.Point(217, 168);
            this.TotalTBOX.Name = "TotalTBOX";
            this.TotalTBOX.ReadOnly = true;
            this.TotalTBOX.Size = new System.Drawing.Size(122, 20);
            this.TotalTBOX.TabIndex = 7;
            this.TotalTBOX.Text = "00.00";
            this.TotalTBOX.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Rechercher
            // 
            this.Rechercher.Location = new System.Drawing.Point(480, 165);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(145, 23);
            this.Rechercher.TabIndex = 16;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(480, 121);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(145, 23);
            this.Supprimer.TabIndex = 15;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(480, 78);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(145, 23);
            this.Modifier.TabIndex = 14;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(480, 38);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(145, 23);
            this.Ajouter.TabIndex = 13;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // SalesTable
            // 
            this.SalesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomClient,
            this.nomProduit,
            this.Quantite,
            this.Prix,
            this.total,
            this.ID});
            this.SalesTable.Location = new System.Drawing.Point(58, 226);
            this.SalesTable.Name = "SalesTable";
            this.SalesTable.ReadOnly = true;
            this.SalesTable.Size = new System.Drawing.Size(567, 191);
            this.SalesTable.TabIndex = 21;
            this.SalesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesTable_CellClick);
            // 
            // NClient
            // 
            this.NClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NClient.FormattingEnabled = true;
            this.NClient.Location = new System.Drawing.Point(217, 39);
            this.NClient.Name = "NClient";
            this.NClient.Size = new System.Drawing.Size(121, 21);
            this.NClient.TabIndex = 22;
            this.NClient.SelectedIndexChanged += new System.EventHandler(this.NClient_SelectedIndexChanged);
            // 
            // NProduit
            // 
            this.NProduit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NProduit.FormattingEnabled = true;
            this.NProduit.Location = new System.Drawing.Point(217, 85);
            this.NProduit.Name = "NProduit";
            this.NProduit.Size = new System.Drawing.Size(121, 21);
            this.NProduit.TabIndex = 23;
            this.NProduit.SelectedIndexChanged += new System.EventHandler(this.NProduit_SelectedIndexChanged);
            // 
            // NQuantite
            // 
            this.NQuantite.Location = new System.Drawing.Point(217, 124);
            this.NQuantite.Name = "NQuantite";
            this.NQuantite.Size = new System.Drawing.Size(121, 20);
            this.NQuantite.TabIndex = 24;
            this.NQuantite.ValueChanged += new System.EventHandler(this.NQuantite_ValueChanged);
            // 
            // nomClient
            // 
            this.nomClient.HeaderText = "Nom du Client";
            this.nomClient.Name = "nomClient";
            this.nomClient.ReadOnly = true;
            this.nomClient.Width = 110;
            // 
            // nomProduit
            // 
            this.nomProduit.HeaderText = "Nom du Produit";
            this.nomProduit.Name = "nomProduit";
            this.nomProduit.ReadOnly = true;
            this.nomProduit.Width = 110;
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantité";
            this.Quantite.Name = "Quantite";
            this.Quantite.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.total.Width = 104;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // GestionSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 537);
            this.ControlBox = false;
            this.Controls.Add(this.NQuantite);
            this.Controls.Add(this.NProduit);
            this.Controls.Add(this.NClient);
            this.Controls.Add(this.SalesTable);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.TotalTBOX);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.QuantitLabel);
            this.Controls.Add(this.ProduitLabel);
            this.Controls.Add(this.ClientLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionSales";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion Sales";
            this.Load += new System.EventHandler(this.GestionSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.Label ProduitLabel;
        private System.Windows.Forms.Label QuantitLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox TotalTBOX;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.DataGridView SalesTable;
        private System.Windows.Forms.ComboBox NClient;
        private System.Windows.Forms.ComboBox NProduit;
        private System.Windows.Forms.NumericUpDown NQuantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}