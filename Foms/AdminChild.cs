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
    public partial class AdminChild : Form
    {
        public AdminChild()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            var ctx = new SDBEntities();
            var stff = new StaffDB()
            {
                Staff_ID = StaffID.Text,
                Staff_Name = StaffName.Text,
                Staff_Duty = StaffDutytxt.Text,
                Staff_Division = DivBox.Text


            };
            ctx.StaffDBs.Add(stff);
            ctx.SaveChanges();


            StaffID.Text = string.Empty;
            StaffName.Text = string.Empty;
            StaffDutytxt.Text = string.Empty;
            DivBox.Text = string.Empty;
        }

        
    }
}
