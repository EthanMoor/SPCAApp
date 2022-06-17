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
    public partial class AnimalStats : Form
    {
        AnimalManager animalManager;
        public AnimalStats(AnimalManager animalManager)
        {
            this.animalManager = animalManager;
            InitializeComponent();
        }

        private void btnBackAnimalStats_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home window = new Home(animalManager);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
