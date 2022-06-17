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
    public partial class Home : Form
    {
        AnimalManager animalManager;
        public Home(AnimalManager animalManager)
        {
            this.animalManager = animalManager;
            InitializeComponent();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddAnimal window = new AddAnimal(animalManager);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void HomeGUI_Load(object sender, EventArgs e)
        {

        }

        private void btnAddConsumption_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddConsumption window = new AddConsumption(animalManager);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnViewStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnimalStats window = new AnimalStats(animalManager);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
