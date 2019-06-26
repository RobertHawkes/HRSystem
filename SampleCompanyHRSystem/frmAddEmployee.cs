using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCompanyHRSystem
{
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex != tabMain.TabCount - 1)
            {
                tabMain.SelectTab(tabMain.SelectedIndex + 1);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (tabMain.SelectedIndex != 0)
            {
                tabMain.SelectTab(tabMain.SelectedIndex - 1);
            }
        }
    }
}
