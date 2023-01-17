namespace GorselFinalHW_IsmailTunaSeydisehirli
{
    partial class ClassUChild
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
            this.lcBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lBox2 = new System.Windows.Forms.TextBox();
            this.ltBox4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.liBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lessonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonCreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lcBox1
            // 
            this.lcBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lcBox1.Location = new System.Drawing.Point(196, 97);
            this.lcBox1.Name = "lcBox1";
            this.lcBox1.Size = new System.Drawing.Size(177, 26);
            this.lcBox1.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button2.Location = new System.Drawing.Point(196, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 29);
            this.button2.TabIndex = 27;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(85, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lesson Name:";
            // 
            // lBox2
            // 
            this.lBox2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lBox2.Location = new System.Drawing.Point(196, 65);
            this.lBox2.Name = "lBox2";
            this.lBox2.Size = new System.Drawing.Size(177, 26);
            this.lBox2.TabIndex = 19;
            // 
            // ltBox4
            // 
            this.ltBox4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.ltBox4.Location = new System.Drawing.Point(196, 129);
            this.ltBox4.Name = "ltBox4";
            this.ltBox4.Size = new System.Drawing.Size(177, 26);
            this.ltBox4.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(85, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Lesson ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(85, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Teacher ID:";
            // 
            // liBox3
            // 
            this.liBox3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.liBox3.Location = new System.Drawing.Point(196, 33);
            this.liBox3.Name = "liBox3";
            this.liBox3.Size = new System.Drawing.Size(177, 26);
            this.liBox3.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(85, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Credit:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lessonIDDataGridViewTextBoxColumn,
            this.lessonNameDataGridViewTextBoxColumn,
            this.lessonCreditDataGridViewTextBoxColumn,
            this.assignedTeacherDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lessonDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 379);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // lessonIDDataGridViewTextBoxColumn
            // 
            this.lessonIDDataGridViewTextBoxColumn.DataPropertyName = "Lesson_ID";
            this.lessonIDDataGridViewTextBoxColumn.HeaderText = "Lesson_ID";
            this.lessonIDDataGridViewTextBoxColumn.Name = "lessonIDDataGridViewTextBoxColumn";
            // 
            // lessonNameDataGridViewTextBoxColumn
            // 
            this.lessonNameDataGridViewTextBoxColumn.DataPropertyName = "Lesson_Name";
            this.lessonNameDataGridViewTextBoxColumn.HeaderText = "Lesson_Name";
            this.lessonNameDataGridViewTextBoxColumn.Name = "lessonNameDataGridViewTextBoxColumn";
            // 
            // lessonCreditDataGridViewTextBoxColumn
            // 
            this.lessonCreditDataGridViewTextBoxColumn.DataPropertyName = "Lesson_Credit";
            this.lessonCreditDataGridViewTextBoxColumn.HeaderText = "Lesson_Credit";
            this.lessonCreditDataGridViewTextBoxColumn.Name = "lessonCreditDataGridViewTextBoxColumn";
            // 
            // assignedTeacherDataGridViewTextBoxColumn
            // 
            this.assignedTeacherDataGridViewTextBoxColumn.DataPropertyName = "Assigned_Teacher";
            this.assignedTeacherDataGridViewTextBoxColumn.HeaderText = "Assigned_Teacher";
            this.assignedTeacherDataGridViewTextBoxColumn.Name = "assignedTeacherDataGridViewTextBoxColumn";
            // 
            // lessonDBBindingSource
            // 
            this.lessonDBBindingSource.DataSource = typeof(GorselFinalHW_IsmailTunaSeydisehirli.LessonDB);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(379, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 76;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 19);
            this.label8.TabIndex = 77;
            this.label8.Text = "Double click to send item to \"TextBoxes\"";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button1.Location = new System.Drawing.Point(286, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 78;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClassUChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(467, 674);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lcBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBox2);
            this.Controls.Add(this.ltBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.liBox3);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClassUChild";
            this.Text = "ClassUChild";
            this.Load += new System.EventHandler(this.ClassUChild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lcBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lBox2;
        private System.Windows.Forms.TextBox ltBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox liBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonCreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lessonDBBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}