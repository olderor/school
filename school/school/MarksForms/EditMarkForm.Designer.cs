namespace school.TeachersForms
{
    partial class EditMarkForm
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
            this.assignedsubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignedsubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.childComboBox = new System.Windows.Forms.ComboBox();
            this.childsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assigned_subjectsTableAdapter1 = new school.schoolDataSetTableAdapters.assigned_subjectsTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.childsTableAdapter = new school.schoolDataSetTableAdapters.childsTableAdapter();
            this.marksTableAdapter1 = new school.schoolDataSetTableAdapters.marksTableAdapter();
            this.valueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.assigned__subjectTableAdapter = new school.schoolDataSetTableAdapters.assigned__subjectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedsubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedsubjectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.childsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(162, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 43);
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
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Предмет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ученик";
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.DataSource = this.assignedsubjectBindingSource;
            this.subjectComboBox.DisplayMember = "name";
            this.subjectComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(184, 47);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(273, 33);
            this.subjectComboBox.TabIndex = 101;
            this.subjectComboBox.ValueMember = "id";
            // 
            // assignedsubjectBindingSource
            // 
            this.assignedsubjectBindingSource.DataMember = "assigned_subject";
            this.assignedsubjectBindingSource.DataSource = this.schoolDataSet1;
            // 
            // assignedsubjectsBindingSource
            // 
            this.assignedsubjectsBindingSource.DataMember = "assigned_subjects";
            this.assignedsubjectsBindingSource.DataSource = this.schoolDataSet1;
            // 
            // childComboBox
            // 
            this.childComboBox.DataSource = this.childsBindingSource;
            this.childComboBox.DisplayMember = "full_name";
            this.childComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.childComboBox.FormattingEnabled = true;
            this.childComboBox.Location = new System.Drawing.Point(184, 86);
            this.childComboBox.Name = "childComboBox";
            this.childComboBox.Size = new System.Drawing.Size(273, 33);
            this.childComboBox.TabIndex = 102;
            this.childComboBox.ValueMember = "id";
            // 
            // childsBindingSource
            // 
            this.childsBindingSource.DataMember = "childs";
            this.childsBindingSource.DataSource = this.schoolDataSet1;
            // 
            // assigned_subjectsTableAdapter1
            // 
            this.assigned_subjectsTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 103;
            this.label3.Text = "Значение";
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.typeTextBox.Location = new System.Drawing.Point(184, 125);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(273, 30);
            this.typeTextBox.TabIndex = 107;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 106;
            this.label4.Text = "Тип отметки";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.infoTextBox.Location = new System.Drawing.Point(184, 161);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(273, 79);
            this.infoTextBox.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 61);
            this.label5.TabIndex = 108;
            this.label5.Text = "Дополнительная информация";
            // 
            // childsTableAdapter
            // 
            this.childsTableAdapter.ClearBeforeFill = true;
            // 
            // marksTableAdapter1
            // 
            this.marksTableAdapter1.ClearBeforeFill = true;
            // 
            // valueNumericUpDown
            // 
            this.valueNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.valueNumericUpDown.Location = new System.Drawing.Point(184, 11);
            this.valueNumericUpDown.Name = "valueNumericUpDown";
            this.valueNumericUpDown.Size = new System.Drawing.Size(273, 30);
            this.valueNumericUpDown.TabIndex = 110;
            // 
            // assigned__subjectTableAdapter
            // 
            this.assigned__subjectTableAdapter.ClearBeforeFill = true;
            // 
            // EditMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 311);
            this.Controls.Add(this.valueNumericUpDown);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.childComboBox);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditMarkForm";
            this.Text = "Отметка";
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedsubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignedsubjectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.childsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private schoolDataSet schoolDataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.ComboBox childComboBox;
        private schoolDataSetTableAdapters.assigned_subjectsTableAdapter assigned_subjectsTableAdapter1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource childsBindingSource;
        private schoolDataSetTableAdapters.childsTableAdapter childsTableAdapter;
        private schoolDataSetTableAdapters.marksTableAdapter marksTableAdapter1;
        private System.Windows.Forms.NumericUpDown valueNumericUpDown;
        private System.Windows.Forms.BindingSource assignedsubjectsBindingSource;
        private System.Windows.Forms.BindingSource assignedsubjectBindingSource;
        private schoolDataSetTableAdapters.assigned__subjectTableAdapter assigned__subjectTableAdapter;
    }
}