namespace GorselFinalHW_IsmailTunaSeydisehirli
{
    partial class AdminChild
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
            this.Add_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.StaffDutytxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StaffName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StaffID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DivBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Add_Button.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.Add_Button.Location = new System.Drawing.Point(144, 179);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(75, 26);
            this.Add_Button.TabIndex = 67;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(33, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 66;
            this.label4.Text = "Type of Duty:";
            // 
            // StaffDutytxt
            // 
            this.StaffDutytxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.StaffDutytxt.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.StaffDutytxt.Location = new System.Drawing.Point(144, 114);
            this.StaffDutytxt.Name = "StaffDutytxt";
            this.StaffDutytxt.Size = new System.Drawing.Size(165, 26);
            this.StaffDutytxt.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(33, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 64;
            this.label3.Text = "Duty of Staff:";
            // 
            // StaffName
            // 
            this.StaffName.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.StaffName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.StaffName.Location = new System.Drawing.Point(144, 82);
            this.StaffName.Name = "StaffName";
            this.StaffName.Size = new System.Drawing.Size(165, 26);
            this.StaffName.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(33, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "Staff Name:";
            // 
            // StaffID
            // 
            this.StaffID.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.StaffID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.StaffID.Location = new System.Drawing.Point(144, 50);
            this.StaffID.Name = "StaffID";
            this.StaffID.Size = new System.Drawing.Size(165, 26);
            this.StaffID.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 60;
            this.label1.Text = "Staff ID:";
            // 
            // DivBox
            // 
            this.DivBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DivBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DivBox.FormattingEnabled = true;
            this.DivBox.Items.AddRange(new object[] {
            "Lecturer",
            "Administrator",
            "HR Division"});
            this.DivBox.Location = new System.Drawing.Point(144, 146);
            this.DivBox.Name = "DivBox";
            this.DivBox.Size = new System.Drawing.Size(165, 27);
            this.DivBox.TabIndex = 69;
            // 
            // AdminChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(339, 246);
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
            this.Name = "AdminChild";
            this.Text = "AdminChild";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StaffDutytxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StaffName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StaffID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DivBox;
    }
}