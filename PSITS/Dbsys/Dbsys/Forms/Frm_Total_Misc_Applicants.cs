using Dbsys.AppData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbsys.Forms
{
    public partial class Frm_Total_Misc_Applicants : Form
    {
        DBSYSEntities db;
        UserRepository userRepo;

        public Frm_Total_Misc_Applicants()
        {
            InitializeComponent();

            userRepo = new UserRepository();
            db = new DBSYSEntities();
        }

        private void Frm_Total_Misc_Applicants_Load(object sender, EventArgs e)
        {
            loadCbBoxYearLevel();
        }

        public void loadCbBoxYearLevel()
        {

            var miscNames = db.Misc.ToList();

            cbboxYrLvl.ValueMember = "miscId";
            cbboxYrLvl.DisplayMember = "miscName";
            cbboxYrLvl.DataSource = miscNames;

        }

        private void cbboxYrLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Misc selectedMisc = (Misc)cbboxYrLvl.SelectedItem;
                string selectedValue = selectedMisc.miscName;

                Console.WriteLine($"Selected value: {selectedValue}");

                String strOutputMsg = "";

                DataTable dataTable = userRepo.FilterMisc(selectedValue, ref strOutputMsg);

                if (dataTable != null)
                {
                    dgvMiscSales.DataSource = dataTable;
                }
                else
                {
                    Console.WriteLine("FilterEvent method did not return a DataTable");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
