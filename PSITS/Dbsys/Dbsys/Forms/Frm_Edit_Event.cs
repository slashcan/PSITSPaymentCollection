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
    public partial class Frm_Edit_Event : Form
    {
        UserRepository userRepo;
        int? userSelectedId = null;
        public Frm_Edit_Event()
        {
            userRepo= new UserRepository();
            InitializeComponent();
            loadEvents();
        }

        private void Frm_Edit_Event_Load(object sender, EventArgs e)
        {

        }

        public void loadEvents()
        {
            dgvEvents.DataSource = userRepo.ShowEvents();
            dgvEvents.Columns["eventId"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Frm_Admin_Dashboard().Show();
            this.Hide();
        }

        private void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEvents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userSelectedId = (Int32)dgvEvents.Rows[e.RowIndex].Cells[0].Value;
                txtEvent.Text = dgvEvents.Rows[e.RowIndex].Cells[1].Value as String;

                DateTime eventDate = (DateTime)dgvEvents.Rows[e.RowIndex].Cells[2].Value;
                dateTimePicker1.Value = eventDate;

                int price = (int)dgvEvents.Rows[e.RowIndex].Cells[3].Value;
                txtPrice.Text = price.ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String eventName = txtEvent.Text;
            DateTime eventDate = dateTimePicker1.Value;
            int price = Convert.ToInt32(txtPrice.Text);

            String strOutputMsg = "";
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(eventName))
            {
                errorProviderCustom.SetError(txtEvent, "Empty Field!");
                return;
            }
            else
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                errorProviderCustom.SetError(txtPrice, "Empty Field!");
                return;
            }
            var Events = userRepo.GetUserByUsername(eventName);

            ErrorCode retValue = userRepo.UpdateEvent(userSelectedId, txtEvent.Text, dateTimePicker1.Value, Convert.ToInt32(txtPrice.Text), ref strOutputMsg);
            if (retValue == ErrorCode.Success)
            {
                //Clear the errors
                //errorProviderCustom.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadEvents();
                //reset the selected id
                userSelectedId = null;


                txtEvent.Clear();
                txtPrice.Clear();
            }
            else
            {
                // error 
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            String strOutputMsg = "";
            if (userSelectedId == null)
            {
                MessageBox.Show("No Event Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ErrorCode retValue = userRepo.RemoveEvent(userSelectedId, ref strOutputMsg);
            if (retValue == ErrorCode.Success)
            {
                //Clear the errors
                //errorProviderCustom.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadEvents();
                //reset the selected id
                userSelectedId = null;

                txtEvent.Clear();
                txtPrice.Clear();
            }
            else
            {
                // error 
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
