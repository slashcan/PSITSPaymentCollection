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
    public partial class Frm_Student_Status : Form
    {
        UserRepository userRepo;
        DBSYSEntities db;
        public Frm_Student_Status()
        {
            InitializeComponent();

            db = new DBSYSEntities();
            userRepo = new UserRepository();
        }

        private void Frm_Student_Status_Load(object sender, EventArgs e)
        {
            statusDgv.DataSource = userRepo.ShowStatus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {



            var paymentIdInput = searchTxt.Text;

            // Try to parse the user input to an integer
            if (int.TryParse(paymentIdInput, out var numericPaymentId))
            {
                // Search for paymentId using the parsed numeric value
                var searchResult = db.payment
                    .Where(p => p.paymentId == numericPaymentId || p.userIdNumber.Contains(paymentIdInput))
                    .ToList();

                // Display the results in the DataGridView
                statusDgv.DataSource = searchResult;
            }
            else
            {
                var combinedResults = db.payment
                    .Where(p => p.userName.Contains(searchTxt.Text) ||
                                p.userIdNumber.Contains(searchTxt.Text) ||
                                p.yearLvl.Contains(searchTxt.Text) ||
                                p.paymentFor.Contains(searchTxt.Text))
                    .ToList();

                // Display the combined results in the DataGridView
                statusDgv.DataSource = combinedResults;

                // Handle non-numeric input or other cases as needed
                // For example, you might want to display an error message or handle it differently.
                Console.WriteLine("Invalid paymentId input. Please enter a valid numeric value.");
            }


        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_Total_Sales_Events().Show();    
        }

        private void miscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_Total_Sales_Misc().Show();  
        }

        private void eventsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Frm_Total_Applicants().Show();
        }
    }
}
