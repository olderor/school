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

    public partial class EditUserForm : Form
    {

        private readonly string mail;
        readonly bool edit;

        public EditUserForm()
        {
            InitializeComponent();
            userTableAdapter1.Fill(schoolDataSet1.user);
            edit = false;
        }
        

        public EditUserForm(string nick, string mail, string password, string type)
            : this()
        {
            edit = true;
            this.mail = mail;
            nickTextBox.Text = nick;
            mailTextBox.Text = mail;
            passwordTextBox.Text = password;
            typeComboBox.Text = type;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                userTableAdapter1.UpdateQuery(nickTextBox.Text, passwordTextBox.Text, typeComboBox.Text, mailTextBox.Text);
            }
            else
            {
                userTableAdapter1.Insert(nickTextBox.Text, mailTextBox.Text, passwordTextBox.Text, typeComboBox.Text);
            }
            userTableAdapter1.Update(schoolDataSet1.user);
            UsersForm f = new UsersForm();
            f.Show();
            Close();
        }
        
    }
}
