using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school
{
    using UserForms;

    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mail = emailTextBox.Text;
            string password = passwordTextBox.Text;

            schoolDataSet.userDataTable dt = userTableAdapter1.GetDataByMailAndPass(mail, password);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("User not found");
                return;
            }
            User user = new User((string)dt.Rows[0].ItemArray[0], (string)dt.Rows[0].ItemArray[1], (string)dt.Rows[0].ItemArray[2], (string)dt.Rows[0].ItemArray[3]);
            Program.CurrentUser = user;
            TeachersForm f = new TeachersForm();
            f.Show();
            Close();
        }

        private void LogInForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Program.CurrentUser == null)
            {
                Application.Exit();
            }
        }
    }
}
