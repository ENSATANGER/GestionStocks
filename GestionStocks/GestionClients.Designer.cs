namespace GestionStocks
{
    partial class GestionClients
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
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Rechercher = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.TextBox();
            this.Telephone = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.ClientsGrid = new System.Windows.Forms.DataGridView();
            this.CId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(581, 35);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(178, 30);
            this.Ajouter.TabIndex = 0;
            this.Ajouter.Text = "Ajouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(581, 74);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(178, 30);
            this.Modifier.TabIndex = 1;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(581, 111);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(178, 30);
            this.Supprimer.TabIndex = 2;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // Rechercher
            // 
            this.Rechercher.Location = new System.Drawing.Point(581, 171);
            this.Rechercher.Name = "Rechercher";
            this.Rechercher.Size = new System.Drawing.Size(178, 30);
            this.Rechercher.TabIndex = 3;
            this.Rechercher.Text = "Rechercher";
            this.Rechercher.UseVisualStyleBackColor = true;
            this.Rechercher.Click += new System.EventHandler(this.Rechercher_Click);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(235, 35);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(167, 26);
            this.Name.TabIndex = 4;
            // 
            // Telephone
            // 
            this.Telephone.Location = new System.Drawing.Point(235, 74);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(167, 26);
            this.Telephone.TabIndex = 6;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(235, 111);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(167, 26);
            this.Address.TabIndex = 7;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(56, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(51, 20);
            this.NameLabel.TabIndex = 8;
            this.NameLabel.Text = "Name";
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.AutoSize = true;
            this.TelephoneLabel.Location = new System.Drawing.Point(56, 74);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(84, 20);
            this.TelephoneLabel.TabIndex = 9;
            this.TelephoneLabel.Text = "Telephone";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(56, 111);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(68, 20);
            this.AddressLabel.TabIndex = 10;
            this.AddressLabel.Text = "Address";
            // 
            // ClientsGrid
            // 
            this.ClientsGrid.AllowUserToOrderColumns = true;
            this.ClientsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CId,
            this.CName,
            this.CTelephone,
            this.CAddress});
            this.ClientsGrid.Location = new System.Drawing.Point(27, 171);
            this.ClientsGrid.Name = "ClientsGrid";
            this.ClientsGrid.RowHeadersWidth = 62;
            this.ClientsGrid.RowTemplate.Height = 28;
            this.ClientsGrid.ShowCellErrors = false;
            this.ClientsGrid.Size = new System.Drawing.Size(509, 264);
            this.ClientsGrid.TabIndex = 11;
            this.ClientsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientsGrid_CellContentClick);
            // 
            // CId
            // 
            this.CId.Frozen = true;
            this.CId.HeaderText = "ID";
            this.CId.MinimumWidth = 8;
            this.CId.Name = "CId";
            this.CId.ReadOnly = true;
            this.CId.Visible = false;
            this.CId.Width = 150;
            // 
            // CName
            // 
            this.CName.Frozen = true;
            this.CName.HeaderText = "Name";
            this.CName.MinimumWidth = 8;
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Width = 150;
            // 
            // CTelephone
            // 
            this.CTelephone.Frozen = true;
            this.CTelephone.HeaderText = "Telephone";
            this.CTelephone.MinimumWidth = 8;
            this.CTelephone.Name = "CTelephone";
            this.CTelephone.ReadOnly = true;
            this.CTelephone.Width = 150;
            // 
            // CAddress
            // 
            this.CAddress.Frozen = true;
            this.CAddress.HeaderText = "Address";
            this.CAddress.MinimumWidth = 8;
            this.CAddress.Name = "CAddress";
            this.CAddress.ReadOnly = true;
            this.CAddress.Width = 150;
            // 
            // GestionClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClientsGrid);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.TelephoneLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Rechercher);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GestionClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Rechercher;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Telephone;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TelephoneLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.DataGridView ClientsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAddress;
    }
}