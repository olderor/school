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

    public partial class MarksReportForm : Form
    {
        private int child_id;
        private decimal year;
        private string childName;
        public MarksReportForm(int child_id, decimal year, string childName)
        {
            this.child_id = child_id;
            this.year = year;
            this.childName = childName;
            InitializeComponent();
            marksReportTableAdapter.Fill(schoolDataSet1.marksReport, year, child_id, "оценка");
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

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportForm f = new ReportForm(child_id, year, childName);
            Close();
            f.Show();
        }
    }
}
