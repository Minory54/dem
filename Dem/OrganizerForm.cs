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
    public partial class OrganizerForm : Form
    {
        demEntities db = new demEntities();
        DateTime timeNow = new DateTime();

        public OrganizerForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            this.Close();
            authForm.Show();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {

        }

        private void btnParticipants_Click(object sender, EventArgs e)
        {

        }

        private void btnJury_Click(object sender, EventArgs e)
        {
            JuryForm juryForm = new JuryForm();
            this.Close();
            juryForm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }

        private void OrganizerForm_Load(object sender, EventArgs e)
        {
            timeNow = DateTime.Now;
            int hourNow = timeNow.Hour;

            if (hourNow >= 9 && hourNow <= 11 ) 
            {
                labelGreetings.Text = "Доброе утро, " + DataBank.firstName +" "+ DataBank.patronymic;
            }
            if (hourNow >= 11 && hourNow <= 18)
            {
                labelGreetings.Text = "Добрый день, " + DataBank.firstName + " " + DataBank.patronymic;
            }
            if (hourNow >= 18 && hourNow <= 24)
            {
                labelGreetings.Text = "Добрый вечер, " + DataBank.firstName + " " + DataBank.patronymic;
            }
          
        }
    }
}
