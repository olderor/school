﻿using System;
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

    public partial class ClassesForm : Form
    {
        public ClassesForm()
        {
            InitializeComponent();
            if (!Program.CurrentUser.CanEdit)
            {
                menuStrip1.Items[1].Enabled = false;
                menuStrip1.Items[1].Visible = false;
            }
            classesTableAdapter1.Fill(schoolDataSet1.classes);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditClassForm f = new EditClassForm();
            Close();
            f.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            classesTableAdapter1.DeleteQuery(Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value));
            classesTableAdapter1.Fill(schoolDataSet1.classes);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.SelectedCells[0].RowIndex;
            EditClassForm f = new EditClassForm(Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value));
            Close();
            f.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForms.UsersForm f = new UserForms.UsersForm();
            Close();
            f.Show();
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachersForm f = new TeachersForm();
            Close();
            f.Show();
        }

        private void fill2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.classesTableAdapter1.Fill2(this.schoolDataSet1.classes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}