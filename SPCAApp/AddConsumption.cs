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

            rtbOutputAddConsumption.Text = animalManager.AnimalReceipts();


            //This will create a custom datasource for the DataGridView.
            var transactionsDataSource = animalManager.GetAnimals().Select(x => new
            {
                name = x.GetName(),
                species = x.GetSpecies(),
        
            }).ToList();

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
    }
}
