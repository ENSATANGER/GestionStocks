using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStocks
{
    public partial class GestionClients : Form
    {
        Client C = new Client();

        public GestionClients(MDI mdi)
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
            Name.Text = "";
            Telephone.Text = "";
            Address.Text = "";
            RemplireClientsTable(Client.Select());
        }

        private void RemplireClientsTable(List<Client> c)
        {
            ClientsGrid.Rows.Clear();
            List<Client> clients = c;
            clients.Reverse();
            foreach (Client client in clients)
            {
                var row = new DataGridViewRow();
                row.CreateCells(ClientsGrid);
                row.Cells[0].Value = client.Id;
                row.Cells[1].Value = client.name;
                row.Cells[2].Value = client.telephone;
                row.Cells[3].Value = client.address;

                ClientsGrid.Rows.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Name.Text))
            {
                if ((new Client(Name.Text, Telephone.Text, Address.Text)).Create() == null)
                    MessageBox.Show("ce client déjà existe ");
                else
                    Initializer();
            }
            else
                MessageBox.Show("Erreur! Inserer le Nom");
        }

        private void GestionClients_Load(object sender, EventArgs e)
        {
            
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Name.Text) && C.Id != "0")
            {
                C.name = Name.Text;
                C.telephone = Telephone.Text;
                if (C.Update() == null)
                    MessageBox.Show("Erreur! choisir depuis la table, et aprés modifier");
                else
                    Initializer();
            }
            else
                MessageBox.Show("Erreur! choisir depuis la table, et aprés modifier");
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Name.Text) && C.Id != "0")
            {
                DialogResult result = MessageBox.Show("vous voulez supprimer la categories " + Name.Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (C.Delete() == null)
                        MessageBox.Show("Erreur! choisir depuis la table");
                    else
                    {
                        MessageBox.Show(Name.Text + " est bien supprimé");
                        Initializer();
                    }
                }
            }
            else
                MessageBox.Show("Erreur! choisir depuis la table");
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Name.Text))
            {
                C.name = Name.Text;
                List<Client> catList = C.search(C.name);
                if (catList.Count == 0)
                    MessageBox.Show("ce Client n'existe pas");
                else
                {
                    RemplireClientsTable(catList);
                }
            }
            else
                MessageBox.Show("Erreur! Inserer le Nom");
        }

        private void ClientsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Initializer();  
            // Get the DataGridViewRow object of the clicked row
            DataGridViewRow row = ClientsGrid.Rows[e.RowIndex];

            // Access the data in the row using the column names or indexes
            Name.Text = row.Cells[1].Value.ToString();
            Telephone.Text = row.Cells[2].Value.ToString();
            Address.Text = row.Cells[3].Value.ToString();

            C.Id = row.Cells[0].Value.ToString();
            C.name = Name.Text;
            C.telephone = Telephone.Text;
            C.address = Address.Text;


        }
    }
}
