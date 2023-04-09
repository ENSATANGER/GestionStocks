namespace GestionStocks
{
    partial class GestionProduits
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
            this.tnom = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.nquantite = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tprix = new System.Windows.Forms.TextBox();
            this.tpoids = new System.Windows.Forms.TextBox();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Rechercher = new System.Windows.Forms.Button();
            this.tname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.categoriebox = new System.Windows.Forms.ComboBox();
            this.ProduitsTable = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Poids = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nquantite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProduitsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tnom
            // 
            this.tnom.Location = new System.Drawing.Point(124, 12);
            this.tnom.Name = "tnom";
            this.tnom.Size = new System.Drawing.Size(236, 20);
            this.tnom.TabIndex = 0;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(124, 149);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Description.Size = new System.Drawing.Size(236, 79);
            this.Description.TabIndex = 4;
            // 
            // nquantite
            // 
            this.nquantite.Location = new System.Drawing.Point(124, 71);
            this.nquantite.Name = "nquantite";
            this.nquantite.Size = new System.Drawing.Size(236, 20);
            this.nquantite.TabIndex = 6;
            this.nquantite.ValueChanged += new System.EventHandler(this.nquantite_ValueChanged_1);
            // 
            // tprix
            // 
            this.tprix.Location = new System.Drawing.Point(124, 123);
            this.tprix.Name = "tprix";
            this.tprix.Size = new System.Drawing.Size(236, 20);
            this.tprix.TabIndex = 7;
            // 
            // tpoids
            // 
            this.tpoids.Location = new System.Drawing.Point(124, 97);
            this.tpoids.Name = "tpoids";
            this.tpoids.Size = new System.Drawing.Size(236, 20);
            this.tpoids.TabIndex = 8;
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(470, 42);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(145, 23);
            this.Ajouter.TabIndex = 9;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(470, 80);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(145, 23);
            this.Modifier.TabIndex = 10;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(470, 118);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(145, 23);
            this.Supprimer.TabIndex = 11;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Rechercher
            // 
            this.Rechercher.Location = new System.Drawing.Point(470, 162);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(145, 23);
            this.Rechercher.TabIndex = 12;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(92, 42);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(236, 20);
            this.tname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Categorie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Quantite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Poids";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Prix";
            // 
            // categoriebox
            // 
            this.categoriebox.FormattingEnabled = true;
            this.categoriebox.Location = new System.Drawing.Point(124, 39);
            this.categoriebox.Name = "categoriebox";
            this.categoriebox.Size = new System.Drawing.Size(236, 21);
            this.categoriebox.TabIndex = 19;
            this.categoriebox.SelectedIndexChanged += new System.EventHandler(this.categoriebox_SelectedIndexChanged);
            // 
            // ProduitsTable
            // 
            this.ProduitsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProduitsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.Cat,
            this.Quantite,
            this.Poids,
            this.Prix,
            this.Desc,
            this.Id});
            this.ProduitsTable.Location = new System.Drawing.Point(82, 247);
            this.ProduitsTable.Name = "ProduitsTable";
            this.ProduitsTable.Size = new System.Drawing.Size(641, 191);
            this.ProduitsTable.TabIndex = 20;
            this.ProduitsTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProduitsTable_CellClick);
            this.ProduitsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProduitsTable_CellContentClick);
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // Cat
            // 
            this.Cat.HeaderText = "Categorie";
            this.Cat.Name = "Cat";
            // 
            // Quantite
            // 
            this.Quantite.HeaderText = "Quantite";
            this.Quantite.Name = "Quantite";
            // 
            // Poids
            // 
            this.Poids.HeaderText = "Poids";
            this.Poids.Name = "Poids";
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Description";
            this.Desc.Name = "Desc";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // GestionProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ProduitsTable);
            this.Controls.Add(this.categoriebox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.tpoids);
            this.Controls.Add(this.tprix);
            this.Controls.Add(this.nquantite);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.tnom);
            this.Name = "GestionProduits";
            this.ShowInTaskbar = false;
            this.Text = "GestionProduits";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionProduits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nquantite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProduitsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tnom;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.NumericUpDown nquantite;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tprix;
        private System.Windows.Forms.TextBox tpoids;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox categoriebox;
        private System.Windows.Forms.DataGridView ProduitsTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Poids;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}