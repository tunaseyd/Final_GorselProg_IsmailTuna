namespace GorselFinalHW_IsmailTunaSeydisehirli
{
    partial class Student
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchText = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.resetbttn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ageGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.majorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dLIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateofRegisterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchButton.Location = new System.Drawing.Point(671, 80);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(105, 27);
            this.SearchButton.TabIndex = 24;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SearchBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchBox.Location = new System.Drawing.Point(671, 50);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(192, 26);
            this.SearchBox.TabIndex = 23;
            // 
            // SearchText
            // 
            this.SearchText.AutoSize = true;
            this.SearchText.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchText.Location = new System.Drawing.Point(667, 31);
            this.SearchText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(121, 19);
            this.SearchText.TabIndex = 22;
            this.SearchText.Text = "Item ID to Search:";
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
            this.dataGridView1.Location = new System.Drawing.Point(15, 31);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 474);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // resetbttn
            // 
            this.resetbttn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.resetbttn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.resetbttn.Location = new System.Drawing.Point(810, 81);
            this.resetbttn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resetbttn.Name = "resetbttn";
            this.resetbttn.Size = new System.Drawing.Size(53, 25);
            this.resetbttn.TabIndex = 44;
            this.resetbttn.Text = "reset";
            this.resetbttn.UseVisualStyleBackColor = false;
            this.resetbttn.Click += new System.EventHandler(this.Resetbttn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(875, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem1,
            this.registerToolStripMenuItem1});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.updateToolStripMenuItem1.Text = "Update";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click_1);
            // 
            // registerToolStripMenuItem1
            // 
            this.registerToolStripMenuItem1.Name = "registerToolStripMenuItem1";
            this.registerToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.registerToolStripMenuItem1.Text = "Register";
            this.registerToolStripMenuItem1.Click += new System.EventHandler(this.RegisterToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.button1.Location = new System.Drawing.Point(671, 478);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 27);
            this.button1.TabIndex = 52;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ageGroupToolStripMenuItem,
            this.majorToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // ageGroupToolStripMenuItem
            // 
            this.ageGroupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.ageGroupToolStripMenuItem.Name = "ageGroupToolStripMenuItem";
            this.ageGroupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ageGroupToolStripMenuItem.Text = "Age Group";
            // 
            // majorToolStripMenuItem
            // 
            this.majorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bIPToolStripMenuItem,
            this.dLIToolStripMenuItem});
            this.majorToolStripMenuItem.Name = "majorToolStripMenuItem";
            this.majorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.majorToolStripMenuItem.Text = "Major";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "18-21";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem3.Text = "21-24";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // bIPToolStripMenuItem
            // 
            this.bIPToolStripMenuItem.Name = "bIPToolStripMenuItem";
            this.bIPToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.bIPToolStripMenuItem.Text = "BIP";
            this.bIPToolStripMenuItem.Click += new System.EventHandler(this.bIPToolStripMenuItem_Click);
            // 
            // dLIToolStripMenuItem
            // 
            this.dLIToolStripMenuItem.Name = "dLIToolStripMenuItem";
            this.dLIToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.dLIToolStripMenuItem.Text = "DLI";
            this.dLIToolStripMenuItem.Click += new System.EventHandler(this.dLIToolStripMenuItem_Click);
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
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 519);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resetbttn);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button resetbttn;

        #endregion
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateofRegisterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentDBBindingSource;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ageGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem majorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dLIToolStripMenuItem;
    }
}