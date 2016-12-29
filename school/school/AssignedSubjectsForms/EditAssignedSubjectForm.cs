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
    public partial class EditAssignedSubjectForm : Form
    {
        private readonly int id;
        readonly bool edit;

        public EditAssignedSubjectForm()
        {
            InitializeComponent();
            assigned_subjectsTableAdapter1.Fill(schoolDataSet1.assigned_subjects);
            teachersTableAdapter.Fill(schoolDataSet1.teachers);
            subjectsTableAdapter.Fill(schoolDataSet1.subjects);
            edit = false;
        }

        public EditAssignedSubjectForm(int id)
            : this()
        {
            schoolDataSet.assigned_subjectsDataTable tb = new schoolDataSet.assigned_subjectsDataTable();
            assigned_subjectsTableAdapter1.FillById(tb, id);
            this.id = Convert.ToInt32(tb.Rows[0].ItemArray[0]);
            subjectComboBox.SelectedValue = tb.Rows[0].ItemArray[1];
            teacherComboBox.SelectedValue = tb.Rows[0].ItemArray[2];
            edit = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                assigned_subjectsTableAdapter1.UpdateQuery(Convert.ToInt32(subjectComboBox.SelectedValue), Convert.ToInt32(teacherComboBox.SelectedValue), id);
            }
            else
            {
                assigned_subjectsTableAdapter1.Insert(Convert.ToInt32(subjectComboBox.SelectedValue), Convert.ToInt32(teacherComboBox.SelectedValue));
            }
            assigned_subjectsTableAdapter1.Update(schoolDataSet1.assigned_subjects);
            TeachersForm f = new TeachersForm();
            f.Show();
            Close();
        }
    }
}
