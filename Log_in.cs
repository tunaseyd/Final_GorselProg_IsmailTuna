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
    public partial class Log_in : Form
    {
        string username = "Admin";

        string password = "admin123";

        public Log_in()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text == username && PasswordBox.Text == password)
            {
                this.Hide();
                MDIParent1 cl = new MDIParent1();
                cl.ShowDialog();
                cl = null;
                this.Show();

            }
            else
            {
                OutputLabel.Text = "Please try again!!! it is Admin and admin123";
                UsernameBox.Text = string.Empty;
                PasswordBox.Text = string.Empty; 
            }
        }
    }
}
