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
    public partial class Frm_Total_Sales_Misc : Form
    {
        UserRepository userRepo;
        DBSYSEntities db;

        public Frm_Total_Sales_Misc()
        {
            InitializeComponent();

            db = new DBSYSEntities();
            userRepo = new UserRepository();
        }

        private void Frm_Total_Sales_Misc_Load(object sender, EventArgs e)
        {
            dgvMiscSales.DataSource = userRepo.ShowMiscSales();
        }
    }
}
