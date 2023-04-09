using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStocks
{
    public partial class GestionSales : Form
    {
        Sales S = new Sales();
        public GestionSales(MDI mdi)
        {
            InitializeComponent();
            MdiParent = mdi;
            Dock = DockStyle.Fill;
            TopLevel = false;
            prods_clnts();
            Initializer();

            S.Id = "0";
        }
        private void prods_clnts()
        {
            List<Client> c = Client.Select();
            foreach (Client c2 in c)
            {
                NClient.Items.Add(c2.name);
            }
            List<Produits> p = Produits.Select();
            foreach (Produits p2 in p)
            {
                NProduit.Items.Add(p2.nom);
            }
        }
        private void Initializer()
        {
            RemplireSalesTable(Sales.Select());
        }
        private void RemplireSalesTable(List<Sales> s)
        {
            try { 
                SalesTable.Rows.Clear();
                
                s.Reverse();
                foreach (Sales sale in s)
                {
                    sale.Prix = Produits.searchByName(sale.NomProduit).prix;
                    var row = new DataGridViewRow();
                    row.CreateCells(SalesTable);
                    row.Cells[0].Value = sale.NomClient;
                    row.Cells[1].Value = sale.NomProduit;
                    row.Cells[2].Value = sale.Quantite;
                    row.Cells[3].Value = sale.Prix;
                    row.Cells[4].Value = sale.Prix * sale.Quantite;
                    row.Cells[5].Value = sale.Id;
                    SalesTable.Rows.Add(row);
                }
             }catch(Exception ex) { 
                    MessageBox.Show(ex.ToString()); }
        }
        private void GestionSales_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ProduitsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void ClientTBOX_TextChanged(object sender, EventArgs e)
        {

        }
        private void ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                if (NProduit.SelectedItem.ToString() != null && NClient.SelectedItem.ToString() != null && Convert.ToInt32(NQuantite.Value) != 0)
                {
                    Produits p = Produits.searchByName(NProduit.SelectedItem.ToString());
                    int q = Convert.ToInt32(NQuantite.Value);
                    if (q <= p.quantite)
                    {
                        if (new Sales(NClient.SelectedItem.ToString(), p.nom, q, p.prix).Create() == null)
                            MessageBox.Show("achat echoue");
                        MessageBox.Show("BSAHA WRAHA");
                        Initializer();
                        p.quantite = p.quantite-q;
                        p.Update();
                    } 
                    else MessageBox.Show("Quantite superieur au stock");

                }
                else if(Convert.ToInt32(NQuantite.Value) == 0)MessageBox.Show("li machra yetnezah");
            }
            catch (Exception ex) { MessageBox.Show("achat echoue"); }
        }
        private void NClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void Modifier_Click(object sender, EventArgs e)
        {
            Produits p = Produits.searchByName(NProduit.SelectedItem.ToString());
            if (S.Id != null)
            {
                S.NomClient = NClient.Text;
                S.NomProduit = NProduit.Text;
                S.Quantite = Convert.ToInt32(NQuantite.Value);
                if (S.Quantite <= p.quantite) {
                    if (S.Update() == null)
                        MessageBox.Show("Erreur! choisir depuis la table, et aprés modifier");
                    else
                    {
                        MessageBox.Show("votre commande  Mr." + NClient.Text + " est bien Modifie");
                        Initializer();
                        p.quantite = p.quantite - S.Quantite;
                        p.Update();
                    }
                }
                else MessageBox.Show("Quantite superieur au stock");
            }
        }
        private void NQuantite_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Produits p = Produits.searchByName(NProduit.SelectedItem.ToString());
                if (NProduit.SelectedItem.ToString() != null)
                    TotalTBOX.Text = " درهم " + (p.prix * Convert.ToInt32(NQuantite.Value)).ToString();
            }
            catch { MessageBox.Show("choisir un produit"); }

        }
        private void NProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
                Produits p = Produits.searchByName(NProduit.SelectedItem.ToString());
                if (NProduit.SelectedItem.ToString() != null)
                    TotalTBOX.Text = " درهم " + (p.prix * Convert.ToInt32(NQuantite.Value)).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void SalesTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = SalesTable.Rows[e.RowIndex];

            NClient.Text = row.Cells[0].Value.ToString();
            NProduit.Text = row.Cells[1].Value.ToString();
            NQuantite.Value = decimal.Parse(row.Cells[2].Value.ToString());
            TotalTBOX.Text = row.Cells[4].Value.ToString();
            S.Id = row.Cells[5].Value.ToString();
            Console.WriteLine(S.Id);
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            if (NClient.Text != null)
            {
                List<Sales> listsales = new List<Sales>();

                listsales = Sales.Select();
                foreach (Sales s in listsales)
                {
                    if (s.NomClient == NClient.Text)
                    {
                        NProduit.Text = s.NomProduit;
                        NQuantite.Value = s.Quantite;
                    }
                }
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("vous voulez supprimer le Produit " + NClient.Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            Produits p = Produits.searchByName(NProduit.SelectedItem.ToString());
            if (result == DialogResult.Yes)
            {
                if (NClient.Text != null)
                {
                    S.NomClient = NClient.Text;
                    S.NomProduit= NProduit.Text;
                    S.Prix = p.prix;
                    S.Quantite = Convert.ToInt32(NQuantite.Value);

                    if (S.Delete() == null)
                        MessageBox.Show("Erreur! choisir depuis la table");
                    else
                    {
                        MessageBox.Show(NClient.Text + " est bien supprimé");
                        Initializer();
                    }
                }
            }
        }
    }
}
