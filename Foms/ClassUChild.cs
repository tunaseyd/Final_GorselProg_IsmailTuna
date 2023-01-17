using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselFinalHW_IsmailTunaSeydisehirli
{
    public partial class ClassUChild : Form
    {
        public ClassUChild()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var lssn = new LessonDB()

            {
                Lesson_ID = liBox3.Text,
                Lesson_Name = lBox2.Text,
                Lesson_Credit = int.Parse(lcBox1.Text),
                Assigned_Teacher = ltBox4.Text


            };
            ctx.LessonDBs.AddOrUpdate(lssn);
            ctx.SaveChanges();

            liBox3.Text = string.Empty;
            lBox2.Text = string.Empty;
            lcBox1.Text = string.Empty;
            ltBox4.Text = string.Empty;
        }
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            var ctx = new SDBEntities();
            var lssn = ctx.LessonDBs.ToList();

            liBox3.Text = lssn.FirstOrDefault().Lesson_ID;
            lBox2.Text = lssn.FirstOrDefault().Lesson_Name;
            lcBox1.Text += lssn.FirstOrDefault().Lesson_Credit;
            ltBox4.Text = lssn.FirstOrDefault().Assigned_Teacher;
        }

        private void ClassUChild_Load(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var lssn = ctx.LessonDBs.ToList();


            var bindingList = new BindingList<LessonDB>(lssn);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
