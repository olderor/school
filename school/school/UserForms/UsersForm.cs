using Microsoft.Reporting.WebForms;
using school.TeachersForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school.UserForms
{
    public partial class UsersForm : Form
    {

        private List<int> columns = new List<int>(new int[] { 0, 1, 3 });

        public UsersForm()
        {
            InitializeComponent();
            userTableAdapter1.Fill(schoolDataSet1.user);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserForm f = new EditUserForm();
            f.Show();
            Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int row = dataGridView1.SelectedCells[0].RowIndex;
            EditUserForm f = new EditUserForm(
                Convert.ToString(dataGridView1.Rows[row].Cells[0].Value),
                Convert.ToString(dataGridView1.Rows[row].Cells[1].Value),
                Convert.ToString(dataGridView1.Rows[row].Cells[2].Value),
                Convert.ToString(dataGridView1.Rows[row].Cells[3].Value));
            f.Show();
            Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            userTableAdapter1.DeleteQuery(Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value));
            userTableAdapter1.Fill(schoolDataSet1.user);
        }

        private void sortDataGridView(int columnIndex)
        {
            if (dataGridView1.Columns[columnIndex] == dataGridView1.SortedColumn)
            {
                if (dataGridView1.SortOrder == System.Windows.Forms.SortOrder.Descending)
                {
                    dataGridView1.Sort(dataGridView1.Columns[columnIndex], ListSortDirection.Ascending);
                }
                else
                {
                    dataGridView1.Sort(dataGridView1.Columns[columnIndex], ListSortDirection.Descending);
                }
            }
            else
            {
                dataGridView1.Sort(dataGridView1.Columns[columnIndex], ListSortDirection.Ascending);
            }
        }

        private void nickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortDataGridView(columns[0]);
        }

        private void emailSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortDataGridView(columns[1]);
        }

        private void typeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sortDataGridView(columns[2]);
        }

        private void search(string word, int column, bool startFromSelectedRow = true)
        {
            int startIndex = startFromSelectedRow ? dataGridView1.SelectedCells[0].RowIndex + 1 : 0;
            for (int i = startIndex; i < dataGridView1.Rows.Count; ++i)
            {
                if (column != 0)
                {
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[columns[column - 1]].Value).IndexOf(word) != -1)
                    {
                        dataGridView1.ClearSelection();
                        dataGridView1.Rows[i].Selected = true;
                        return;
                    }
                }
                else
                {
                    for (int j = 0; j < columns.Count; ++j)
                    {
                        if (Convert.ToString(dataGridView1.Rows[i].Cells[columns[j]].Value).IndexOf(word) != -1)
                        {
                            dataGridView1.ClearSelection();
                            dataGridView1.Rows[i].Selected = true;
                            return;
                        }
                    }
                }
            }
            DialogResult result = MessageBox.Show("Не найдено. Начать сначала?", "Внимание", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                search(word, column, false);
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm f = new SearchForm(new string[] { "Все", dataGridView1.Columns[0].HeaderText, dataGridView1.Columns[1].HeaderText, dataGridView1.Columns[3].HeaderText });
            f.Show();
            f.onSearch += search;
        }

        private void filter(string word, int column)
        {
            if (word == "")
            {
                userBindingSource.RemoveFilter();
                return;
            }
            userBindingSource.Filter = string.Format("{0} = '{1}'", dataGridView1.Columns[columns[column]].DataPropertyName, word);
        }

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilterForm f = new FilterForm(new string[] { dataGridView1.Columns[0].HeaderText, dataGridView1.Columns[1].HeaderText, dataGridView1.Columns[3].HeaderText });
            f.Show();
            f.onFilter += filter;
        }

        private void teachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachersForm f = new TeachersForm();
            Close();
            f.Show();
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectsForm f = new SubjectsForm();
            Close();
            f.Show();
        }

        private void relativesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RelativesForm f = new RelativesForm();
            Close();
            f.Show();
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassesForm f = new ClassesForm();
            Close();
            f.Show();
        }
        
        private void childsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildsForm f = new ChildsForm();
            Close();
            f.Show();
        }

        private void assignSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAssignedSubjectForm f = new EditAssignedSubjectForm();
            Close();
            f.Show();
        }

        private void markToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMarkForm f = new EditMarkForm();
            Close();
            f.Show();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectChildrenForm f = new SelectChildrenForm(SelectDestination.Attendance);
            f.Show();
            Close();
        }

        private void viewMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectChildrenForm f = new SelectChildrenForm(SelectDestination.Marks);
            f.Show();
            Close();
        }

        private void attendanceStatToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SelectChildrenForm f = new SelectChildrenForm(SelectDestination.AttendanceStat);
            f.Show();
            Close();
        }

        private void marksReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SelectChildrenForm f = new SelectChildrenForm(SelectDestination.MarksReport);
            f.Show();
            Close();
        }
    }
}
