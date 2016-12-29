namespace school.TeachersForms
{
    partial class EditRelationForm
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
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.schoolDataSet1 = new school.schoolDataSet();
            this.relativeComboBox = new System.Windows.Forms.ComboBox();
            this.relativesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relationsTableAdapter1 = new school.schoolDataSetTableAdapters.relationsTableAdapter();
            this.relativesTableAdapter = new school.schoolDataSetTableAdapters.relativesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relativesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(126, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 41);
            this.button1.TabIndex = 100;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.typeTextBox.Location = new System.Drawing.Point(148, 43);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(273, 30);
            this.typeTextBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Тип родства";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Родственник";
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "schoolDataSet";
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relativeComboBox
            // 
            this.relativeComboBox.DataSource = this.relativesBindingSource;
            this.relativeComboBox.DisplayMember = "full_name";
            this.relativeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.relativeComboBox.FormattingEnabled = true;
            this.relativeComboBox.Location = new System.Drawing.Point(147, 4);
            this.relativeComboBox.Name = "relativeComboBox";
            this.relativeComboBox.Size = new System.Drawing.Size(274, 33);
            this.relativeComboBox.TabIndex = 109;
            this.relativeComboBox.ValueMember = "id";
            // 
            // relativesBindingSource
            // 
            this.relativesBindingSource.DataMember = "relatives";
            this.relativesBindingSource.DataSource = this.schoolDataSet1;
            // 
            // relationsTableAdapter1
            // 
            this.relationsTableAdapter1.ClearBeforeFill = true;
            // 
            // relativesTableAdapter
            // 
            this.relativesTableAdapter.ClearBeforeFill = true;
            // 
            // EditRelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 138);
            this.Controls.Add(this.relativeComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditRelationForm";
            this.Text = "Связь";
            this.Load += new System.EventHandler(this.EditRelationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relativesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private schoolDataSet schoolDataSet1;
        private System.Windows.Forms.ComboBox relativeComboBox;
        private System.Windows.Forms.BindingSource relativesBindingSource;
        private schoolDataSetTableAdapters.relationsTableAdapter relationsTableAdapter1;
        private schoolDataSetTableAdapters.relativesTableAdapter relativesTableAdapter;
    }
}