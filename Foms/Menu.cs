using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselFinalHW_IsmailTunaSeydisehirli
{
    public partial class Menu : Form
    {
        static int a = 0;
        public Menu()
        {
            InitializeComponent();

        }

        //private void Menu_Load(object sender, EventArgs e)
        //{
        //    this.Visible = false;
        //    var t = new Log_in();
        //    t.Show();

        //}

        private void StudentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student std = new Student();
            std.ShowDialog();
            std = null;
            this.Show();

        }

        private void AdministrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff adm = new Staff();
            adm.ShowDialog();
            adm = null;
            this.Show();

        }

        private void ClassesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Lessons lssn = new Lessons();
            lssn.ShowDialog();
            lssn = null;
            this.Show();
        }

        private void ClassSlots_Click(object sender, EventArgs e)
        {
            this.Hide();
            Class_Slots cl = new Class_Slots();
            cl.ShowDialog();
            cl = null;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)// was going to sleep, did this to keep everything together...
        {
            a = a + 1;
            if (a <= 20) 
            {

                clickingLbl.Text = "Clicked " + a + " times";
            }
            else if(a <= 45) 
            {
                clickingLbl.Text = a + " should be enough right!?";
            }

            else if (a <= 60)
            {
                clickingLbl.Text = a + " times... Why?";
            }
            else if (a <= 100)
            {
                clickingLbl.Text = a + " !? Nevermind...";
            }
            else
            {
                clickingLbl.Text = " Bye,going to code now...";
            }




            


        }
    }
}
