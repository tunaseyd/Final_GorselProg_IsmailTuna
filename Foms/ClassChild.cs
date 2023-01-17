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
    public partial class ClassChild : Form
    {
        public ClassChild()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var lssn = new LessonDB()
            {
                Lesson_ID = liBox3.Text,
                Lesson_Name = lBox2.Text,
                Lesson_Credit = int.Parse(lcBox1.Text),
                Assigned_Teacher = ltBox4.Text,


            };
            ctx.LessonDBs.Add(lssn);
            ctx.SaveChanges();


            liBox3.Text = string.Empty;
            lBox2.Text = string.Empty;
            lcBox1.Text = string.Empty;
            ltBox4.Text = string.Empty;
        }

        
    }
}
