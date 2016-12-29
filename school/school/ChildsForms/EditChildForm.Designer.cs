namespace school.TeachersForms
{
    partial class EditChildForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.documentTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.relativesDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.findMarksButton = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.schoolDataSet1 = new school.schoolDataSet();
            this.childsTableAdapter1 = new school.schoolDataSetTableAdapters.childsTableAdapter();
            this.relationsTableAdapter1 = new school.schoolDataSetTableAdapters.relationsTableAdapter();
            this.relationTableAdapter1 = new school.schoolDataSetTableAdapters.relationTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.relativesDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(160, 756);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 45);
            this.button1.TabIndex = 100;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addressTextBox.Location = new System.Drawing.Point(179, 41);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(273, 30);
            this.addressTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Адрес";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.fullNameTextBox.Location = new System.Drawing.Point(179, 5);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(273, 30);
            this.fullNameTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "ФИО";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(8, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Телефон";
            // 
            // documentTextBox
            // 
            this.documentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.documentTextBox.Location = new System.Drawing.Point(179, 113);
            this.documentTextBox.Name = "documentTextBox";
            this.documentTextBox.Size = new System.Drawing.Size(273, 30);
            this.documentTextBox.TabIndex = 20;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.phoneTextBox.Location = new System.Drawing.Point(179, 149);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(273, 30);
            this.phoneTextBox.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(9, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Начало учебы";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(8, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Конец учебы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(8, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Документ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Дата рождения";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.infoTextBox.Location = new System.Drawing.Point(180, 257);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(273, 65);
            this.infoTextBox.TabIndex = 102;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(9, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 60);
            this.label8.TabIndex = 101;
            this.label8.Text = "Дополнительная информация";
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(179, 77);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(273, 30);
            this.birthdayDateTimePicker.TabIndex = 103;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.startDateTimePicker.Location = new System.Drawing.Point(179, 185);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(273, 30);
            this.startDateTimePicker.TabIndex = 104;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.endDateTimePicker.Location = new System.Drawing.Point(179, 221);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(273, 30);
            this.endDateTimePicker.TabIndex = 105;
            // 
            // relativesDataGridView
            // 
            this.relativesDataGridView.AllowUserToAddRows = false;
            this.relativesDataGridView.AllowUserToDeleteRows = false;
            this.relativesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.relativesDataGridView.Location = new System.Drawing.Point(6, 29);
            this.relativesDataGridView.Name = "relativesDataGridView";
            this.relativesDataGridView.ReadOnly = true;
            this.relativesDataGridView.RowTemplate.Height = 24;
            this.relativesDataGridView.Size = new System.Drawing.Size(430, 195);
            this.relativesDataGridView.TabIndex = 106;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.changeButton);
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.relativesDataGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(11, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 294);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Родственники";
            // 
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(158, 230);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(126, 58);
            this.changeButton.TabIndex = 109;
            this.changeButton.Text = "Изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(322, 230);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(114, 58);
            this.deleteButton.TabIndex = 108;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(6, 230);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(116, 58);
            this.addButton.TabIndex = 107;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(229, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 25);
            this.label9.TabIndex = 109;
            this.label9.Text = "Является отличником";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(6, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 113);
            this.label10.TabIndex = 111;
            this.label10.Text = "Введите желаемую оценку за год";
            // 
            // findMarksButton
            // 
            this.findMarksButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.findMarksButton.Location = new System.Drawing.Point(179, 387);
            this.findMarksButton.Name = "findMarksButton";
            this.findMarksButton.Size = new System.Drawing.Size(274, 61);
            this.findMarksButton.TabIndex = 112;
            this.findMarksButton.Text = "Найти способ получения этой оценки";
            this.findMarksButton.UseVisualStyleBackColor = true;
            this.findMarksButton.Click += new System.EventHandler(this.findMarksButton_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numericUpDown1.Location = new System.Drawing.Point(179, 351);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(274, 30);
            this.numericUpDown1.TabIndex = 113;
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "schoolDataSet";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // childsTableAdapter1
            // 
            this.childsTableAdapter1.ClearBeforeFill = true;
            // 
            // relationsTableAdapter1
            // 
            this.relationsTableAdapter1.ClearBeforeFill = true;
            // 
            // relationTableAdapter1
            // 
            this.relationTableAdapter1.ClearBeforeFill = true;
            // 
            // EditChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 807);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.findMarksButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(this.birthdayDateTimePicker);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.documentTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EditChildForm";
            this.Text = "Редактировать ученика";
            ((System.ComponentModel.ISupportInitialize)(this.relativesDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox documentTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label6;
        private schoolDataSet schoolDataSet1;
        private System.Windows.Forms.Label label7;
        private schoolDataSetTableAdapters.childsTableAdapter childsTableAdapter1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DataGridView relativesDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button changeButton;
        private schoolDataSetTableAdapters.relationsTableAdapter relationsTableAdapter1;
        private schoolDataSetTableAdapters.relationTableAdapter relationTableAdapter1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button findMarksButton;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}