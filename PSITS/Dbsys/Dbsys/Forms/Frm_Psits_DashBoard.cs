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
    
    public partial class Frm_Psits_DashBoard : Form
    {
       
        UserRepository userRepo;

        public Frm_Psits_DashBoard()
        {
            userRepo = new UserRepository();
            InitializeComponent();
            loadEvents();
            loadMisc();
        }

        public void loadEvents()
        {
            dgvEvents.DataSource = userRepo.ShowEvents();
            dgvEvents.Columns["eventId"].Visible = false;
        }

        private void loadMisc()
        {
            dgvMisc.DataSource = userRepo.ShowMisc();
            dgvMisc.Columns["miscId"].Visible = false;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_Add_Event().Show();
            this.Hide();
            
        }

        private void miscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_Add_Misc().Show();
         
        }

        private void checkStudentStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_Student_Status().Show();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_Receive_Payment().Show();
        }

        private void Frm_Psits_DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Psits_DashBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_Login().Show();
            this.Hide();
        }
    }
}
