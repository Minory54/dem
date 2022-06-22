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
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtEmail.Text == "" || txtPatronymic.Text == "" || txtPhone.Text == "")
            {
                MessageBox.Show("Заполните все поля");
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
            result = r.Next(1, 10000); // x - минимальное, y - максимальное возможные числа

            txtNumber.Text = result.ToString();

            var role = db.Role.ToList();
            cmdRole.DataSource = role;
            cmdRole.DisplayMember = "Name";
            cmdRole.ValueMember = "Id";

            var gender = db.Gender.ToList();
            cmdRole.DataSource = gender;
            cmdRole.DisplayMember = "Name";
            cmdRole.ValueMember = "Id";
            
            var direction = db.Direction.ToList();
            cmdRole.DataSource = direction;
            cmdRole.DisplayMember = "Name";
            cmdRole.ValueMember = "Id";
        }
    }
}
