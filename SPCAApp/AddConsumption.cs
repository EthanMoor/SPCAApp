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
