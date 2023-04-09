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
        Sales C = new Sales();
        public GestionSales(MDI mdi)
        {
            InitializeComponent();
            MdiParent = mdi;
            Dock = DockStyle.Fill;
            TopLevel = false;
            prods_clnts();
            Initializer();

            C.Id = "0";
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
                List<Sales> Sales = s;
                Sales.Reverse();
                foreach (Sales sale in Sales)
                {
                    var row = new DataGridViewRow();
                    row.CreateCells(SalesTable);
                    row.Cells[0].Value = sale.NomClient;
                    row.Cells[1].Value = sale.NomProduit;
                    row.Cells[2].Value = sale.Quantite;
                    Produits prod = Produits.searchByName(sale.NomProduit);
                    row.Cells[3].Value = prod.prix;
                    row.Cells[4].Value = prod.prix * sale.Quantite;
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
                    if (new Sales(NClient.SelectedItem.ToString(), p.nom, Convert.ToInt32(NQuantite.Value), p.prix).Create() == null)
                        MessageBox.Show("achat echoue");
                    MessageBox.Show("BSAHA WRAHA");
                    Initializer();
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
            if (C.Id != null)
            {
                C.NomClient = NClient.SelectedItem.ToString();
                C.NomProduit = NProduit.SelectedItem.ToString();
                C.Quantite = Convert.ToInt32(NQuantite.Value);
                if (C.Update() == null)
                    MessageBox.Show("Erreur! choisir depuis la table, et aprés modifier");
                else
                {
                    MessageBox.Show("L'achat est bien Modifiée");
                }


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

    }
}
