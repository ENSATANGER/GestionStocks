using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStocks
{
    public partial class GestionProduits : Form
    {
        Produits prod = new Produits();
        public GestionProduits()
        {
            InitializeComponent();
            GestionProduits_Load();
        }

        private void RemplireProduitsTable(List<Produits> prod)
        {
            ProduitsTable.Rows.Clear();
            List<Produits> produits = prod;
            produits.Reverse();
            foreach (Produits produit in produits)
            {
                var row = new DataGridViewRow();
                row.CreateCells(ProduitsTable);
                row.Cells[0].Value = produit.nom;
                row.Cells[1].Value = produit.categorie;
                row.Cells[2].Value = produit.quantite;
                row.Cells[3].Value = produit.poids;
                row.Cells[4].Value = produit.prix;
                row.Cells[5].Value = produit.description;

                ProduitsTable.Rows.Add(row);
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if(tnom.Text!=null && categoriebox.Text!=null && float.Parse(tpoids.Text)>=0 && float.Parse(tprix.Text)>=0)
            {
                if ((new Produits(tnom.Text,categoriebox.Text, Description.Text, float.Parse(tprix.Text), float.Parse(tpoids.Text), (int)nquantite.Value)).Create() == null)
                    MessageBox.Show("Ce produit existe deja!");
                else
                    GestionProduits_Load();
            }
        }

        private void GestionProduits_Load()
        {
            tnom.Text = string.Empty;
            Description.Text = string.Empty;
            categoriebox.Text = string.Empty;
            tpoids.Text = "0";
            tprix.Text = "0";

            List<Categorie> listcategories = new List<Categorie>();
            listcategories = Categorie.Select();
            foreach (Categorie categorie in listcategories)
            {
                categoriebox.Items.Add(categorie.nom);
            }
            RemplireProduitsTable(Produits.Select());
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (tnom.Text != null &&  prod.Id != "0")
            {
                prod.nom = tnom.Text;
                prod.categorie = categoriebox.Text;
                prod.description = Description.Text;
                prod.prix = float.Parse(tprix.Text);
                prod.poids = float.Parse(tpoids.Text);
                prod.quantite = (int)nquantite.Value;
                if (prod.Update() == null)
                    MessageBox.Show("Erreur! choisir depuis la table, et aprés modifier");
                else
                    GestionProduits_Load();
                
            }
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            if (tnom.Text != null)
            {
                List<Produits> listprod = new List<Produits>();

                listprod = Produits.Select();
                foreach (Produits prod in listprod)
                {
                    if(prod.nom == tnom.Text)
                    {
                        categoriebox.Text = prod.categorie;
                        nquantite.Value = prod.quantite;
                        tpoids.Text = prod.poids.ToString();
                        tprix.Text = prod.prix.ToString();
                        Description.Text = prod.description;

                    }
                }
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("vous voulez supprimer le Produit " + tnom.Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (tnom.Text != null)
                {
                    prod.nom = tnom.Text;
                    prod.categorie = categoriebox.Text;
                    prod.description = Description.Text;
                    prod.prix = float.Parse(tprix.Text);
                    prod.poids = float.Parse(tpoids.Text);
                    prod.quantite = (int)nquantite.Value;

                    if (prod.Delete() == null)
                        MessageBox.Show("Erreur! choisir depuis la table");
                    else
                    {
                        MessageBox.Show(tnom.Text + " est bien supprimé");
                        GestionProduits_Load();
                    }
                }
            }
                
        }

        private void ProduitsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ProduitsTable.Rows[e.RowIndex];

            if(row.Cells[0].Value!=null)
                tnom.Text = row.Cells[0].Value.ToString();
            if(row.Cells[1].Value!=null)
                categoriebox.Text = row.Cells[1].Value.ToString();
            if(row.Cells[2].Value != null)
                nquantite.Value = decimal.Parse(row.Cells[2].Value.ToString());
            if(row.Cells[3].Value != null)
                tpoids.Text = row.Cells[3].Value.ToString();
            if (row.Cells[4].Value != null)
                tprix.Text = row.Cells[4].Value.ToString();
            if(row.Cells[5].Value != null)
                Description.Text = row.Cells[5].Value.ToString();








        }

        private void GestionProduits_Load(object sender, EventArgs e)
        {
            tnom.Text = string.Empty;
            Description.Text = string.Empty;
            categoriebox.Text = string.Empty;
            tpoids.Text = "0";
            tprix.Text = "0";

            List<Categorie> listcategories = new List<Categorie>();
            listcategories = Categorie.Select();
            foreach (Categorie categorie in listcategories)
            {
                categoriebox.Items.Add(categorie.nom);
            }
            RemplireProduitsTable(Produits.Select());
        }
    }
}
