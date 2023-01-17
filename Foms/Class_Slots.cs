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
    public partial class Class_Slots : Form
    {
        

        public Class_Slots()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Menu newForm = new Menu();
            this.Visible = false;
            newForm.Show();
            this.Close();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stls = new StudentLessonDB()
            {
                Student_and_Lesson_ID = LessonSlotIDtxt.Text,
                Lesson_Taken = comboBox1.Text,
                Student_taking_the_Lesson = comboBox2.Text,


            };
            ctx.StudentLessonDBs.Add(stls);
            ctx.SaveChanges();

            LessonSlotIDtxt.Text = string.Empty;
            comboBox1.Text = string.Empty; 
            comboBox2.Text = string.Empty;
            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stls = ctx.StudentLessonDBs.ToList().Where(x => x.Student_and_Lesson_ID == SearchBox.Text || x.Student_taking_the_Lesson == SearchBox.Text || x.Lesson_Taken == SearchBox.Text).ToList();


            var bindingList = new BindingList<StudentLessonDB>(stls);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void DellButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);

        }


        private void Class_Slots_Load(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stls = ctx.StudentLessonDBs.ToList();

            var bindingList = new BindingList<StudentLessonDB>(stls);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void resetbttn_Click_1(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stls = ctx.StudentLessonDBs.ToList();

            var bindingList = new BindingList<StudentLessonDB>(stls);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
    }
}
