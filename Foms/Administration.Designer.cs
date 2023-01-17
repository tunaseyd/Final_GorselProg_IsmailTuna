namespace GorselFinalHW_IsmailTunaSeydisehirli
{
    partial class Staff
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
            this.DellButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchText = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.staffIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDutyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDivisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filtersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffDutyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetbttn = new System.Windows.Forms.Button();
            this.teacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.othersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDBBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DellButton
            // 
            this.DellButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DellButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DellButton.Location = new System.Drawing.Point(463, 410);
            this.DellButton.Name = "DellButton";
            this.DellButton.Size = new System.Drawing.Size(90, 28);
            this.DellButton.TabIndex = 55;
            this.DellButton.Text = "Update";
            this.DellButton.UseVisualStyleBackColor = false;
            this.DellButton.Click += new System.EventHandler(this.UpdButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchButton.Location = new System.Drawing.Point(463, 85);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(90, 31);
            this.SearchButton.TabIndex = 43;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SearchBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchBox.Location = new System.Drawing.Point(463, 53);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(165, 26);
            this.SearchBox.TabIndex = 42;
            // 
            // SearchText
            // 
            this.SearchText.AutoSize = true;
            this.SearchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SearchText.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchText.Location = new System.Drawing.Point(463, 27);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(101, 19);
            this.SearchText.TabIndex = 41;
            this.SearchText.Text = "Item to Search:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.staffIDDataGridViewTextBoxColumn,
            this.staffNameDataGridViewTextBoxColumn,
            this.staffDutyDataGridViewTextBoxColumn,
            this.staffDivisionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.staffDBBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 411);
            this.dataGridView1.TabIndex = 40;
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
            // staffDivisionDataGridViewTextBoxColumn
            // 
            this.staffDivisionDataGridViewTextBoxColumn.DataPropertyName = "Staff_Division";
            this.staffDivisionDataGridViewTextBoxColumn.HeaderText = "Staff_Division";
            this.staffDivisionDataGridViewTextBoxColumn.Name = "staffDivisionDataGridViewTextBoxColumn";
            // 
            // staffDBBindingSource
            // 
            this.staffDBBindingSource.DataSource = typeof(GorselFinalHW_IsmailTunaSeydisehirli.StaffDB);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem,
            this.filtersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 60;
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
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // registerToolStripMenuItem1
            // 
            this.registerToolStripMenuItem1.Name = "registerToolStripMenuItem1";
            this.registerToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.registerToolStripMenuItem1.Text = "Register";
            this.registerToolStripMenuItem1.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // filtersToolStripMenuItem
            // 
            this.filtersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffTypeToolStripMenuItem,
            this.staffDutyToolStripMenuItem});
            this.filtersToolStripMenuItem.Name = "filtersToolStripMenuItem";
            this.filtersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.filtersToolStripMenuItem.Text = "Filters";
            // 
            // staffTypeToolStripMenuItem
            // 
            this.staffTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lecturerToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.hRToolStripMenuItem});
            this.staffTypeToolStripMenuItem.Name = "staffTypeToolStripMenuItem";
            this.staffTypeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.staffTypeToolStripMenuItem.Text = "Staff Division";
            // 
            // lecturerToolStripMenuItem
            // 
            this.lecturerToolStripMenuItem.Name = "lecturerToolStripMenuItem";
            this.lecturerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lecturerToolStripMenuItem.Text = "Lecturer";
            this.lecturerToolStripMenuItem.Click += new System.EventHandler(this.lecturerToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.administrationToolStripMenuItem.Text = "Administration";
            this.administrationToolStripMenuItem.Click += new System.EventHandler(this.administrationToolStripMenuItem_Click);
            // 
            // hRToolStripMenuItem
            // 
            this.hRToolStripMenuItem.Name = "hRToolStripMenuItem";
            this.hRToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hRToolStripMenuItem.Text = "HR";
            this.hRToolStripMenuItem.Click += new System.EventHandler(this.hRToolStripMenuItem_Click);
            // 
            // staffDutyToolStripMenuItem
            // 
            this.staffDutyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teacherToolStripMenuItem,
            this.othersToolStripMenuItem});
            this.staffDutyToolStripMenuItem.Name = "staffDutyToolStripMenuItem";
            this.staffDutyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.staffDutyToolStripMenuItem.Text = "Staff Duty";
            // 
            // resetbttn
            // 
            this.resetbttn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.resetbttn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.resetbttn.Location = new System.Drawing.Point(571, 85);
            this.resetbttn.Name = "resetbttn";
            this.resetbttn.Size = new System.Drawing.Size(57, 32);
            this.resetbttn.TabIndex = 61;
            this.resetbttn.Text = "reset";
            this.resetbttn.UseVisualStyleBackColor = false;
            this.resetbttn.Click += new System.EventHandler(this.resetbttn_Click);
            // 
            // teacherToolStripMenuItem
            // 
            this.teacherToolStripMenuItem.Name = "teacherToolStripMenuItem";
            this.teacherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.teacherToolStripMenuItem.Text = "Teacher";
            this.teacherToolStripMenuItem.Click += new System.EventHandler(this.teacherToolStripMenuItem_Click);
            // 
            // othersToolStripMenuItem
            // 
            this.othersToolStripMenuItem.Name = "othersToolStripMenuItem";
            this.othersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.othersToolStripMenuItem.Text = "others...";
            this.othersToolStripMenuItem.Click += new System.EventHandler(this.othersToolStripMenuItem_Click);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.resetbttn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DellButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Administration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffDBBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DellButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button resetbttn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffDutyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffDivisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource staffDBBindingSource;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filtersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffDutyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem othersToolStripMenuItem;
    }
}