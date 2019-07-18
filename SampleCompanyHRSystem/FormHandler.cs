using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCompanyHRSystem
{
    static class FormHandler
    {
        static frmLogin LoginForm;
        static frmLogout LogoutForm;
        static frmMain MainForm;
        static frmAddEmployee AddEmployee;
        static frmViewEmployee ViewEmployee;
        static frmAddSickness AddSickness;
        static frmEmployeeLeaver EmployeeLeaver;
        static frmViewAnnualLeave ViewAnnualLeave;
        static frmAddAnnualLeave AddAnnualLeave;
        static frmViewService ViewService;
        static frmAssignEmployeeToService AssignEmployeeToService;
        static frmAddService AddService;
        static frmViewTraining ViewTraining;

        #region Main

        public static void openMain()
        {
            if (MainForm != new frmMain())
            {
                createMainForm();

            }
            showMainForm();
        }
        public static void createMainForm()
        {
            MainForm = new frmMain();
        }

        public static void showMainForm()
        {
            MainForm.Show();
        }

        public static void hideMainForm()
        {
            MainForm.Hide();
        }
        #endregion

        #region Login

        public static void openLogin()
        {
            if(LoginForm != new frmLogin())
            {
                createLoginForm();
                
            }
            showLoginForm();
        }
        public static void createLoginForm()
        {
            LoginForm = new frmLogin();
        }

        public static void showLoginForm()
        {
            LoginForm = new frmLogin();
            LoginForm.Show();
        }

        public static void hideLoginForm()
        {
            LoginForm.Hide();
        }
        #endregion

        #region Logout
        public static void openLogout()
        {
            if (LogoutForm != new frmLogout())
            {
                createLogoutForm();

            }
            showLogoutForm();
        }
        public static void createLogoutForm()
        {
            LogoutForm = new frmLogout();
        }

        public static void showLogoutForm()
        {
            LogoutForm = new frmLogout();
            LogoutForm.Show();
        }

        public static void hideLogoutForm()
        {
            LogoutForm.Hide();
        }
        #endregion

        #region Add Employee

        public static void openAddEmployee()
        {
            if(AddEmployee != new frmAddEmployee())
            {
                createAddEmployeeForm();
                
            }

            showAddEmployee();
        }
        public static void createAddEmployeeForm()
        {
            AddEmployee = new frmAddEmployee();
        }

        public static void showAddEmployee()
        {
            AddEmployee = new frmAddEmployee();
            AddEmployee.Show();
        }

        public static void hideAddEmployee()
        {
            AddEmployee.Hide();
        }
        #endregion

        #region View Employee

        public static void openViewEmployee()
        {
            if (ViewEmployee != new frmViewEmployee())
            {
                createViewEmployeeForm();
            }
            showViewEmployee();
        }
        public static void createViewEmployeeForm()
        {
            ViewEmployee = new frmViewEmployee();
        }

        public static void showViewEmployee()
        {
            ViewEmployee = new frmViewEmployee();
            ViewEmployee.Show();
        }

        public static void hideViewEmployee()
        {
            ViewEmployee = new frmViewEmployee();
            ViewEmployee.Hide();
        }
        #endregion

        #region Add Sickness
        public static void openAddSickness()
        {
            if (AddSickness != new frmAddSickness())
            {
                createAddSicknessForm();
            }
            showAddSickness();
        }

        public static void createAddSicknessForm()
        {
            AddSickness = new frmAddSickness();
        }

        public static void showAddSickness()
        {
            AddSickness.Show();
        }

        public static void hideAddSickness()
        {
            AddSickness = new frmAddSickness();
            AddSickness.Hide();
        }
        #endregion

        #region Employee Leaver
        public static void openEmployeeLeaver()
        {
            if (EmployeeLeaver != new frmEmployeeLeaver())
            {
                createEmployeeLeaverForm();
            }
            showEmployeeLeaver();
        }
        public static void createEmployeeLeaverForm()
        {
            EmployeeLeaver = new frmEmployeeLeaver();
        }

        public static void showEmployeeLeaver()
        {
            EmployeeLeaver.Show();
        }

        public static void hideEmployeeLeaver()
        {
            EmployeeLeaver = new frmEmployeeLeaver();
            EmployeeLeaver.Hide();
        }
        #endregion

        #region View Annual Leave
        public static void openViewAnnualLeave()
        {
            if (ViewAnnualLeave != new frmViewAnnualLeave())
            {
                createViewAnnualLeaveForm();
            }
            showViewAnnualLeave();
        }

        public static void createViewAnnualLeaveForm()
        {
            ViewAnnualLeave = new frmViewAnnualLeave();
        }

        public static void showViewAnnualLeave()
        {
            ViewAnnualLeave.Show();
        }

        public static void hideViewAnnualLeave()
        {
            ViewAnnualLeave = new frmViewAnnualLeave();
            ViewAnnualLeave.Hide();
        }
        #endregion

        #region Add Annual Leave

        public static void openAddAnnualLeave()
        {
            if (AddAnnualLeave != new frmAddAnnualLeave())
            {
                createAddAnnualLeaveForm();
            }
            showAddAnnualLeave();
        }

        public static void createAddAnnualLeaveForm()
        {
            AddAnnualLeave = new frmAddAnnualLeave();
        }

        public static void showAddAnnualLeave()
        {
            AddAnnualLeave.Show();
        }

        public static void hideAddAnnualLeave()
        {
            AddAnnualLeave = new frmAddAnnualLeave();
            AddAnnualLeave.Hide();
        }
        #endregion

        #region View Service

        public static void openViewService()
        {
            if (ViewService != new frmViewService())
            {
                createViewServiceForm();
            }
            showViewService();
        }

        public static void createViewServiceForm()
        {
            ViewService = new frmViewService();
        }

        public static void showViewService()
        {
            ViewService.Show();
        }

        public static void hideViewService()
        {
            ViewService = new frmViewService();
            ViewService.Hide();
        }
        #endregion

        #region Assign Employee To Service

        public static void openAssignEmployeeToService()
        {
            if (AssignEmployeeToService != new frmAssignEmployeeToService())
            {
                createAssignEmployeeToServiceForm();
            }
            showAssignEmployeeToService();
        }

        public static void createAssignEmployeeToServiceForm()
        {
            AssignEmployeeToService = new frmAssignEmployeeToService();
        }

        public static void showAssignEmployeeToService()
        {
            AssignEmployeeToService.Show();
        }

        public static void hideAssignEmployeeToService()
        {
            AssignEmployeeToService = new frmAssignEmployeeToService();
            AssignEmployeeToService.Hide();
        }
        #endregion

        #region Add Service

        public static void openAddService()
        {
            if (AddService != new frmAddService())
            {
                createAddServiceForm();
            }
            showAddService();
        }

        public static void createAddServiceForm()
        {
            AddService = new frmAddService();
        }
        public static void showAddService()
        {
            AddService.Show();
        }

        public static void hideAddService()
        {
            AddService = new frmAddService();
            AddService.Hide();
        }
        #endregion Add Service

        #region View Training

        public static void openViewTraining()
        {
            if (ViewTraining != new frmViewTraining())
            {
                createViewTrainingForm();
            }
            showViewTraining();
        }

        public static void createViewTrainingForm()
        {
            ViewTraining = new frmViewTraining();
        }

        public static void showViewTraining()
        {
            ViewTraining.Show();
        }

        public static void hideViewTraining()
        {
            ViewTraining = new frmViewTraining();
            ViewTraining.Hide();
        }
        #endregion
    }
}
