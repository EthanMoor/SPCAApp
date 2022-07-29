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
        private DataTable dt;
        private DataView dv;
        private static int selectedID = -1;
        public AddConsumption(AnimalManager animalManager)
        {
            this.animalManager = animalManager;
            InitializeComponent();



            // List View properties
            listviewTable.View = View.Details;
            listviewTable.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);


            // Adding Columns
            listviewTable.Columns.Add("ID");
            listviewTable.Columns.Add("Name");
            listviewTable.Columns.Add("Species");

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

        private void PopulateListViewTable(DataView dv)
        {
            listviewTable.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                listviewTable.Items.Add(new ListViewItem(new string[] { row[0].ToString(), row[1].ToString(), row[2].ToString()}));
            }
        }

        private void btnBackAddConsumption_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home window = new Home(animalManager);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnEnterAddConsumption_Click(object sender, EventArgs e)
        {
            animalManager.AddConsumption(selectedID, dtpAddConsumption.Value, Convert.ToInt32(nudAddConsumptionHowMuchEaten.Value));

            rtbOutputAddConsumption.Text = animalManager.GetRecentlyAddedConsumption(dtpAddConsumption.Value, selectedID);
        }

        private void listviewTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewTable.SelectedItems.Count>0)
            {
                 selectedID = Convert.ToInt32(listviewTable.SelectedItems[0].Text);

                 //MessageBox.Show(selectedID + "");
            }
           
           
        }
    }
}