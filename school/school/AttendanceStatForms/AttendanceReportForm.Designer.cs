namespace school
{
    partial class AttendanceReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.schoolDataSet = new school.schoolDataSet();
            this.attendance_statBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance_statTableAdapter = new school.schoolDataSetTableAdapters.attendance_statTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_statBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "attendanceReport";
            reportDataSource2.Value = this.attendance_statBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "school.AttendanceStatForms.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(810, 341);
            this.reportViewer1.TabIndex = 14;
            // 
            // schoolDataSet
            // 
            this.schoolDataSet.DataSetName = "schoolDataSet";
            this.schoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendance_statBindingSource
            // 
            this.attendance_statBindingSource.DataMember = "attendance_stat";
            this.attendance_statBindingSource.DataSource = this.schoolDataSet;
            // 
            // attendance_statTableAdapter
            // 
            this.attendance_statTableAdapter.ClearBeforeFill = true;
            // 
            // AttendanceReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 341);
            this.Controls.Add(this.reportViewer1);
            this.Name = "AttendanceReportForm";
            this.Text = "Докладная";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_statBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource attendance_statBindingSource;
        private schoolDataSet schoolDataSet;
        private schoolDataSetTableAdapters.attendance_statTableAdapter attendance_statTableAdapter;
    }
}