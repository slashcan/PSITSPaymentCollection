using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dbsys.AppData;

namespace Dbsys.Forms
{
    public partial class Frm_Register : Form
    {
        public string username = String.Empty;
        DBSYSEntities db; 
        public Frm_Register()
        {
            InitializeComponent();
            //
            db = new DBSYSEntities();
        }

        private void Frm_Register_Load(object sender, EventArgs e)
        {
            loadCbBoxRole();
            yrLevel();
        }

        private void cbBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBoxRole.Text.Equals("Student"))
            {
                yearlvltxt.Visible= true;
                idnumbertxt.Visible = true;
                idnumtxtbox.Visible = true;
                cbBoxYearLevel.Visible = true;
            }
            else
            {
                yearlvltxt.Visible = false;
                idnumbertxt.Visible = false;
                idnumtxtbox.Visible = false;
                cbBoxYearLevel.Visible = false;
            }

        }

        public void loadCbBoxRole()
        {
            // SELECT * FROM ROLE
            var roles = db.Role.ToList();

            cbBoxRole.ValueMember = "roleId";
            cbBoxRole.DisplayMember = "roleName";
            cbBoxRole.DataSource = roles;
          
        }

        public void yrLevel()
        {
            // SELECT * FROM yearLvl
            var yearlvl = db.YearLevel.ToList();

            cbBoxYearLevel.ValueMember = "yrId";
            cbBoxYearLevel.DisplayMember = "yrName";
            cbBoxYearLevel.DataSource = yearlvl;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //String cbResultSelected = cbBoxRole.SelectedValue.ToString();

            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Empty field");
                return;
            }
            if (String.IsNullOrEmpty(txtRepassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtPassword, "Empty field");
                return;
            }

            if (!txtPassword.Text.Equals(txtRepassword.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtRepassword, "Password not match");
                return;
            }
           // int code = 123;
            // send email verificode (code)
            // send sms otp (code)

            // find the user id
            // code input equal db. useraccoutn code
            UserAccount nUserAccount = new UserAccount();
            nUserAccount.userName = txtUsername.Text;
            nUserAccount.userPassword = txtPassword.Text;
            nUserAccount.roleId = (Int32)cbBoxRole.SelectedValue;
            nUserAccount.userStatus = "Active";
            nUserAccount.idNumber = int.Parse(idnumtxtbox.Text);
            nUserAccount.yearLvl = (Int32)cbBoxYearLevel.SelectedValue;

            username = txtUsername.Text;

            db.UserAccount.Add(nUserAccount);
            db.SaveChanges();

            txtPassword.Clear();
            txtRepassword.Clear();
            txtUsername.Clear();
            idnumtxtbox.Clear();
            MessageBox.Show("Registered!");
        }

        private void cbBoxRole_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbBoxRole.DisplayMember.Equals("Student"))
            {
                idnumbertxt.Visible = true;
                idnumtxtbox.Visible = true;
                cbBoxYearLevel.Visible = true;
                

            }
            else
            {
                idnumbertxt.Visible = false;
                idnumtxtbox.Visible = false;
                cbBoxYearLevel.Visible = false;

            }
        }
    }
}
