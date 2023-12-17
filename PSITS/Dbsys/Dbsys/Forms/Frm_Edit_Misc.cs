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
    public partial class Frm_Edit_Misc : Form
    {
        UserRepository userRepo;
        int? userSelectedId = null;

        public Frm_Edit_Misc()
        {
            userRepo= new UserRepository();
            InitializeComponent();
            loadMisc();
        }

        private void loadMisc()
        {
            dgvMisc.DataSource = userRepo.ShowMisc();
            dgvMisc.Columns["miscId"].Visible = false;
        }

        private void dgvMisc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userSelectedId = (Int32)dgvMisc.Rows[e.RowIndex].Cells[0].Value;
                txtMisc.Text = dgvMisc.Rows[e.RowIndex].Cells[1].Value as String;
                int price = (int)dgvMisc.Rows[e.RowIndex].Cells[2].Value;
                txtPrice.Text = price.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception : {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String miscname = txtMisc.Text;
            String miscprice = txtPrice.Text;

            String strOutputMsg = "";
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(miscname))
            {
                errorProviderCustom.SetError(txtMisc, "Empty Field!");
                return;
            }
            else
            // Validation not allow empty or null value
            if (String.IsNullOrEmpty(txtPrice.Text))
            {
                errorProviderCustom.SetError(txtPrice, "Empty Field!");
                return;
            }
            var userAccount = userRepo.GetUserByUsername(miscname);

            ErrorCode retValue = userRepo.UpdateMisc(userSelectedId, txtMisc.Text, Convert.ToInt32(txtPrice.Text), ref strOutputMsg);
            if (retValue == ErrorCode.Success)
            {
                //Clear the errors
               // errorProviderCustom.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadMisc();
                //reset the selected id
                userSelectedId = null;


                txtPrice.Clear();
                txtMisc.Clear();
            }
            else
            {
                // error 
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Frm_Admin_Dashboard().Show();
            this.Hide();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            String strOutputMsg = "";
            if (userSelectedId == null)
            {
                MessageBox.Show("No Event Selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ErrorCode retValue = userRepo.RemoveMisc(userSelectedId, ref strOutputMsg);
            if (retValue == ErrorCode.Success)
            {
                //Clear the errors
                //errorProviderCustom.Clear();
                MessageBox.Show(strOutputMsg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadMisc(); ;
                //reset the selected id
                userSelectedId = null;

                txtMisc.Clear();
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
