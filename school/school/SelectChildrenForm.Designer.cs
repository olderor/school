namespace school.TeachersForms
{
    partial class SelectChildrenForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.schoolDataSet1 = new school.schoolDataSet();
            this.teachersTableAdapter1 = new school.schoolDataSetTableAdapters.teachersTableAdapter();
            this.childComboBox = new System.Windows.Forms.ComboBox();
            this.childsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.childsTableAdapter = new school.schoolDataSetTableAdapters.childsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.yearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(142, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 43);
            this.button1.TabIndex = 100;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "ФИО";
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "schoolDataSet";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersTableAdapter1
            // 
            this.teachersTableAdapter1.ClearBeforeFill = true;
            // 
            // childComboBox
            // 
            this.childComboBox.DataSource = this.childsBindingSource;
            this.childComboBox.DisplayMember = "full_name";
            this.childComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.childComboBox.FormattingEnabled = true;
            this.childComboBox.Location = new System.Drawing.Point(126, 12);
            this.childComboBox.Name = "childComboBox";
            this.childComboBox.Size = new System.Drawing.Size(306, 33);
            this.childComboBox.TabIndex = 101;
            this.childComboBox.ValueMember = "id";
            // 
            // childsBindingSource
            // 
            this.childsBindingSource.DataMember = "childs";
            this.childsBindingSource.DataSource = this.schoolDataSet1;
            // 
            // childsTableAdapter
            // 
            this.childsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 103;
            this.label2.Text = "Год учебы";
            // 
            // yearDateTimePicker
            // 
            this.yearDateTimePicker.CustomFormat = "yyyy";
            this.yearDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yearDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.yearDateTimePicker.Location = new System.Drawing.Point(126, 51);
            this.yearDateTimePicker.Name = "yearDateTimePicker";
            this.yearDateTimePicker.Size = new System.Drawing.Size(306, 30);
            this.yearDateTimePicker.TabIndex = 102;
            // 
            // SelectChildrenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 137);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yearDateTimePicker);
            this.Controls.Add(this.childComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "SelectChildrenForm";
            this.Text = "Выбор ученика";
            this.Load += new System.EventHandler(this.SelectChildrenForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private schoolDataSet schoolDataSet1;
        private schoolDataSetTableAdapters.teachersTableAdapter teachersTableAdapter1;
        private System.Windows.Forms.ComboBox childComboBox;
        private System.Windows.Forms.BindingSource childsBindingSource;
        private schoolDataSetTableAdapters.childsTableAdapter childsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker yearDateTimePicker;
    }
}