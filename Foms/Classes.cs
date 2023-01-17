using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselFinalHW_IsmailTunaSeydisehirli
{
    public partial class Lessons : Form
    {
        private List<SchoolLesson> lessons { get; set; } = new List<SchoolLesson>();
        public Lessons()
        {
            InitializeComponent();
        }

        private void Classes_Load(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var lssn = ctx.LessonDBs.ToList();
            var bindingList = new BindingList<LessonDB>(lssn);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        

        

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var lssn = ctx.LessonDBs.ToList().Where(x => x.Lesson_ID == SearchBox.Text || x.Lesson_Name == SearchBox.Text).ToList();


            var bindingList = new BindingList<LessonDB>(lssn);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void UpdButton_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            ClassUChild f = new ClassUChild();
            f.ShowDialog();
            f = null;
            this.Show();

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var registWindow = new ClassChild();
            registWindow.MdiParent = this.MdiParent;
            registWindow.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var updtWindow = new ClassUChild();
            updtWindow.MdiParent = this.MdiParent;
            updtWindow.Show();

            
        }

        private void resetbttn_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var lssn = ctx.LessonDBs.ToList();
            var bindingList = new BindingList<LessonDB>(lssn);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = ctx.LessonDBs.ToList().Where(x => x.Lesson_Credit <= 3).ToList();


            var bindingList = new BindingList<LessonDB>(stff);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = ctx.LessonDBs.ToList().Where(x => x.Lesson_Credit == 4).ToList();


            var bindingList = new BindingList<LessonDB>(stff);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = ctx.LessonDBs.ToList().Where(x => x.Lesson_Credit == 5).ToList();


            var bindingList = new BindingList<LessonDB>(stff);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = ctx.LessonDBs.ToList().Where(x => x.Lesson_Credit >= 6).ToList();


            var bindingList = new BindingList<LessonDB>(stff);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
    }
}
