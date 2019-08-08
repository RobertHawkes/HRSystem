using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SampleCompanyHRSystem
{
    public partial class frmViewFilter : Form
    {

        public frmViewFilter()
        {
            InitializeComponent();
        }

        public frmViewFilter(List<Filter> filters, int index)
        {
            InitializeComponent();
            //txtCategory.Text = filters[index].Category;
            //txtValue.Text = filters[index].Value;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
