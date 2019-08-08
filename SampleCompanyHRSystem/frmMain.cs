using System;
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
                FormHandler.openLogin();
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
                FormHandler.openAddEmployee();
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
                FormHandler.openViewEmployee();
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
                FormHandler.openAddSickness();
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
                FormHandler.openEmployeeLeaver();
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
                FormHandler.openViewAnnualLeave();
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
                FormHandler.openAddAnnualLeave();
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
                FormHandler.openViewService();
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
                FormHandler.openAssignEmployeeToService();
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
                FormHandler.openAddService();
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
                FormHandler.openViewTraining();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void mnuItemLogout_Click(object sender, EventArgs e)
        {
            try
            {
                FormHandler.openLogout();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void mnuItemQuit_Click(object sender, EventArgs e)
        {
            try
            {
                //UserHandler.Logout();
                Application.Exit();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void mnuItemAddTrainingDate_Click(object sender, EventArgs e)
        {
            try
            {
                FormHandler.openAddTraining();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void mnuItemRecordTrainingAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                FormHandler.openAddTrainingAttendance();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }
    }
}
