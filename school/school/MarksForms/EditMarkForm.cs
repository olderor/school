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
    public partial class EditMarkForm : Form
    {
        public EditMarkForm()
        {
            InitializeComponent();
            assigned_subjectsTableAdapter1.Fill(schoolDataSet1.assigned_subjects);
            childsTableAdapter.Fill(schoolDataSet1.childs);
            marksTableAdapter1.Fill(schoolDataSet1.marks);
            assigned__subjectTableAdapter.Fill(schoolDataSet1.assigned_subject);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int childId = Convert.ToInt32(childComboBox.SelectedValue);
            int value = Convert.ToInt32(valueNumericUpDown.Value);
            int subjectId = Convert.ToInt32(subjectComboBox.SelectedValue);


            if (typeTextBox.Text == "оценка")
            {
                NotificationManager.NotifyIfNeeded(childId, value, subjectId);
            }

            marksTableAdapter1.Insert(value, childId, subjectId, DateTime.Now, typeTextBox.Text, infoTextBox.Text);
            assigned_subjectsTableAdapter1.Update(schoolDataSet1.assigned_subjects);
            TeachersForm f = new TeachersForm();
            f.Show();
            Close();
        }
    }
}
