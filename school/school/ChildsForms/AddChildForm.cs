using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school.TeachersForms
{
    public partial class AddChildForm : Form
    {
        private readonly int id;
       readonly bool edit;

        public AddChildForm()
        {
            InitializeComponent();
            childsTableAdapter1.Fill(schoolDataSet1.childs);
            relationsTableAdapter1.Fill(schoolDataSet1.relations);
            edit = false;
        }

        public AddChildForm(int id)
            : this()
        {
            schoolDataSet.childsDataTable tb = new schoolDataSet.childsDataTable();
            childsTableAdapter1.FillById(tb, id);
            this.id = Convert.ToInt32(tb.Rows[0].ItemArray[0]);
            fullNameTextBox.Text= Convert.ToString(tb.Rows[0].ItemArray[1]);
            birthdayDateTimePicker.Value = Convert.ToDateTime(tb.Rows[0].ItemArray[2]);
            addressTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[3]);
            documentTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[4]);
            phoneTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[5]);
            startDateTimePicker.Value = Convert.ToDateTime(tb.Rows[0].ItemArray[6]);
            endDateTimePicker.Value = Convert.ToDateTime(tb.Rows[0].ItemArray[7]);
            infoTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[8]);
            edit = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                childsTableAdapter1.UpdateQuery(fullNameTextBox.Text, birthdayDateTimePicker.Value.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), addressTextBox.Text, documentTextBox.Text, phoneTextBox.Text, startDateTimePicker.Value.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), endDateTimePicker.Value.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.InvariantCulture), infoTextBox.Text, id);
            }
            else
            {
                childsTableAdapter1.Insert(fullNameTextBox.Text, birthdayDateTimePicker.Value, addressTextBox.Text, documentTextBox.Text, phoneTextBox.Text, startDateTimePicker.Value, endDateTimePicker.Value, infoTextBox.Text);
            }
            childsTableAdapter1.Update(schoolDataSet1.childs);
            ChildsForm f = new ChildsForm();
            f.Show();
            Close();
        }
    }
}
