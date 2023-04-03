namespace GestionStocks
{
    partial class GestionCategories
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
            this.CategorieNomlabel = new System.Windows.Forms.Label();
            this.CategorieDesclabel = new System.Windows.Forms.Label();
            this.NomText = new System.Windows.Forms.TextBox();
            this.DescriptionText = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonRechercher = new System.Windows.Forms.Button();
            this.CategoriesTable = new System.Windows.Forms.DataGridView();
            this.NomCategories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionCategories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListCategories = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CategorieNomlabel
            // 
            this.CategorieNomlabel.AutoSize = true;
            this.CategorieNomlabel.Location = new System.Drawing.Point(108, 36);
            this.CategorieNomlabel.Name = "CategorieNomlabel";
            this.CategorieNomlabel.Size = new System.Drawing.Size(29, 13);
            this.CategorieNomlabel.TabIndex = 0;
            this.CategorieNomlabel.Text = "Nom";
            // 
            // CategorieDesclabel
            // 
            this.CategorieDesclabel.AutoSize = true;
            this.CategorieDesclabel.Location = new System.Drawing.Point(108, 99);
            this.CategorieDesclabel.Name = "CategorieDesclabel";
            this.CategorieDesclabel.Size = new System.Drawing.Size(60, 13);
            this.CategorieDesclabel.TabIndex = 1;
            this.CategorieDesclabel.Text = "Description";
            // 
            // NomText
            // 
            this.NomText.Location = new System.Drawing.Point(200, 29);
            this.NomText.Name = "NomText";
            this.NomText.Size = new System.Drawing.Size(198, 20);
            this.NomText.TabIndex = 2;
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(200, 68);
            this.DescriptionText.Multiline = true;
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.DescriptionText.Size = new System.Drawing.Size(236, 79);
            this.DescriptionText.TabIndex = 3;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(492, 17);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(158, 26);
            this.buttonAjouter.TabIndex = 4;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(492, 49);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(158, 29);
            this.buttonModifier.TabIndex = 5;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(492, 118);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(158, 29);
            this.buttonSupprimer.TabIndex = 6;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonRechercher
            // 
            this.buttonRechercher.Location = new System.Drawing.Point(492, 84);
            this.buttonRechercher.Name = "buttonRechercher";
            this.buttonRechercher.Size = new System.Drawing.Size(158, 28);
            this.buttonRechercher.TabIndex = 7;
            this.buttonRechercher.Text = "Rechercher";
            this.buttonRechercher.UseVisualStyleBackColor = true;
            this.buttonRechercher.Click += new System.EventHandler(this.button4_Click);
            // 
            // CategoriesTable
            // 
            this.CategoriesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomCategories,
            this.Id,
            this.DescriptionCategories});
            this.CategoriesTable.Location = new System.Drawing.Point(131, 220);
            this.CategoriesTable.Name = "CategoriesTable";
            this.CategoriesTable.Size = new System.Drawing.Size(535, 177);
            this.CategoriesTable.TabIndex = 8;
            this.CategoriesTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesTable_CellClick);
            // 
            // NomCategories
            // 
            this.NomCategories.HeaderText = "Nom";
            this.NomCategories.Name = "NomCategories";
            this.NomCategories.ReadOnly = true;
            this.NomCategories.Width = 150;
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // DescriptionCategories
            // 
            this.DescriptionCategories.HeaderText = "Description";
            this.DescriptionCategories.Name = "DescriptionCategories";
            this.DescriptionCategories.ReadOnly = true;
            this.DescriptionCategories.Width = 340;
            // 
            // ListCategories
            // 
            this.ListCategories.Location = new System.Drawing.Point(131, 188);
            this.ListCategories.Name = "ListCategories";
            this.ListCategories.Size = new System.Drawing.Size(158, 26);
            this.ListCategories.TabIndex = 9;
            this.ListCategories.Text = "Listes Categories";
            this.ListCategories.UseVisualStyleBackColor = true;
            this.ListCategories.Click += new System.EventHandler(this.ListCategories_Click);
            // 
            // GestionCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ListCategories);
            this.Controls.Add(this.CategoriesTable);
            this.Controls.Add(this.buttonRechercher);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.NomText);
            this.Controls.Add(this.CategorieDesclabel);
            this.Controls.Add(this.CategorieNomlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionCategories";
            this.ShowIcon = false;
            this.Text = "GestionCategories";
            
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CategorieNomlabel;
        private System.Windows.Forms.Label CategorieDesclabel;
        private System.Windows.Forms.TextBox NomText;
        private System.Windows.Forms.TextBox DescriptionText;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonRechercher;
        private System.Windows.Forms.DataGridView CategoriesTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionCategories;
        private System.Windows.Forms.Button ListCategories;
    }
}