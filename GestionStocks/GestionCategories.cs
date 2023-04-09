using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStocks
{
    public partial class GestionCategories : Form
    {
        Categorie C = new Categorie();
        public GestionCategories(MDI mdi)
        {
            InitializeComponent();
            MdiParent = mdi;
            Dock = DockStyle.Fill;
            TopLevel = false;
            Initializer();
            C.Id = "0";
        }
        private void Initializer()
        {
            NomText.Text = "";
            DescriptionText.Text = "";
            RemplireCategoriesTable(Categorie.Select());
        }
        private void RemplireCategoriesTable(List<Categorie> c)
        {
            CategoriesTable.Rows.Clear();
            List<Categorie> categories = c;
            categories.Reverse();
            foreach(Categorie category in categories)
            {
                var row = new DataGridViewRow();
                row.CreateCells(CategoriesTable);
                row.Cells[0].Value = category.nom;
                row.Cells[1].Value = category.Id;
                row.Cells[2].Value = category.description;
                
                CategoriesTable.Rows.Add(row);
            }
        }

        //boutton Ajouter
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NomText.Text))
            {
                if ((new Categorie(NomText.Text, DescriptionText.Text)).Create() == null)
                    MessageBox.Show("cet Categorie existe déja");
                else
                    Initializer();
            }
            else
                MessageBox.Show("Erreur! Inserer le Nom");
        }

        private void CategoriesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Get the DataGridViewRow object of the clicked row
            DataGridViewRow row = CategoriesTable.Rows[e.RowIndex];

            // Access the data in the row using the column names or indexes
            NomText.Text = row.Cells[0].Value.ToString();
            DescriptionText.Text = row.Cells[2].Value.ToString();

            C.nom = NomText.Text;
            C.description = DescriptionText.Text;
            C.Id = row.Cells[1].Value.ToString();
        }

        //boutton Modifier
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NomText.Text) && C.Id != "0")
            {
                C.nom = NomText.Text;
                C.description = DescriptionText.Text;
                if (C.Update() == null)
                    MessageBox.Show("Erreur! choisir depuis la table, et aprés modifier");
                else
                    Initializer();
            }
            else
                MessageBox.Show("Erreur! choisir depuis la table, et aprés modifier");
        }

        //boutton Rechercher
        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NomText.Text))
            {
                C.nom = NomText.Text;
                List<Categorie> catList = C.search(C.nom);
                if (catList.Count == 0)
                    MessageBox.Show("cet Categorie n'existe pas");
                else
                {
                    RemplireCategoriesTable(catList);
                }
            }
            else
                MessageBox.Show("Erreur! Inserer le Nom");
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NomText.Text) && C.Id != "0")
            {
                DialogResult result = MessageBox.Show("vous voulez supprimer la categories " + NomText.Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (C.Delete() == null)
                        MessageBox.Show("Erreur! choisir depuis la table");
                    else
                    {
                        MessageBox.Show(NomText.Text + " est bien supprimé");
                        Initializer();
                    }
                }
            }
            else
                MessageBox.Show("Erreur! choisir depuis la table");
        }

        private void ListCategories_Click(object sender, EventArgs e)
        {
            Initializer();
        }

        private void GestionCategories_Load(object sender, EventArgs e)
        {

        }

        private void GestionCategories_Load_1(object sender, EventArgs e)
        {

        }
    }
}
