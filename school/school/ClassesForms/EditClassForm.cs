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
    public partial class EditClassForm : Form
    {
        private readonly int id;
        readonly bool edit;

        public EditClassForm()
        {
            InitializeComponent();
            classesTableAdapter1.Fill(schoolDataSet1.classes);
            edit = false;
        }

        public EditClassForm(int id)
            : this()
        {
            schoolDataSet.classesDataTable tb = new schoolDataSet.classesDataTable();
            classesTableAdapter1.FillById(tb, id);
            this.id = Convert.ToInt32(tb.Rows[0].ItemArray[0]);
            dateTimePicker.Value = DateTime.Parse(Convert.ToString(tb.Rows[0].ItemArray[1]));
            numberTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[2]);
            indexTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[3]);
            teacherComboBox.SelectedValue = Convert.ToInt32(tb.Rows[0].ItemArray[4]);
            edit = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                classesTableAdapter1.UpdateQuery(dateTimePicker.Value.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), numberTextBox.Text, indexTextBox.Text, Convert.ToInt32(teacherComboBox.SelectedValue), id);
            }
            else
            {
                classesTableAdapter1.Insert(dateTimePicker.Value, numberTextBox.Text, indexTextBox.Text, Convert.ToInt32(teacherComboBox.SelectedValue));
            }
            classesTableAdapter1.Update(schoolDataSet1.classes);
            ClassesForm f = new ClassesForm();
            Close();
            f.Show();
        }

        private void EditClassForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet1.teachers' table. You can move, or remove it, as needed.
            this.teachersTableAdapter.Fill(this.schoolDataSet1.teachers);

        }
    }
}
