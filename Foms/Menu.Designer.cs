namespace GorselFinalHW_IsmailTunaSeydisehirli
{
    partial class Menu
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
            this.StudentButton = new System.Windows.Forms.Button();
            this.AdministrationButton = new System.Windows.Forms.Button();
            this.ClassesButton = new System.Windows.Forms.Button();
            this.welcomeLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clickingLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StudentButton
            // 
            this.StudentButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StudentButton.Location = new System.Drawing.Point(551, 266);
            this.StudentButton.Margin = new System.Windows.Forms.Padding(4);
            this.StudentButton.Name = "StudentButton";
            this.StudentButton.Size = new System.Drawing.Size(160, 39);
            this.StudentButton.TabIndex = 0;
            this.StudentButton.Text = "Student";
            this.StudentButton.UseVisualStyleBackColor = true;
            this.StudentButton.Click += new System.EventHandler(this.StudentButton_Click);
            // 
            // AdministrationButton
            // 
            this.AdministrationButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdministrationButton.Location = new System.Drawing.Point(336, 266);
            this.AdministrationButton.Margin = new System.Windows.Forms.Padding(4);
            this.AdministrationButton.Name = "AdministrationButton";
            this.AdministrationButton.Size = new System.Drawing.Size(160, 39);
            this.AdministrationButton.TabIndex = 1;
            this.AdministrationButton.Text = "Staff";
            this.AdministrationButton.UseVisualStyleBackColor = true;
            this.AdministrationButton.Click += new System.EventHandler(this.AdministrationButton_Click);
            // 
            // ClassesButton
            // 
            this.ClassesButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ClassesButton.Location = new System.Drawing.Point(111, 266);
            this.ClassesButton.Margin = new System.Windows.Forms.Padding(4);
            this.ClassesButton.Name = "ClassesButton";
            this.ClassesButton.Size = new System.Drawing.Size(160, 39);
            this.ClassesButton.TabIndex = 2;
            this.ClassesButton.Text = "Lessons";
            this.ClassesButton.UseVisualStyleBackColor = true;
            this.ClassesButton.Click += new System.EventHandler(this.ClassesButton_Click);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.AutoSize = true;
            this.welcomeLbl.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.welcomeLbl.Location = new System.Drawing.Point(106, 128);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(605, 54);
            this.welcomeLbl.TabIndex = 4;
            this.welcomeLbl.Text = "Welcome to Basic School UI of Tuna. \r\nNot shiny or anything impressive but let yo" +
    "u get the job done!";
            this.welcomeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(637, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "Click!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clickingLbl
            // 
            this.clickingLbl.AutoSize = true;
            this.clickingLbl.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clickingLbl.Location = new System.Drawing.Point(633, 35);
            this.clickingLbl.Name = "clickingLbl";
            this.clickingLbl.Size = new System.Drawing.Size(0, 15);
            this.clickingLbl.TabIndex = 6;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(809, 318);
            this.Controls.Add(this.clickingLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.welcomeLbl);
            this.Controls.Add(this.ClassesButton);
            this.Controls.Add(this.AdministrationButton);
            this.Controls.Add(this.StudentButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentButton;
        private System.Windows.Forms.Button AdministrationButton;
        private System.Windows.Forms.Button ClassesButton;
        private System.Windows.Forms.Label welcomeLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label clickingLbl;
    }
}

