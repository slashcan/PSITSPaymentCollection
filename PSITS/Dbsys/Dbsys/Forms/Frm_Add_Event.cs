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
    public partial class Frm_Add_Event : Form
    { 

    DBSYSEntities db; 

    
        public Frm_Add_Event()
        {
            InitializeComponent();
            db = new DBSYSEntities();
        }

        private void Frm_Add_Event_Load(object sender, EventArgs e)
        {

        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            Events newEvent = new Events();
            newEvent.eventName = eventTxt.Text;
            newEvent.eventDate = datePicker.Value;
            newEvent.eventPrice = Convert.ToInt32(priceTxt.Text);

   

            db.Events.Add(newEvent);
            db.SaveChanges();

            eventTxt.Clear();
            
            priceTxt.Clear();
            MessageBox.Show("Event Added!");
        }

        private void Frm_Add_Event_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Frm_Psits_DashBoard().Show();
        }
    }
}
