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
    

    public partial class Staff : Form // Form names stayed as Administration
    {
        private List<SchoolAdm> staff { get; set; } = new List<SchoolAdm>();
        public Staff()
        {
            InitializeComponent();
        }

        


        private void Administration_Load(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = ctx.StaffDBs.ToList();
            var bindingList = new BindingList<StaffDB>(stff);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = ctx.StaffDBs.ToList().Where(x => x.Staff_ID == SearchBox.Text || x.Staff_Name == SearchBox.Text).ToList();


            var bindingList = new BindingList<StaffDB>(stff);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeni = new AdminChild();
            yeni.MdiParent = this.MdiParent;
            yeni.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var yeni = new AdminUChild();
            yeni.MdiParent = this.MdiParent;
            yeni.Show();
        }

        private void resetbttn_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = ctx.StaffDBs.ToList();
            var bindingList = new BindingList<StaffDB>(stff);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void UpdButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            AdminUChild f = new AdminUChild();
            f.ShowDialog();
            f = null;
            this.Show();

            
        }

        private void lecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = ctx.StaffDBs.ToList().Where(x => int.Parse(x.Staff_Division) == 12).ToList();


            var bindingList = new BindingList<StaffDB>(stff);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void administrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = ctx.StaffDBs.ToList().Where(x => int.Parse(x.Staff_Division) == 11).ToList();


            var bindingList = new BindingList<StaffDB>(stff);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void hRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = ctx.StaffDBs.ToList().Where(x => int.Parse(x.Staff_Division) == 13).ToList();


            var bindingList = new BindingList<StaffDB>(stff);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = ctx.StaffDBs.ToList().Where(x => x.Staff_Duty == "Teacher").ToList();


            var bindingList = new BindingList<StaffDB>(stff);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }

        private void othersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = ctx.StaffDBs.ToList().Where(x => x.Staff_Duty != "Teacher").ToList();


            var bindingList = new BindingList<StaffDB>(stff);
            var source = new BindingSource(bindingList, null);
            dataGridView1.DataSource = source;
        }
    }
}
