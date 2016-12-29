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

    public partial class AttendancesForm : Form
    {
        private readonly bool showValues;
        public AttendancesForm(int child_id, decimal year, bool showValues = false)
        {
            this.showValues = showValues;
            InitializeComponent();
            if (!Program.CurrentUser.CanEdit)
            {
                menuStrip1.Items[1].Enabled = false;
                menuStrip1.Items[1].Visible = false;
            }
            markTableAdapter.Fill(schoolDataSet1.mark, year, child_id, showValues ? "оценка" : "пропуск");
            dataGridView1.Columns[1].Visible = showValues;
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
    }
}
