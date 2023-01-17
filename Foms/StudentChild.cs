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
    public partial class StudentChild : Form
    {
        public StudentChild()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, EventArgs e)
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
            ctx.StudentDBs.Add(stdnt);
            ctx.SaveChanges();
            
            
            StudentNametxt.Text = string.Empty;
            StudentIDtxt.Text = string.Empty;
            SNotxt.Text = string.Empty;
            SMtxt.Text = string.Empty;
            
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {

        }

        private void StudentChild_Load(object sender, EventArgs e)
        {

        }
    }
}
