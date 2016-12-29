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
    public partial class EditRelativeForm : Form
    {
        private readonly int id;
        readonly bool edit;

        public EditRelativeForm()
        {
            InitializeComponent();
            relativesTableAdapter1.Fill(schoolDataSet1.relatives);
            edit = false;
        }

        public EditRelativeForm(int id)
            : this()
        {
            schoolDataSet.relativesDataTable tb = new schoolDataSet.relativesDataTable();
            relativesTableAdapter1.FillById(tb, id);
            this.id = Convert.ToInt32(tb.Rows[0].ItemArray[0]);
            fullNameTextBox.Text= Convert.ToString(tb.Rows[0].ItemArray[1]);
            phoneTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[2]);
            addressTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[3]);
            infoFieldTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[4]);
            mailTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[5]);
            edit = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                relativesTableAdapter1.UpdateQuery(fullNameTextBox.Text, phoneTextBox.Text, addressTextBox.Text, infoFieldTextBox.Text, mailTextBox.Text, id);
            }
            else
            {
                relativesTableAdapter1.Insert(fullNameTextBox.Text, phoneTextBox.Text, addressTextBox.Text, infoFieldTextBox.Text, mailTextBox.Text);
            }
            relativesTableAdapter1.Update(schoolDataSet1.relatives);
            RelativesForm f = new RelativesForm();
            f.Show();
            Close();
        }
    }
}
