namespace GorselFinalHW_IsmailTunaSeydisehirli
{
    partial class Class_Slots
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Sname="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.Update_Button = new System.Windows.Forms.Button();
            this.Add_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LessonSlotIDtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentandLessonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studenttakingtheLessonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonTakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLessonDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchText = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lessonDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.studentDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resetbttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLessonDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Update_Button
            // 
            this.Update_Button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Update_Button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Update_Button.Location = new System.Drawing.Point(545, 107);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(75, 29);
            this.Update_Button.TabIndex = 53;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = false;
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Add_Button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Add_Button.Location = new System.Drawing.Point(455, 107);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 29);
            this.Add_Button.TabIndex = 52;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(360, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(360, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Lesson ID:";
            // 
            // LessonSlotIDtxt
            // 
            this.LessonSlotIDtxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.LessonSlotIDtxt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.LessonSlotIDtxt.Location = new System.Drawing.Point(455, 9);
            this.LessonSlotIDtxt.Name = "LessonSlotIDtxt";
            this.LessonSlotIDtxt.Size = new System.Drawing.Size(165, 26);
            this.LessonSlotIDtxt.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(360, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentandLessonIDDataGridViewTextBoxColumn,
            this.studenttakingtheLessonDataGridViewTextBoxColumn,
            this.lessonTakenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentLessonDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 426);
            this.dataGridView1.TabIndex = 40;
            // 
            // studentandLessonIDDataGridViewTextBoxColumn
            // 
            this.studentandLessonIDDataGridViewTextBoxColumn.DataPropertyName = "Student_and_Lesson_ID";
            this.studentandLessonIDDataGridViewTextBoxColumn.HeaderText = "Student_and_Lesson_ID";
            this.studentandLessonIDDataGridViewTextBoxColumn.Name = "studentandLessonIDDataGridViewTextBoxColumn";
            // 
            // studenttakingtheLessonDataGridViewTextBoxColumn
            // 
            this.studenttakingtheLessonDataGridViewTextBoxColumn.DataPropertyName = "Student_taking_the_Lesson";
            this.studenttakingtheLessonDataGridViewTextBoxColumn.HeaderText = "Student_taking_the_Lesson";
            this.studenttakingtheLessonDataGridViewTextBoxColumn.Name = "studenttakingtheLessonDataGridViewTextBoxColumn";
            // 
            // lessonTakenDataGridViewTextBoxColumn
            // 
            this.lessonTakenDataGridViewTextBoxColumn.DataPropertyName = "Lesson_Taken";
            this.lessonTakenDataGridViewTextBoxColumn.HeaderText = "Lesson_Taken";
            this.lessonTakenDataGridViewTextBoxColumn.Name = "lessonTakenDataGridViewTextBoxColumn";
            // 
            // studentLessonDBBindingSource
            // 
            this.studentLessonDBBindingSource.DataSource = typeof(GorselFinalHW_IsmailTunaSeydisehirli.StudentLessonDB);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchButton.Location = new System.Drawing.Point(491, 195);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(90, 28);
            this.SearchButton.TabIndex = 58;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SearchBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchBox.Location = new System.Drawing.Point(491, 163);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(129, 26);
            this.SearchBox.TabIndex = 57;
            // 
            // SearchText
            // 
            this.SearchText.AutoSize = true;
            this.SearchText.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SearchText.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchText.Location = new System.Drawing.Point(360, 166);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(121, 19);
            this.SearchText.TabIndex = 56;
            this.SearchText.Text = "Item ID to Search:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.comboBox1.DataSource = this.lessonDBBindingSource;
            this.comboBox1.DisplayMember = "Lesson_Name";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(455, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 27);
            this.comboBox1.TabIndex = 59;
            this.comboBox1.ValueMember = "Lesson_ID";
            // 
            // lessonDBBindingSource
            // 
            this.lessonDBBindingSource.DataSource = typeof(GorselFinalHW_IsmailTunaSeydisehirli.LessonDB);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.comboBox2.DataSource = this.studentDBBindingSource;
            this.comboBox2.DisplayMember = "Student_Name";
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox2.Location = new System.Drawing.Point(455, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 27);
            this.comboBox2.TabIndex = 60;
            this.comboBox2.ValueMember = "Student_ID";
            // 
            // studentDBBindingSource
            // 
            this.studentDBBindingSource.DataSource = typeof(GorselFinalHW_IsmailTunaSeydisehirli.StudentDB);
            // 
            // resetbttn
            // 
            this.resetbttn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.resetbttn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.resetbttn.Location = new System.Drawing.Point(360, 410);
            this.resetbttn.Name = "resetbttn";
            this.resetbttn.Size = new System.Drawing.Size(50, 28);
            this.resetbttn.TabIndex = 61;
            this.resetbttn.Text = "reset";
            this.resetbttn.UseVisualStyleBackColor = false;
            this.resetbttn.Click += new System.EventHandler(this.resetbttn_Click_1);
            // 
            // Class_Slots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(632, 450);
            this.Controls.Add(this.resetbttn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LessonSlotIDtxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Class_Slots";
            this.Text = "Class Slots";
            this.Load += new System.EventHandler(this.Class_Slots_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentLessonDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LessonSlotIDtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchText;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource studentDBBindingSource;
        private System.Windows.Forms.BindingSource lessonDBBindingSource;
        private System.Windows.Forms.Button resetbttn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentandLessonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studenttakingtheLessonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonTakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentLessonDBBindingSource;
    }
}