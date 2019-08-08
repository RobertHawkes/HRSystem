using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SampleCompanyHRSystem
{
    public partial class frmViewEmployee : Form
    {
        private frmViewFilter ViewFilter;
        private bool ViewFilterOpen = false;

        public List<Filter> filters = new List<Filter>();

        public frmViewEmployee()
        {
            InitializeComponent();
        }

        private void DgvFilter_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(!ViewFilterOpen)
            {
                ViewFilter = new frmViewFilter(filters, e.RowIndex);
                ViewFilter.Show();
            }
            else
            {
                MessageBox.Show("Please close the existing View Filter screen by clicking save or cancel");
                ViewFilter.Show();
                ViewFilter.BringToFront();
                ViewFilter.Visible = true;
            }


        }

        private void FrmViewEmployee_Load(object sender, System.EventArgs e)
        {
            try
            {
                LoadComboBox();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void LoadComboBox()
        {
            try
            {
                cmbCategory.Items.Clear();

                //for (int i = 0; i < employeeTable.row.count; i++)
                //{
                //    cmbCategory.Items.Add(employeeTable.row[i].ToString());
                //}
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void BtnViewEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                //FormHandler.openEmployee();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }
    }
}
