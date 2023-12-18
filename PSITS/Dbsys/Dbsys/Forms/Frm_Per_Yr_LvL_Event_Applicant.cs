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
    public partial class Frm_Per_Yr_LvL_Event_Applicant : Form
    {
        DBSYSEntities db;
        UserRepository userRepo;

        public Frm_Per_Yr_LvL_Event_Applicant()
        {
            InitializeComponent();

            userRepo = new UserRepository();
            db = new DBSYSEntities();
        }

        public void loadCbBoxYearLevel()
        {

            var yearlevel = db.YearLevel.ToList();

            cbboxYrLvl.ValueMember = "yrId";
            cbboxYrLvl.DisplayMember = "yrName";
            cbboxYrLvl.DataSource = yearlevel;

        }

        private void Frm_Per_Yr_LvL_Event_Applicant_Load(object sender, EventArgs e)
        {
            loadCbBoxYearLevel();
        }

        private void cbboxYrLvl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbboxYrLvl.SelectedIndex == 0)
            {
                dgvYearLevel.DataSource = userRepo.ShowTotalEventApplicants1stYear();
            }
            else if (cbboxYrLvl.SelectedIndex == 1)
            {
                dgvYearLevel.DataSource = userRepo.ShowTotalEventApplicants2ndYear();
            }
            else if (cbboxYrLvl.SelectedIndex == 2)
            {
                dgvYearLevel.DataSource = userRepo.ShowTotalEventApplicants3rdYear();
            }
            else if (cbboxYrLvl.SelectedIndex == 3)
            {
                dgvYearLevel.DataSource = userRepo.ShowTotalEventApplicants4thYear();
            }
        }
    }
}
