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
    public partial class RegistrationJuryForm : Form
    {

        demEntities db = new demEntities();
        Role role;
        Direction direction;

        public RegistrationJuryForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtEmail.Text == "" || txtPatronymic.Text == "" || txtPhone.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Заполните все поля");
            }
            try
            {
                if (Convert.ToString(txtPassword.Text) == Convert.ToString(txtRepeatPassword.Text) || Convert.ToString(txtRepeatPassword.Text) == "")
                {
                User user = new User
                {
                    FirstName = Convert.ToString(txtFirstName.Text),
                    LastName = Convert.ToString(txtLastName.Text),
                    Patronymic = Convert.ToString(txtPassword.Text),
                    Email = Convert.ToString(txtEmail.Text),
                    PhoneNumber = Convert.ToString(txtPhone.Text),
                    Password = Convert.ToString(txtPassword.Text),
                    IdNumber = Convert.ToInt32(txtNumber.Text),

                    IdRole = Convert.ToInt32(cmbRole.SelectedValue),
                    IdDirection = Convert.ToInt32(cmbDirection.SelectedValue),
                    IdGender = Convert.ToInt32(cmbGender.SelectedValue),
                };

                    db.User.Add(user);
                    db.SaveChanges();

                    JuryForm juryForm = new JuryForm();
                    this.Close();
                    juryForm.Show();

                    MessageBox.Show("Регистроация прошла успешно!");
                }
                else 
                {
                    MessageBox.Show("Повторите пароль!");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCamcel_Click(object sender, EventArgs e)
        {
            JuryForm juryForm = new JuryForm();
            this.Close();
            juryForm.Show();
        }

        private void RegistrationJuryForm_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int result;
            result = r.Next(1, 1000); // x - минимальное, y - максимальное возможные числа

            txtNumber.Text = result.ToString();

            var role = db.Role.ToList();
            cmbRole.DataSource = role;
            cmbRole.DisplayMember = "Name";
            cmbRole.ValueMember = "Id";

            var gender = db.Gender.ToList();
            cmbGender.DataSource = gender;
            cmbGender.DisplayMember = "Name";
            cmbGender.ValueMember = "Id";
            
            var direction = db.Direction.ToList();
            cmbDirection.DataSource = direction;
            cmbDirection.DisplayMember = "Name";
            cmbDirection.ValueMember = "Id";
        }
    }
}
