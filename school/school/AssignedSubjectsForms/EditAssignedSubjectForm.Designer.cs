namespace school.TeachersForms
{
    partial class EditAssignedSubjectForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.schoolDataSet1 = new school.schoolDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.subjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherComboBox = new System.Windows.Forms.ComboBox();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectsTableAdapter = new school.schoolDataSetTableAdapters.subjectsTableAdapter();
            this.assigned_subjectsTableAdapter1 = new school.schoolDataSetTableAdapters.assigned_subjectsTableAdapter();
            this.teachersTableAdapter = new school.schoolDataSetTableAdapters.teachersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(132, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 38);
            this.button1.TabIndex = 100;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "schoolDataSet";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Предмет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(8, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Учитель";
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.DataSource = this.subjectsBindingSource;
            this.subjectComboBox.DisplayMember = "name";
            this.subjectComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(132, 5);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(273, 33);
            this.subjectComboBox.TabIndex = 101;
            this.subjectComboBox.ValueMember = "id";
            // 
            // subjectsBindingSource
            // 
            this.subjectsBindingSource.DataMember = "subjects";
            this.subjectsBindingSource.DataSource = this.schoolDataSet1;
            // 
            // teacherComboBox
            // 
            this.teacherComboBox.DataSource = this.teachersBindingSource;
            this.teacherComboBox.DisplayMember = "full_name";
            this.teacherComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.teacherComboBox.FormattingEnabled = true;
            this.teacherComboBox.Location = new System.Drawing.Point(132, 44);
            this.teacherComboBox.Name = "teacherComboBox";
            this.teacherComboBox.Size = new System.Drawing.Size(273, 33);
            this.teacherComboBox.TabIndex = 102;
            this.teacherComboBox.ValueMember = "id";
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.schoolDataSet1;
            // 
            // subjectsTableAdapter
            // 
            this.subjectsTableAdapter.ClearBeforeFill = true;
            // 
            // assigned_subjectsTableAdapter1
            // 
            this.assigned_subjectsTableAdapter1.ClearBeforeFill = true;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // EditAssignedSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 133);
            this.Controls.Add(this.teacherComboBox);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditAssignedSubjectForm";
            this.Text = "Редактировать";
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private schoolDataSet schoolDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.ComboBox teacherComboBox;
        private System.Windows.Forms.BindingSource subjectsBindingSource;
        private schoolDataSetTableAdapters.subjectsTableAdapter subjectsTableAdapter;
        private schoolDataSetTableAdapters.assigned_subjectsTableAdapter assigned_subjectsTableAdapter1;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private schoolDataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
    }
}