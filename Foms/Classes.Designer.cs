namespace GorselFinalHW_IsmailTunaSeydisehirli
{
    partial class Lessons
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DellButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchText = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lessonIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonCreditDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignedTeacherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resetbttn = new System.Windows.Forms.Button();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonDBBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem1,
            this.updateToolStripMenuItem1});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // registerToolStripMenuItem1
            // 
            this.registerToolStripMenuItem1.Name = "registerToolStripMenuItem1";
            this.registerToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.registerToolStripMenuItem1.Text = "Register";
            this.registerToolStripMenuItem1.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.updateToolStripMenuItem1.Text = "Update";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // DellButton
            // 
            this.DellButton.BackColor = System.Drawing.SystemColors.Window;
            this.DellButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.DellButton.Location = new System.Drawing.Point(471, 480);
            this.DellButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DellButton.Name = "DellButton";
            this.DellButton.Size = new System.Drawing.Size(105, 27);
            this.DellButton.TabIndex = 65;
            this.DellButton.Text = "Update";
            this.DellButton.UseVisualStyleBackColor = false;
            this.DellButton.Click += new System.EventHandler(this.UpdButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.Window;
            this.SearchButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchButton.Location = new System.Drawing.Point(471, 87);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(105, 27);
            this.SearchButton.TabIndex = 64;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.SystemColors.Window;
            this.SearchBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchBox.Location = new System.Drawing.Point(471, 57);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(192, 26);
            this.SearchBox.TabIndex = 63;
            // 
            // SearchText
            // 
            this.SearchText.AutoSize = true;
            this.SearchText.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.SearchText.Location = new System.Drawing.Point(467, 38);
            this.SearchText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(101, 19);
            this.SearchText.TabIndex = 62;
            this.SearchText.Text = "Item to Search:";
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
            this.dataGridView1.Location = new System.Drawing.Point(15, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 474);
            this.dataGridView1.TabIndex = 61;
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
            // resetbttn
            // 
            this.resetbttn.BackColor = System.Drawing.SystemColors.Window;
            this.resetbttn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.resetbttn.Location = new System.Drawing.Point(616, 88);
            this.resetbttn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.resetbttn.Name = "resetbttn";
            this.resetbttn.Size = new System.Drawing.Size(49, 25);
            this.resetbttn.TabIndex = 67;
            this.resetbttn.Text = "reset";
            this.resetbttn.UseVisualStyleBackColor = false;
            this.resetbttn.Click += new System.EventHandler(this.resetbttn_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.creditToolStripMenuItem.Text = "Credit";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "<3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "5";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem7.Text = "6>";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // Lessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(676, 519);
            this.Controls.Add(this.resetbttn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.DellButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Lessons";
            this.Text = "Lessons";
            this.Load += new System.EventHandler(this.Classes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonDBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button DellButton;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button resetbttn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonCreditDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignedTeacherDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lessonDBBindingSource;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
    }
}