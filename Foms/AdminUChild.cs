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
    public partial class AdminUChild : Form
    {
        public AdminUChild()
        {
            InitializeComponent();
        }

        private void AdminUChild_Load(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = ctx.StaffDBs.ToList();

            var bindingList = new BindingList<StaffDB>(stff);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = new StaffDB()

            {
                Staff_ID = StaffIDtxt.Text,
                Staff_Name = StaffNametx.Text,
                Staff_Duty = StaffDutytxt.Text,
                Staff_Division = comboBox1.Text


            };
            ctx.StaffDBs.AddOrUpdate(stff);
            ctx.SaveChanges();

            StaffIDtxt.Text = string.Empty;
            StaffNametx.Text = string.Empty;
            StaffDutytxt.Text = string.Empty;
            comboBox1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
