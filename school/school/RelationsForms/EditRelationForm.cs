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
    public partial class EditRelationForm : Form
    {
        private readonly int child_id;
        private readonly int relative_id;
        readonly bool edit;
        
        public EditRelationForm(int child_id)
        {
            this.child_id = child_id;
            InitializeComponent();
            relationsTableAdapter1.Fill(schoolDataSet1.relations);
            edit = false;
        }

        public EditRelationForm(int child_id, int relative_id)
            : this(child_id)
        {
            this.relative_id = relative_id;
            schoolDataSet.relationsDataTable tb = new schoolDataSet.relationsDataTable();
            relationsTableAdapter1.FillByChildIdAndRelativeId(tb, child_id, relative_id);
            child_id = Convert.ToInt32(tb.Rows[0].ItemArray[0]);
            relative_id = Convert.ToInt32(tb.Rows[0].ItemArray[1]);
            relativeComboBox.SelectedValue = relative_id;
            typeTextBox.Text = Convert.ToString(tb.Rows[0].ItemArray[2]);
            edit = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                relationsTableAdapter1.UpdateQuery(typeTextBox.Text, child_id, relative_id);
            }
            else
            {
                relationsTableAdapter1.Insert(child_id, Convert.ToInt32(relativeComboBox.SelectedValue), typeTextBox.Text);
            }
            relationsTableAdapter1.Update(schoolDataSet1.relations);
            EditChildForm f = new EditChildForm(child_id);
            f.Show();
            Close();
        }
        
        private void EditRelationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schoolDataSet1.relatives' table. You can move, or remove it, as needed.
            this.relativesTableAdapter.Fill(this.schoolDataSet1.relatives);
        }
    }
}
