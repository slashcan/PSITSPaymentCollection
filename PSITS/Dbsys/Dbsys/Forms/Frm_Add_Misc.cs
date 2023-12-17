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
    public partial class Frm_Add_Misc : Form
    {
        DBSYSEntities db;
        public Frm_Add_Misc()
        {
            InitializeComponent();
            db= new DBSYSEntities();
        }

        private void Frm_Add_Misc_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Frm_Psits_DashBoard().Show();
        }

        private void addMiscButton_Click(object sender, EventArgs e)
        {
            Misc newMisc = new Misc();
            newMisc.miscName = miscNameTxt.Text;
            newMisc.miscPrice = Convert.ToInt32(priceTxt.Text);



            db.Misc.Add(newMisc);
            db.SaveChanges();

            miscNameTxt.Clear();

            priceTxt.Clear();
            MessageBox.Show("Misc Added!");
        }
    }
}
