namespace GorselFinalHW_IsmailTunaSeydisehirli
{
    partial class StudentUChild
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofRegisterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SNotxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SMtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Update_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentNametxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentIDtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.dateofBirthDataGridViewTextBoxColumn,
            this.studentNoDataGridViewTextBoxColumn,
            this.dateofRegisterDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 400);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "Student_Name";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // dateofBirthDataGridViewTextBoxColumn
            // 
            this.dateofBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Birth";
            this.dateofBirthDataGridViewTextBoxColumn.HeaderText = "Date_of_Birth";
            this.dateofBirthDataGridViewTextBoxColumn.Name = "dateofBirthDataGridViewTextBoxColumn";
            // 
            // studentNoDataGridViewTextBoxColumn
            // 
            this.studentNoDataGridViewTextBoxColumn.DataPropertyName = "Student_No";
            this.studentNoDataGridViewTextBoxColumn.HeaderText = "Student_No";
            this.studentNoDataGridViewTextBoxColumn.Name = "studentNoDataGridViewTextBoxColumn";
            // 
            // dateofRegisterDataGridViewTextBoxColumn
            // 
            this.dateofRegisterDataGridViewTextBoxColumn.DataPropertyName = "Date_of_Register";
            this.dateofRegisterDataGridViewTextBoxColumn.HeaderText = "Date_of_Register";
            this.dateofRegisterDataGridViewTextBoxColumn.Name = "dateofRegisterDataGridViewTextBoxColumn";
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "Major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "Major";
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            // 
            // studentDBBindingSource
            // 
            this.studentDBBindingSource.DataSource = typeof(GorselFinalHW_IsmailTunaSeydisehirli.StudentDB);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Location = new System.Drawing.Point(276, 136);
            this.dateTimePicker2.MaxDate = new System.DateTime(2022, 12, 7, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(218, 25);
            this.dateTimePicker2.TabIndex = 80;
            this.dateTimePicker2.Value = new System.DateTime(2022, 12, 7, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Location = new System.Drawing.Point(276, 74);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 12, 7, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 25);
            this.dateTimePicker1.TabIndex = 79;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 7, 0, 0, 0, 0);
            // 
            // SNotxt
            // 
            this.SNotxt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SNotxt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SNotxt.Location = new System.Drawing.Point(276, 105);
            this.SNotxt.Name = "SNotxt";
            this.SNotxt.Size = new System.Drawing.Size(218, 25);
            this.SNotxt.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(118, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 77;
            this.label7.Text = "Student No:";
            // 
            // SMtxt
            // 
            this.SMtxt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SMtxt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SMtxt.Location = new System.Drawing.Point(276, 167);
            this.SMtxt.Name = "SMtxt";
            this.SMtxt.Size = new System.Drawing.Size(218, 25);
            this.SMtxt.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(118, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 75;
            this.label5.Text = "Major:";
            // 
            // Update_Button
            // 
            this.Update_Button.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Update_Button.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Update_Button.Location = new System.Drawing.Point(276, 198);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(100, 32);
            this.Update_Button.TabIndex = 74;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = false;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(118, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 72;
            this.label4.Text = "Birth Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(118, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 71;
            this.label3.Text = "Date of Registration:";
            // 
            // StudentNametxt
            // 
            this.StudentNametxt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StudentNametxt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudentNametxt.Location = new System.Drawing.Point(276, 43);
            this.StudentNametxt.Name = "StudentNametxt";
            this.StudentNametxt.Size = new System.Drawing.Size(218, 25);
            this.StudentNametxt.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(118, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 69;
            this.label2.Text = "Student Name:";
            // 
            // StudentIDtxt
            // 
            this.StudentIDtxt.BackColor = System.Drawing.SystemColors.ControlDark;
            this.StudentIDtxt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudentIDtxt.Location = new System.Drawing.Point(276, 12);
            this.StudentIDtxt.Name = "StudentIDtxt";
            this.StudentIDtxt.Size = new System.Drawing.Size(218, 25);
            this.StudentIDtxt.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(118, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 67;
            this.label1.Text = "Student ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(500, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 75;
            this.label9.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(500, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 19);
            this.label6.TabIndex = 75;
            this.label6.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 19);
            this.label8.TabIndex = 75;
            this.label8.Text = "Double click to send item to \"TextBoxes\"";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(394, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 32);
            this.button1.TabIndex = 81;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Del);
            // 
            // StudentUChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 674);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.SNotxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SMtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StudentNametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudentIDtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StudentUChild";
            this.Text = "StudentUChild";
            this.Load += new System.EventHandler(this.StudentUChild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentDBBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox SNotxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox SMtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StudentNametxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentIDtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofRegisterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}