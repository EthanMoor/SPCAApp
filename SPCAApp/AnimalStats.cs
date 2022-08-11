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
        private DataTable dt;
        private DataView dv;

        AnimalManager animalManager;
        
         
        public AnimalStats(AnimalManager animalManager)
        {
            this.animalManager = animalManager;
            InitializeComponent();

            if (txbSearch.Text == "") //If the Search textbox is blank then do the following
            {
                txbSearch.Focus();
            }

            // List View properties
            listviewStats.View = View.Details;
            listviewStats.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


            // Adding Columns
            listviewStats.Columns.Add("ID");
            listviewStats.Columns.Add("Name");
            listviewStats.Columns.Add("Species");

            // Initialise Datatable and add Columns
            dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Species");

            // Getting DataList from Animal Manager
            List<Animal> animals = this.animalManager.GetAnimals();

            foreach (var animal in animals)
            {
                dt.Rows.Add(animal.GetId(), animal.GetName(), animal.GetSpecies());
            }

            // Fill Datatable
            dv = new DataView(dt);
            PopulateListViewTable(dv);


        }

        // Adds values into the list 
        public void PopulateListViewTable(DataView dv)
        {
            listviewStats.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                listviewStats.Items.Add(new ListViewItem(new string[] { row[0].ToString(), row[1].ToString(), row[2].ToString() }));
            }
        }

        // When user types a name, filter the list
        private void txbSearch_TextChanged(object sender, EventArgs e)
        {
            dv.RowFilter = string.Format("Name Like '%{0}%'", txbSearch.Text);

            PopulateListViewTable(dv);
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
