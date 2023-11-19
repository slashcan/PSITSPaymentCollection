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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Dbsys.Forms
{
    public partial class Frm_Receive_Payment : Form
    {
        DBSYSEntities db;
        public Frm_Receive_Payment()
        {
            InitializeComponent();

            db = new DBSYSEntities();
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            //if (String.IsNullOrEmpty(txtUsername.Text))
            //{
            //    errorProvider1.SetError(txtUsername, "Empty field");
            //    return;
            //}
            //if (String.IsNullOrEmpty(txtPassword.Text))
            //{
            //    errorProvider1.Clear();
            //    errorProvider1.SetError(txtPassword, "Empty field");
            //    return;
            //}
            //if (String.IsNullOrEmpty(txtRepassword.Text))
            //{
            //    errorProvider1.Clear();
            //    errorProvider1.SetError(txtPassword, "Empty field");
            //    return;
            //}

            //if (!txtPassword.Text.Equals(txtRepassword.Text))
            //{
            //    errorProvider1.Clear();
            //    errorProvider1.SetError(txtRepassword, "Password not match");
            //    return;
            //}
            // int code = 123;
            // send email verificode (code)
            // send sms otp (code)

            // find the user id
            // code input equal db. useraccoutn code
            payment newpayment = new payment();
            newpayment.userName = txtuserName.Text;
            newpayment.userIdNumber = txtidNumber.Text;
            newpayment.yearLvl = cbboxYrLvl.Text;
            newpayment.eventName = cbboxEvent.Text;
            newpayment.eventPrice = Convert.ToInt32(txtAmount.Text);         


            db.payment.Add(newpayment);
            db.SaveChanges();

            txtuserName.Clear();
            txtidNumber.Clear();
     
            txtAmount.Clear();

            MessageBox.Show("Registered!");
        }

        private void Frm_Receive_Payment_Load(object sender, EventArgs e)
        {
            loadCbBoxYearLevel();
            loadCbBoxEvent();
        }

        public void loadCbBoxYearLevel()
        {
           
            var yearlevel = db.YearLevel.ToList();

            cbboxYrLvl.ValueMember = "yrId";
            cbboxYrLvl.DisplayMember = "yrName";
            cbboxYrLvl.DataSource = yearlevel;

        }

        public void loadCbBoxEvent()
        {
           
            var events = db.Events.ToList();

            cbboxEvent.ValueMember = "yrId";
            cbboxEvent.DisplayMember = "eventName";
            cbboxEvent.DataSource = events;

        }

        private void cbboxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
