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
    public partial class FilterForm : Form
    {

        public delegate void Filter(string word, int column);
        public event Filter onFilter;

        public FilterForm(string[] columns)
        {
            InitializeComponent();
            fieldComboBox.Items.AddRange(columns);
            fieldComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onFilter(wordTextBox.Text, fieldComboBox.SelectedIndex);
        }
    }
}
