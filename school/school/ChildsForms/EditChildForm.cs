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
    public partial class EditChildForm : Form
    {
        private readonly int id;
        readonly bool edit;

        const string CONNECTION = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=c:\documents\visual studio 2015\Projects\school\school\school.mdf;Integrated Security=True";

        public EditChildForm()
        {
            InitializeComponent();
            childsTableAdapter1.Fill(schoolDataSet1.childs);
            relationsTableAdapter1.Fill(schoolDataSet1.relations);
            edit = false;
            
            //todo
        }

        public EditChildForm(int id)
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


            schoolDataSet.relationDataTable dt = new schoolDataSet.relationDataTable();
            relationTableAdapter1.Fill(dt, id);
            relativesDataGridView.DataSource = dt;
            relativesDataGridView.Columns[0].Visible = false;
            relativesDataGridView.Columns[1].HeaderText = "ФИО";
            relativesDataGridView.Columns[2].HeaderText = "Тип родства";

            if (!isHonours())
            {
                label9.Text = "Не является отличником"; 
            }
        }

        private bool isHonours()
        {
            schoolDataSetTableAdapters.marksReportTableAdapter ta = new schoolDataSetTableAdapters.marksReportTableAdapter();
            schoolDataSet.marksReportDataTable dt = new schoolDataSet.marksReportDataTable();
            ta.Fill(dt, DateTime.Now.Year, id, "оценка");
            if (dt.Rows.Count == 0)
            {
                return true;
            }
            int sum = 0;
            for (int i = 0; i < dt.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dt.Rows[i].ItemArray[1]);
            }
            return (sum / dt.Rows.Count) >= 10;
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

        private void addButton_Click(object sender, EventArgs e)
        {
            EditRelationForm f = new EditRelationForm(id);
            Close();
            f.Show();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            int row = relativesDataGridView.SelectedCells[0].RowIndex;
            EditRelationForm f = new EditRelationForm(id, Convert.ToInt32(relativesDataGridView.Rows[row].Cells[0].Value));
            Close();
            f.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int row = relativesDataGridView.SelectedCells[0].RowIndex;
            relationsTableAdapter1.DeleteQuery(id, Convert.ToInt32(relativesDataGridView.Rows[row].Cells[0].Value));
            relationsTableAdapter1.Fill(schoolDataSet1.relations);
            schoolDataSet.relationDataTable dt = new schoolDataSet.relationDataTable();
            relationTableAdapter1.Fill(dt, id);
            relativesDataGridView.DataSource = dt;
        }

        private void findMarksButton_Click(object sender, EventArgs e)
        {
            int value = Convert.ToInt32(numericUpDown1.Value);
            schoolDataSetTableAdapters.markTableAdapter ta = new schoolDataSetTableAdapters.markTableAdapter();
            schoolDataSet.markDataTable dt = new schoolDataSet.markDataTable();
            ta.Fill(dt, DateTime.Now.Year, id, "оценка");

            int result = 1;
            if (dt.Rows.Count != 0)
            {
                double val2 = value - 0.5;
                int sum = 0;
                for (int i = 0; i < dt.Rows.Count; ++i)
                {
                    sum += Convert.ToInt32(dt.Rows[i].ItemArray[1]);
                }
                double answer = val2 * dt.Rows.Count - sum;
                answer = answer / (double)(12 - val2);
                result = Convert.ToInt32(Math.Ceiling(answer));
                result = Math.Max(0, result);
            }
            MessageBox.Show("Ученику необходимо получить " + result + " оценок по 12 баллов, чтобы получить оценку " + value + " в семестре.", "Решение", MessageBoxButtons.OK);
        }
    }
}
