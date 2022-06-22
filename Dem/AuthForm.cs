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
    public partial class AuthForm : Form
    {
        demEntities db = new demEntities();

        public AuthForm()
        {
            InitializeComponent();
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

        private void btnAuth_Click(object sender, EventArgs e)
        {
            try 
            { 
                if (txtUserNumber.Text == "" || txtUserPassword.Text == "")
                {
                    MessageBox.Show("Ошибка поля пустые!");
                    return;
                }
                int userNumber = Convert.ToInt32(txtUserNumber.Text);
                var user = (from us in db.User
                            where us.IdNumber == userNumber && us.Password == txtUserPassword.Text
                            select us).FirstOrDefault();

                if (user != null)
                {
                    DataBank.lastName = user.LastName;
                    DataBank.firstName = user.FirstName;
                    DataBank.email = user.Email;
                    DataBank.idNumber = user.IdNumber;
                    DataBank.patronymic = user.Patronymic;
                    DataBank.gender = Convert.ToInt32(user.IdGender);
                    DataBank.phoneNumber = user.PhoneNumber;
                    DataBank.dateBirth = Convert.ToString(user.Date);
                    DataBank.country = Convert.ToInt32(user.IdCountry);

                    if (user.IdRole == 1)
                    {
                        OrganizerForm organizerForm = new OrganizerForm();
                        this.Close();
                        organizerForm.Show();
                    }

                    if (user.IdRole == 3)
                    {
                        ModeratorForm moderatorForm = new ModeratorForm();
                        this.Close();
                        moderatorForm.Show();
                    }
                }
                else 
                {
                    MessageBox.Show("Пользователь с такими данными не найден!");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


         
        }
    }
}
