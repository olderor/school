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
    using TeachersForms;

    public partial class AttendanceStatForm : Form
    {
        private int child_id;
        private string childName;
        private decimal year;

        public AttendanceStatForm(int child_id, decimal year, string childName)
        {
            InitializeComponent();
            this.child_id = child_id;
            this.year = year;
            this.childName = childName;
            attendance_statTableAdapter.Fill(schoolDataSet1.attendance_stat, year, child_id, "пропуск");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForms.UsersForm f = new UserForms.UsersForm();
            Close();
            f.Show();
        }

        private void предметыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubjectsForm f = new SubjectsForm();
            Close();
            f.Show();
        }

        private void AttendancesForm_Load(object sender, EventArgs e)
        {

        }

        private void makeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendanceReportForm f = new AttendanceReportForm(child_id, year, childName);
            Close();
            f.Show();
        }
    }
}
