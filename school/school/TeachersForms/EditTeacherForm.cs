using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school.TeachersForms
{
    public partial class EditTeacherForm : Form
    {
        private readonly int id;
        readonly bool edit;

        public EditTeacherForm()
        {
            InitializeComponent();
            teachersTableAdapter1.Fill(schoolDataSet1.teachers);
            edit = false;
        }

        public EditTeacherForm(int id)
            : this()
        {
            schoolDataSet.teachersDataTable tb = new schoolDataSet.teachersDataTable();
            teachersTableAdapter1.FillById(tb, id);
            this.id = Convert.ToInt32(tb.Rows[0].ItemArray[0]);
            fullNameTextBox.Text= Convert.ToString(tb.Rows[0].ItemArray[1]);
            addressTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[2]);
            rateTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[3]);
            experienceTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[4]);
            phoneTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[5]);
            subjectFieldTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[6]);
            mailTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[7]);
            edit = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                teachersTableAdapter1.UpdateQuery(fullNameTextBox.Text, addressTextBox.Text, Convert.ToInt32(rateTextBox.Text), Convert.ToInt32(experienceTextBox.Text), phoneTextBox.Text, subjectFieldTextBox.Text, mailTextBox.Text, id);
            }
            else
            {
                teachersTableAdapter1.Insert(fullNameTextBox.Text, addressTextBox.Text, Convert.ToInt32(rateTextBox.Text), Convert.ToInt32(experienceTextBox.Text), phoneTextBox.Text, subjectFieldTextBox.Text, mailTextBox.Text);
            }
            teachersTableAdapter1.Update(schoolDataSet1.teachers);
            TeachersForm f = new TeachersForm();
            f.Show();
            Close();
        }
    }
}
