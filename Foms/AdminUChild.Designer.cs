namespace GorselFinalHW_IsmailTunaSeydisehirli
{
    partial class AdminUChild
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
            this.DivBox = new System.Windows.Forms.ComboBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.StaffDutytxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StaffName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StaffID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDutyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Staff_Division = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DoStaff = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.StaffIDtxt = new System.Windows.Forms.TextBox();
            this.StaffNametx = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DivBox
            // 
            this.DivBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DivBox.FormattingEnabled = true;
            this.DivBox.Items.AddRange(new object[] {
            "Lecturer",
            "Administrator",
            "HR Division"});
            this.DivBox.Location = new System.Drawing.Point(243, 499);
            this.DivBox.Name = "DivBox";
            this.DivBox.Size = new System.Drawing.Size(165, 27);
            this.DivBox.TabIndex = 79;
            // 
            // Add_Button
            // 
            this.Add_Button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Add_Button.Location = new System.Drawing.Point(243, 526);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Button.TabIndex = 77;
            this.Add_Button.Text = "Update";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(86, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 76;
            this.label4.Text = "Type of Duty:";
            // 
            // StaffDutytxt
            // 
            this.StaffDutytxt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.StaffDutytxt.Location = new System.Drawing.Point(243, 474);
            this.StaffDutytxt.Name = "StaffDutytxt";
            this.StaffDutytxt.Size = new System.Drawing.Size(165, 26);
            this.StaffDutytxt.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(86, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 74;
            this.label3.Text = "Duty of Staff:";
            // 
            // StaffName
            // 
            this.StaffName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.StaffName.Location = new System.Drawing.Point(243, 448);
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(165, 26);
            this.StaffName.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(86, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 72;
            this.label2.Text = "Staff Name:";
            // 
            // StaffID
            // 
            this.StaffID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.StaffID.Location = new System.Drawing.Point(243, 422);
            this.StaffID.Name = "StaffID";
            this.StaffID.Size = new System.Drawing.Size(165, 26);
            this.StaffID.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(86, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 70;
            this.label1.Text = "Staff ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.staffNameDataGridViewTextBoxColumn,
            this.staffDutyDataGridViewTextBoxColumn,
            this.Staff_Division});
            this.dataGridView1.DataSource = this.staffDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 340);
            this.dataGridView1.TabIndex = 80;
            // 
            // staffIDDataGridViewTextBoxColumn
            // 
            this.staffIDDataGridViewTextBoxColumn.DataPropertyName = "Staff_ID";
            this.staffIDDataGridViewTextBoxColumn.HeaderText = "Staff_ID";
            this.staffIDDataGridViewTextBoxColumn.Name = "staffIDDataGridViewTextBoxColumn";
            // 
            // staffNameDataGridViewTextBoxColumn
            // 
            this.staffNameDataGridViewTextBoxColumn.DataPropertyName = "Staff_Name";
            this.staffNameDataGridViewTextBoxColumn.HeaderText = "Staff_Name";
            this.staffNameDataGridViewTextBoxColumn.Name = "staffNameDataGridViewTextBoxColumn";
            // 
            // staffDutyDataGridViewTextBoxColumn
            // 
            this.staffDutyDataGridViewTextBoxColumn.DataPropertyName = "Staff_Duty";
            this.staffDutyDataGridViewTextBoxColumn.HeaderText = "Staff_Duty";
            this.staffDutyDataGridViewTextBoxColumn.Name = "staffDutyDataGridViewTextBoxColumn";
            // 
            // Staff_Division
            // 
            this.Staff_Division.DataPropertyName = "Staff_Division";
            this.Staff_Division.HeaderText = "Staff_Division";
            this.Staff_Division.Name = "Staff_Division";
            // 
            // staffDBBindingSource
            // 
            this.staffDBBindingSource.DataSource = typeof(GorselFinalHW_IsmailTunaSeydisehirli.StaffDB);
            // 
            // DoStaff
            // 
            this.DoStaff.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DoStaff.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DoStaff.Location = new System.Drawing.Point(197, 117);
            this.DoStaff.Name = "DoStaff";
            this.DoStaff.Size = new System.Drawing.Size(177, 26);
            this.DoStaff.TabIndex = 86;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button2.Location = new System.Drawing.Point(197, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 29);
            this.button2.TabIndex = 89;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // StaffIDtxt
            // 
            this.StaffIDtxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.StaffIDtxt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.StaffIDtxt.Location = new System.Drawing.Point(197, 53);
            this.StaffIDtxt.Name = "StaffIDtxt";
            this.StaffIDtxt.Size = new System.Drawing.Size(177, 26);
            this.StaffIDtxt.TabIndex = 82;
            // 
            // StaffNametx
            // 
            this.StaffNametx.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.StaffNametx.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.StaffNametx.Location = new System.Drawing.Point(197, 85);
            this.StaffNametx.Name = "StaffNametx";
            this.StaffNametx.Size = new System.Drawing.Size(177, 26);
            this.StaffNametx.TabIndex = 84;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lecturer",
            "Administrator",
            "HR Division"});
            this.comboBox1.Location = new System.Drawing.Point(197, 152);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 27);
            this.comboBox1.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(380, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 91;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(8, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 19);
            this.label8.TabIndex = 92;
            this.label8.Text = "Double click to send item to \"TextBoxes\"";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button1.Location = new System.Drawing.Point(290, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 93;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminUChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(466, 602);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DoStaff);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.StaffIDtxt);
            this.Controls.Add(this.StaffNametx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DivBox);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.StaffDutytxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StaffName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StaffID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AdminUChild";
            this.Text = "AdminUChild";
            this.Load += new System.EventHandler(this.AdminUChild_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DivBox;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StaffDutytxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StaffName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StaffID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffDutyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Staff_Division;
        private System.Windows.Forms.BindingSource staffDBBindingSource;
        private System.Windows.Forms.TextBox DoStaff;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox StaffIDtxt;
        private System.Windows.Forms.TextBox StaffNametx;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}