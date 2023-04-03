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
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new GestionCategories(this)).Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void produitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionProduits newMDIChild = new GestionProduits();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }
    }
}
