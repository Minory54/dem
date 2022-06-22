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
    public partial class MainForm : Form
    {

        demEntities db = new demEntities();
        int id_event;

        public MainForm()
        {
            InitializeComponent();
        }

        public void UpdateTable() 
        {
            try 
            {
                var events = from ev in db.Event
                             join dir in db.Direction on ev.IdDirection equals dir.Id 
                             select new
                             {
                                 Id = ev.Id,
                                 Logo = ev.Logo,
                                 Name = ev.Name,
                                 Direction = dir.Name,
                                 Date = ev.Date,
                             };
                tableEvent.DataSource = events.ToList();

                if (tableEvent.Rows.Count > 0)
                { 
                    tableEvent.Columns[0].Visible = false;
                    tableEvent.Columns[1].HeaderText = "Логотип";
                    tableEvent.Columns[2].HeaderText = "Название мероприятия";
                    tableEvent.Columns[3].HeaderText = "Направление";
                    tableEvent.Columns[4].HeaderText = "Дата";

                    id_event = Convert.ToInt32(tableEvent[0, 0].Value);
                }
                else
                {
                    tableEvent.Columns[0].Visible = false;
                    tableEvent.Columns[1].HeaderText = "Логотип";
                    tableEvent.Columns[2].HeaderText = "Название мероприятия";
                    tableEvent.Columns[3].HeaderText = "Направление";
                    tableEvent.Columns[4].HeaderText = "Дата";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void btnEventInfo_Click(object sender, EventArgs e)
        {
            if (tableEvent.SelectedRows.Count > 0)
            { 
                new EventForm(Convert.ToInt32(tableEvent.SelectedRows[0].Cells[0].Value)).Show();
                this.Hide();
            }
            else MessageBox.Show("Выберите мероприятие!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
