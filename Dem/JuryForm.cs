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
    public partial class JuryForm : Form
    {
        demEntities db = new demEntities();
        int id_user;
        public JuryForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OrganizerForm organizerForm = new OrganizerForm();
            this.Close();
            organizerForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void JuryForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        public void UpdateTable()
        {
            try 
            {

                var user = from us in db.User
                           where us.IdRole == 2 || us.IdRole == 3
                           join ro in db.Role on us.IdRole equals ro.Id
                           select new
                           { 
                               Id = us.IdNumber,
                               Photo = us.Photo,
                               FIO = us.LastName + us.FirstName + us.Patronymic,
                               Email = us.Email,
                               UserRole = ro.Name
                           };

                tableJuryAndModerators.DataSource = user.ToList();

                if (tableJuryAndModerators.Rows.Count > 0)
                {
                    tableJuryAndModerators.Columns[0].Visible = false;
                    tableJuryAndModerators.Columns[1].HeaderText = "Фото";
                    tableJuryAndModerators.Columns[2].HeaderText = "ФИО";
                    tableJuryAndModerators.Columns[3].HeaderText = "Email";
                    tableJuryAndModerators.Columns[4].HeaderText = "Роль";

                    id_user = Convert.ToInt32(tableJuryAndModerators[0, 0].Value);
                }
                else
                {
                    tableJuryAndModerators.Columns[0].Visible = false;
                    tableJuryAndModerators.Columns[1].HeaderText = "Фото";
                    tableJuryAndModerators.Columns[2].HeaderText = "ФИО";
                    tableJuryAndModerators.Columns[3].HeaderText = "Email";
                    tableJuryAndModerators.Columns[4].HeaderText = "Роль";
                }

                labelCount.Text = Convert.ToString(tableJuryAndModerators.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationJuryForm registrationJuryForm = new RegistrationJuryForm();
            this.Close();
            registrationJuryForm.Show();
        }
    }
}
