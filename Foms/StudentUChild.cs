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
    public partial class StudentUChild : Form
    {

        public StudentUChild()
        {
            InitializeComponent();
        }

        private void StudentUChild_Load(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stdnt = ctx.StudentDBs.ToList();


            var bindingList = new BindingList<StudentDB>(stdnt);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {

            var ctx = new SDBEntities();
            var stdnt = new StudentDB()

            {
                Student_ID = StudentIDtxt.Text,
                Student_Name = StudentNametxt.Text,
                Date_of_Register = dateTimePicker1.Value,
                Student_No = int.Parse(SNotxt.Text),
                Date_of_Birth = dateTimePicker2.Value,
                Major = SMtxt.Text


            };
            ctx.StudentDBs.AddOrUpdate(stdnt);
            ctx.SaveChanges();

            StudentNametxt.Text = string.Empty;
            StudentIDtxt.Text = string.Empty;
            SNotxt.Text = string.Empty;
            SMtxt.Text = string.Empty;

        }




        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var ctx = new SDBEntities();
            var stdnt = ctx.StudentDBs.ToList();

            StudentNametxt.Text = string.Empty;
            StudentIDtxt.Text = string.Empty;
            dateTimePicker1.Value = dateTimePicker1.Value;
            SNotxt.Text += string.Empty;
            dateTimePicker2.Value = dateTimePicker2.Value;
            SMtxt.Text = string.Empty;

            StudentNametxt.Text = stdnt.FirstOrDefault().Student_Name;
            StudentIDtxt.Text = stdnt.FirstOrDefault().Student_ID;
            dateTimePicker1.Value = stdnt.FirstOrDefault().Date_of_Register;
            SNotxt.Text += stdnt.FirstOrDefault().Student_No;
            dateTimePicker2.Value = stdnt.FirstOrDefault().Date_of_Birth;
            SMtxt.Text = stdnt.FirstOrDefault().Major;
        }

        private void Del(object sender, EventArgs e)
        {

            //var ctx = new SDBEntities();
            //var stdll = ctx.StudentDBs.FirstOrDefault(t => t.Student_ID == SearchBox.Text);
            //ctx.StudentDBs.Remove(stdll);
            //ctx.SaveChanges();
            //if (StudentEntity != null)
            //{
            //    var ctx = new SDBEntities();
            //    ctx.StudentDBs.ToList().Remove(StudentEntity);
            //    ctx.SaveChanges();

            //    var stdnt = ctx.StudentDBs.ToList();

            //    var bindingList = new BindingList<StudentDB>(stdnt);
            //    var source = new BindingSource(bindingList, null);
            //    dataGridView1.DataSource = source;



            //    //}

            //}
        }
    }
}
