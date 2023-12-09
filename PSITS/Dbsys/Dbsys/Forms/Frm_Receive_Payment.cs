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

            if(eventRadio.Checked)
            {
                PaymentForEvent newpayment = new PaymentForEvent();                     
                    newpayment.userName = txtuserName.Text;
                    newpayment.userIdNumber = txtidNumber.Text;
                    newpayment.yearLvl = cbboxYrLvl.Text;
                    newpayment.eventName = cbboxEvent.Text;
                    newpayment.paymentDate = paymentDay.Value;
                    newpayment.eventPrice = Convert.ToInt32(txtAmount.Text);
                db.PaymentForEvent.Add(newpayment);         

                payment overallpayment = new payment();

                    overallpayment.userName = txtuserName.Text;
                    overallpayment.userIdNumber = txtidNumber.Text;
                    overallpayment.yearLvl = cbboxYrLvl.Text;
                    overallpayment.paymentFor = cbboxEvent.Text;
                    overallpayment.paymentDate = paymentDay.Value;
                    overallpayment.eventPrice = Convert.ToInt32(txtAmount.Text);
                db.payment.Add(overallpayment);
                db.SaveChanges();


                txtuserName.Clear();
                txtidNumber.Clear();

                txtAmount.Clear();

                MessageBox.Show("Registered!");
            }
            else
            {
                PaymentForMisc newpayment = new PaymentForMisc();
                newpayment.userName = txtuserName.Text;
                newpayment.userIdNumber = txtidNumber.Text;
                newpayment.yearLvl = cbboxYrLvl.Text;
                newpayment.miscName = cbboxMisc.Text;
                newpayment.paymentdate = paymentDay.Value;
                newpayment.miscPrice = Convert.ToInt32(txtAmount.Text);
                db.PaymentForMisc.Add(newpayment);

                payment overallpayment = new payment();

                overallpayment.userName = txtuserName.Text;
                overallpayment.userIdNumber = txtidNumber.Text;
                overallpayment.yearLvl = cbboxYrLvl.Text;
                overallpayment.paymentFor = cbboxMisc.Text;
                overallpayment.paymentDate = paymentDay.Value;
                overallpayment.eventPrice = Convert.ToInt32(txtAmount.Text);
                db.payment.Add(overallpayment);
                db.SaveChanges();


                txtuserName.Clear();
                txtidNumber.Clear();

                txtAmount.Clear();

                MessageBox.Show("Registered!");

            }




        }

        private void Frm_Receive_Payment_Load(object sender, EventArgs e)
        {
            loadCbBoxYearLevel();
           // loadCbBoxEvent();
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

            if(eventRadio.Checked)
            {
                var events = db.Events.ToList();

                cbboxEvent.ValueMember = "yrId";
                cbboxEvent.DisplayMember = "eventName";
                cbboxEvent.DataSource = events;
            }

            else
            {
                var events2 = db.Misc.ToList();

                cbboxEvent.ValueMember = "miscId";
                cbboxEvent.DisplayMember = "miscName";
                cbboxEvent.DataSource = events2;
            }
        }

        private void cbboxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtuserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void eventRadio_CheckedChanged(object sender, EventArgs e)
        {
            cbboxEvent.Visible= true;
            cbboxMisc.Visible = false;
            var events = db.Events.ToList();

            cbboxEvent.ValueMember = "yrId";
            cbboxEvent.DisplayMember = "eventName";
            cbboxEvent.DataSource = events;
        }

        private void miscRadio_CheckedChanged(object sender, EventArgs e)
        {
            cbboxEvent.Visible = false;
            cbboxMisc.Visible = true;
            var events2 = db.Misc.ToList();

            cbboxMisc.ValueMember = "miscId";
            cbboxMisc.DisplayMember = "miscName";
            cbboxMisc.DataSource = events2;
        }
    }
}
