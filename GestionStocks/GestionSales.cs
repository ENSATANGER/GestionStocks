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
    public partial class GestionSales : Form
    {
        public GestionSales()
        {
            InitializeComponent();
        }

        private void Ajouter(List<Sales> sal)
        {
            SalesTable.Rows.Clear();
            List<Sales> sales = sal;
            sales.Reverse();
                var row = new DataGridViewRow();
                row.CreateCells(SalesTable);
                row.Cells[0].Value = ClientTBOX.Text;
                row.Cells[1].Value = ProduitTBOX.Text;
                row.Cells[2].Value = QuantiteTBOX.Text;
                row.Cells[3].Value = produit.prix;
            int n =  Convert.ToInt32(row.Cells[2].Value * row.Cells[3].Value);
                
                SalesTable.Rows.Add(row);
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
    }
}
