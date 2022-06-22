using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dem
{
    public partial class EventForm : Form
    {
        demEntities db = new demEntities();
        Event eventOne;
        int id = 0;

        public EventForm( int idEvent)
        {
            InitializeComponent();
            eventOne = db.Event.Where(item => item.Id == idEvent).FirstOrDefault();
            id = idEvent;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Close();
            mainForm.Show();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            lableTitle.Text =  eventOne.Name;
            txtDate.Text = Convert.ToString(eventOne.Date);
            txtCity.Text = Convert.ToString(eventOne.IdCity);
            txtDescription.Text = Convert.ToString(eventOne.Description);
            txtOrganizer.Text = Convert.ToString(eventOne.IdUser);
        }
    }
}
