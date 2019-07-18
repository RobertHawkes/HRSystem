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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuItemLogin_Click(object sender, EventArgs e)
        {
            try
            {
                FormHandler.showLoginForm();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void mnuItemAddAnEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                FormHandler.showAddEmployee();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void MnuItemSearchForAnEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                FormHandler.showViewEmployee();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void MnuItemAddSickness_Click(object sender, EventArgs e)
        {
            try
            {
                FormHandler.showAddSickness();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void MnuItemProcessEmployeeAsLeaver_Click(object sender, EventArgs e)
        {
            try
            {
                FormHandler.showEmployeeLeaver();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void ViewAnnualLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormHandler.showViewAnnualLeave();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void AddAnnualLeaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FormHandler.showAddAnnualLeave();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void MnuItemViewService_Click(object sender, EventArgs e)
        {
            try
            {
                FormHandler.showViewService();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void MnuItemAssignEmployeeToService_Click(object sender, EventArgs e)
        {
            try
            {
                FormHandler.showAssignEmployeeToService();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void MnuItemAddAService_Click(object sender, EventArgs e)
        {
            try
            {
                FormHandler.showAddService();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void MnuItemViewTrainingRecords_Click(object sender, EventArgs e)
        {
            try
            {
                FormHandler.showViewTraining();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }
    }
}
