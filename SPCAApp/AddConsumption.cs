using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPCAAppGui
{
    public partial class AddConsumption : Form
    {
        AnimalManager animalManager;
        public AddConsumption(AnimalManager animalManager)
        {
            this.animalManager = animalManager;
            InitializeComponent();

            //rtbOutputAddConsumption.Text = animalManager.AnimalReceipts();


            //This will create a custom datasource for the DataGridView.
            var transactionsDataSource = animalManager.GetAnimals().Select(x => new
            {
                Id = x.GetId(),
                Name = x.GetName(),
                Species = x.GetSpecies(),
        
            }).ToList();

           
            //foreach (var item in transactionsDataSource)
            //{
             //   dgvAnimalTable.Rows.Add(item.name, item.species);
            //}

           
            //This will assign the datasource. All the columns you listed will show up, and every row
            //of data in the list will populate into the DataGridView.
            dgvAnimalTable.DataSource = transactionsDataSource;

        }

        private void btnBackAddConsumption_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home window = new Home(animalManager);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void dgvAnimalTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rtbOutputAddConsumption.Text = dgvAnimalTable.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnEnterAddConsumption_Click(object sender, EventArgs e)
        {

        }
    }
}
