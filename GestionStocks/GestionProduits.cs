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
        public GestionProduits()
        {
            InitializeComponent();
        }

        

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if(tnom.Text!=null && categoriebox.Text!=null && float.Parse(tpoids.Text)>=0 && float.Parse(tprix.Text)>=0)
            {
                if ((new Produits(tnom.Text,categoriebox.Text, Description.Text, float.Parse(tprix.Text), float.Parse(tpoids.Text), (int)nquantite.Value)).Create() == null)
                    MessageBox.Show("Ce produit existe deja!");
                else
                    GestionProduits_Load(sender,e);
            }
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
            foreach(Categorie categorie in listcategories)
            {
                categoriebox.Items.Add(categorie.nom);
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {

        }
    }
}
