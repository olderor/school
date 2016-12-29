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
    public enum SelectDestination
    {
        Attendance, AttendanceStat, Marks, MarksReport
    }
    public partial class SelectChildrenForm : Form
    {
        private readonly SelectDestination dest;
        public SelectChildrenForm(SelectDestination dest)
        {
            this.dest = dest;
            InitializeComponent();
            childsTableAdapter.Fill(schoolDataSet1.childs);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            switch (dest)
            {
                case SelectDestination.Attendance:
                    AttendancesForm f = new AttendancesForm(Convert.ToInt32(childComboBox.SelectedValue), Convert.ToDecimal(yearDateTimePicker.Value.Year), false);
                    Close();
                    f.Show();
                    break;
                case SelectDestination.AttendanceStat:
                    AttendanceStatForm f2 = new AttendanceStatForm(Convert.ToInt32(childComboBox.SelectedValue), Convert.ToDecimal(yearDateTimePicker.Value.Year), childComboBox.GetItemText(childComboBox.SelectedItem));
                    Close();
                    f2.Show();
                    break;
                case SelectDestination.Marks:
                    AttendancesForm f3 = new AttendancesForm(Convert.ToInt32(childComboBox.SelectedValue), Convert.ToDecimal(yearDateTimePicker.Value.Year), true);
                    Close();
                    f3.Show();
                    break;
                case SelectDestination.MarksReport:
                    MarksReportForm f4 = new MarksReportForm(Convert.ToInt32(childComboBox.SelectedValue), Convert.ToDecimal(yearDateTimePicker.Value.Year), childComboBox.GetItemText(childComboBox.SelectedItem));
                    Close();
                    f4.Show();
                    break;
            }
        }

        private void SelectChildrenForm_Load(object sender, EventArgs e)
        {
        }
    }
}
