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
    public partial class EditSubjectForm : Form
    {
        private readonly int id;
        readonly bool edit;

        public EditSubjectForm()
        {
            InitializeComponent();
            subjectsTableAdapter1.Fill(schoolDataSet1.subjects);
            edit = false;
        }

        public EditSubjectForm(int id)
            : this()
        {
            schoolDataSet.subjectsDataTable tb = new schoolDataSet.subjectsDataTable();
            subjectsTableAdapter1.FillById(tb, id);
            this.id = Convert.ToInt32(tb.Rows[0].ItemArray[0]);
            nameTextBox.Text= Convert.ToString(tb.Rows[0].ItemArray[1]);
            subjectTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[2]);
            edit = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                subjectsTableAdapter1.UpdateQuery(nameTextBox.Text, subjectTextBox.Text, id);
            }
            else
            {
                subjectsTableAdapter1.InsertQuery(nameTextBox.Text, subjectTextBox.Text);
            }
            subjectsTableAdapter1.Update(schoolDataSet1.subjects);
            SubjectsForm f = new SubjectsForm();
            Close();
            f.Show();
        }
    }
}
