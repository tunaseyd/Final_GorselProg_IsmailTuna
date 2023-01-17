using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselHW1_IsmailTunaSeydisehirli
{
    public partial class MDIParent1 : Form
    {
       

        public MDIParent1()
        {
            InitializeComponent();
        }

        public void SetStatus(ToolStripMenuItem toolStripMenuItem)
        {
            NumWindow.Text = "Last opened window is " + toolStripMenuItem.Text;
        }

        private void classListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ClassWindow = new Lessons();
            ClassWindow.MdiParent = this;
            ClassWindow.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void classUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Class2Window = new ClassChild();
            Class2Window.MdiParent = this;
            Class2Window.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void staffListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var StaffWindow = new Staff();
            StaffWindow.MdiParent = this;
            StaffWindow.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void staffRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Staff2Window = new AdminChild();
            Staff2Window.MdiParent = this;
            Staff2Window.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var StudentWindow = new Student();
            StudentWindow.MdiParent = this;
            StudentWindow.Show();
            SetStatus((ToolStripMenuItem)sender);

        }

        private void studentRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Student2Window = new StudentChild();
            Student2Window.MdiParent = this;
            Student2Window.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        private void oldMenuVersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OldWindows = new Menu();
            OldWindows.MdiParent = this;
            OldWindows.Show();
            SetStatus((ToolStripMenuItem)sender);
        }

        

    }
}
