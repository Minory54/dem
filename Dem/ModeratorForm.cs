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
    public partial class ModeratorForm : Form
    {
        demEntities db = new demEntities();
        DateTime timeNow = new DateTime();

        public ModeratorForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            this.Hide();
        }

        public void UpdateTable()
        {
            try
            {
                var activity = from act in db.Activity
                               select new
                               {
                                   Id = act.Id,
                                   Name = act.Name,
                                   Time = act.Time,
                               };


                tableActivity.DataSource = activity.ToList();

                if (tableActivity.Rows.Count > 0)
                {
                    tableActivity.Columns[0].Visible = false;
                    tableActivity.Columns[1].HeaderText = "Название";
                    tableActivity.Columns[2].HeaderText = "Время";

                    int id_activity = Convert.ToInt32(tableActivity[0, 0].Value);
                }
                else
                {
                    tableActivity.Columns[0].Visible = false;
                    tableActivity.Columns[1].HeaderText = "Название";
                    tableActivity.Columns[2].HeaderText = "Время";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ModeratorForm_Load(object sender, EventArgs e)
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
    }
}
