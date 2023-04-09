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
                /*List<Produits> p = Produits.Select();

                float[] pr = new float[Sales.Count];
                Console.WriteLine("////////////////////");
                Console.WriteLine(Sales.Count);
                Console.WriteLine(p.Count);

                for (int i =0; i < Sales.Count;i++)
                {
                    pr[i] = p[i].prix;
                }*/

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
                if (NProduit.SelectedItem.ToString() != null && NClient.SelectedItem.ToString() != null && NQuantite.Value > 0)
                {
                    Produits p = Produits.searchByName(NProduit.SelectedItem.ToString());
                    if (new Sales(NClient.SelectedItem.ToString(), p.nom, Convert.ToInt32(NQuantite.Value), p.prix).Create() == null)
                        MessageBox.Show("walo makayn");
                    MessageBox.Show("BSAHA WRAHA");
                    Initializer();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void NClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
