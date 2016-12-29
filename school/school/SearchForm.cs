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
    public partial class SearchForm : Form
    {

        public delegate void Search(string word, int column, bool startFromSelectedRow = true);
        public event Search onSearch;

        public SearchForm(string[] columns)
        {
            InitializeComponent();
            fieldComboBox.Items.AddRange(columns);
            fieldComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            onSearch(wordTextBox.Text, fieldComboBox.SelectedIndex);
        }
    }
}
