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
        static Produits prod = new Produits();
        public GestionProduits()
        {
            InitializeComponent();
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
                row.Cells[6].Value = produit.Id;

                ProduitsTable.Rows.Add(row);
            }
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tnom.Text) && !string.IsNullOrWhiteSpace(categoriebox.Text) && float.Parse(tpoids.Text) >= 0 && float.Parse(tprix.Text) >= 0)
            {
                if ((new Produits(tnom.Text, categoriebox.Text, Description.Text, float.Parse(tprix.Text), float.Parse(tpoids.Text), (int)nquantite.Value)).Create() == null)
                    MessageBox.Show("Ce produit existe deja!");
                else
                    GestionProduits_Load();
            }
            else
                MessageBox.Show("ajouet nom et categorie!");
        }

        

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (prod.Id != null )
            {
                prod.nom = tnom.Text;
                prod.categorie = categoriebox.Text;
                prod.quantite = (int)nquantite.Value;
                prod.poids = float.Parse(tpoids.Text);
                prod.prix = float.Parse(tprix.Text);
                prod.description = Description.Text;
                if (prod.Update() == null)
                    MessageBox.Show("Erreur! choisir depuis la table, et aprés modifier");
                else
                {
                    MessageBox.Show(tnom.Text + " est bien Modifie");
                    GestionProduits_Load();
                }
                    
                
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
            tnom.Text = row.Cells[0].Value.ToString();
            categoriebox.Text = row.Cells[1].Value.ToString();
            nquantite.Value = decimal.Parse(row.Cells[2].Value.ToString());
            tpoids.Text = row.Cells[3].Value.ToString();
            tprix.Text = row.Cells[4].Value.ToString();
            Description.Text = row.Cells[5].Value.ToString();


            prod.Id = row.Cells[6].Value.ToString();
            
        }
        private void GestionProduits_Load()
        {
            tnom.Text = null;
            Description.Text = string.Empty;
            categoriebox.Text = null;
            tpoids.Text = "0";
            tprix.Text = "0";
            nquantite.Value = 0;
            prod.Id = null;
            
            RemplireProduitsTable(Produits.Select());
        }
        private void GestionProduits_Load(object sender, EventArgs e)
        {
            List<Categorie> listcategories = new List<Categorie>();
            listcategories = Categorie.Select();
            foreach (Categorie categorie in listcategories)
            {
                categoriebox.Items.Add(categorie.nom);
            }
            GestionProduits_Load();
        }
    }
}
