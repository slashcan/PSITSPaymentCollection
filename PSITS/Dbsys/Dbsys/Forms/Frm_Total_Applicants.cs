﻿using Dbsys.AppData;
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

            var yearlevel = db.YearLevel.ToList();

            cbboxYrLvl.ValueMember = "yrId";
            cbboxYrLvl.DisplayMember = "yrName";
            cbboxYrLvl.DataSource = yearlevel;

        }

        private void cbboxEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbboxYrLvl.SelectedIndex == 0) 
            {
                dgvEventSales.DataSource = userRepo.ShowTotalEventApplicants1stYear();
            }
            else if (cbboxYrLvl.SelectedIndex == 1) 
            {
                dgvEventSales.DataSource = userRepo.ShowTotalEventApplicants2ndYear();
            }
            else if (cbboxYrLvl.SelectedIndex == 2)
            {
                dgvEventSales.DataSource = userRepo.ShowTotalEventApplicants3rdYear();
            }
            else if (cbboxYrLvl.SelectedIndex == 3)
            {
                dgvEventSales.DataSource = userRepo.ShowTotalEventApplicants4thYear();
            }
        }
    }
}
