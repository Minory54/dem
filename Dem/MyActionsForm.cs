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
    public partial class MyActions : Form
    {
        demEntities db = new demEntities();
        DateTime timeNow = new DateTime();

        public MyActions()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ModeratorForm moderatorForm = new ModeratorForm();
            this.Close();
            moderatorForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MyActions_Load(object sender, EventArgs e)
        {
            UpdateTable();

            timeNow = DateTime.Now;
            int hourNow = timeNow.Hour;

            if (hourNow >= 9 && hourNow <= 11)
            {
                labelGreetings.Text = "Доброе утро, " + DataBank.firstName + " " + DataBank.patronymic;
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


        public void UpdateTable()
        {

        }
    }
}
