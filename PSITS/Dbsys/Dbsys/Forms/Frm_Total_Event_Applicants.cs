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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Dbsys.Forms
{
    public partial class Frm_Total_Applicants : Form
    {
        DBSYSEntities db;
        UserRepository userRepo;
        public Frm_Total_Applicants()
        {
            InitializeComponent();
            userRepo = new UserRepository();
            db = new DBSYSEntities();   
        }

        private void Frm_Total_Applicants_Load(object sender, EventArgs e)
        {
            loadCbBoxYearLevel();
        }

     

        public void loadCbBoxYearLevel()
        {

            var eventNames = db.Events.ToList();

            cbboxYrLvl.ValueMember = "eventId";
            cbboxYrLvl.DisplayMember = "eventName";
            cbboxYrLvl.DataSource = eventNames;

        }

        private void cbboxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Events selectedEvent = (Events)cbboxYrLvl.SelectedItem;
                string selectedValue = selectedEvent.eventName;

                Console.WriteLine($"Selected value: {selectedValue}");

                String strOutputMsg = "";

                DataTable dataTable = userRepo.FilterEvent(selectedValue, ref strOutputMsg);

                if (dataTable != null)
                {
                    dgvEventSales.DataSource = dataTable;
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
