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
    public partial class AddAnimal : Form
    {
        AnimalManager animalManager;
        public AddAnimal(AnimalManager animalManager)
        {
            this.animalManager = animalManager;
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Animal newAnimal = new Animal(txbName.Text, cmbbSpecies.Text);
            animalManager.AddAnimal(newAnimal);

            rtbOutputAddAnimal.Text = animalManager.RecentlyAddedNewAnimal();
        }

        private void btnBackAddAnimal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home window = new Home(animalManager);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
