using Microsoft.Reporting.WinForms;
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
    public partial class AttendanceReportForm : Form
    {
        private int child_id;
        private string childName;
        private decimal year;

        public AttendanceReportForm(int child_id, decimal year, string childName)
        {
            InitializeComponent();
            this.child_id = child_id;
            this.year = year;
            this.childName = childName;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("childName", childName));
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            // TODO: This line of code loads data into the 'schoolDataSet.marksReport' table. You can move, or remove it, as needed.
            this.attendance_statTableAdapter.Fill(schoolDataSet.attendance_stat, year, child_id, "пропуск");
            this.reportViewer1.RefreshReport();
        }
    }
}
