using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SampleCompanyHRSystem
{
    static class FormHandler
    {
        static frmLogin Login = new frmLogin();
        static Boolean LoginOpen = false;
        static frmLogout Logout = new frmLogout();
        static Boolean LogoutOpen = false;
        static frmForgotPassword ForgotPassword = new frmForgotPassword();
        static Boolean ForgotPasswordOpen = false;
        static frmMain Main = new frmMain();
        static Boolean MainOpen = true;
        static frmAddEmployee AddEmployee = new frmAddEmployee();
        static Boolean AddEmployeeOpen = false;
        static frmViewEmployee ViewEmployee = new frmViewEmployee();
        static Boolean ViewEmployeeOpen = false;
        static frmAddSickness AddSickness = new frmAddSickness();
        static Boolean AddSicknessOpen = false;
        static frmEmployeeLeaver EmployeeLeaver = new frmEmployeeLeaver();
        static Boolean EmployeeLeaverOpen = false;
        static frmViewAnnualLeave ViewAnnualLeave = new frmViewAnnualLeave();
        static Boolean ViewAnnualLeaveOpen = false;
        static frmAddAnnualLeave AddAnnualLeave = new frmAddAnnualLeave();
        static Boolean AddAnnualLeaveOpen = false;
        static frmViewService ViewService = new frmViewService();
        static Boolean ViewServiceOpen = false;
        static frmAssignEmployeeToService AssignEmployeeToService = new frmAssignEmployeeToService();
        static Boolean AssignEmployeeToServiceOpen = false;
        static frmAddService AddService = new frmAddService();
        static Boolean AddServiceOpen = false;
        static frmViewTraining ViewTraining = new frmViewTraining();
        static Boolean ViewTrainingOpen = false;
        static frmAddTraining AddTraining = new frmAddTraining();
        static Boolean AddTrainingOpen = false;
        static frmAddTrainingAttendance AddTrainingAttendance = new frmAddTrainingAttendance();
        static Boolean AddTrainingAttendanceOpen = false;
        static frmViewFilter ViewFilter = new frmViewFilter();

        #region Main
        public static void openMain()
        {
            //Check if Main has been previously disposed
            if (Main.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createMain();
            }

            //Show form
            showMain();
        }

        public static void createMain()
        {
            Main = new frmMain();
        }

        public static void showMain()
        {
            Main.Show();

            //Mark form as open
            MainOpen = true;
        }

        public static void hideMain()
        {
            Main.Hide();

            //Mark form as closed
            MainOpen = false;
        }

        public static void closeMain()
        {
            Main.Close();

            //Mark form as closed
            MainOpen = false;
        }
        #endregion

        #region Login
        public static void createLogin()
        {
            Login = new frmLogin();
        }

        public static void openLogin()
        {
            //Check if Login has been previously disposed
            if (Login.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createLogin();
            }

            //Show form
            showLogin();
        }

        public static void showLogin()
        {
            Login.Show();

            //Mark form as open
            LoginOpen = true;
        }

        public static void hideLogin()
        {
            Login.Hide();

            //Mark form as closed
            LoginOpen = false;
        }

        public static void closeLogin()
        {
            Login.Close();

            //Mark form as closed
            LoginOpen = false;
        }
        #endregion

        #region Logout
        public static void createLogout()
        {
            Logout = new frmLogout();
        }

        public static void openLogout()
        {
            //Check if Logout has been previously disposed
            if (Logout.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createLogout();
            }

            //Show form
            showLogout();
        }

        public static void showLogout()
        {
            Logout.Show();

            //Mark form as open
            LogoutOpen = true;
        }
        public static void hideLogout()
        {
            Logout.Hide();

            //Mark form as closed
            LogoutOpen = false;
        }

        public static void closeLogout()
        {
            Logout.Close();

            //Mark form as closed
            LogoutOpen = false;
        }
        #endregion

        #region Forgot Password
        public static void openForgotPassword()
        {
            //Check if ForgotPassword has been previously disposed
            if (ForgotPassword.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createForgotPassword();
            }

            //Show form
            showForgotPassword();
        }

        public static void createForgotPassword()
        {
            ForgotPassword = new frmForgotPassword();
        }

        public static void showForgotPassword()
        {
            ForgotPassword.Show();

            //Mark form as open
            ForgotPasswordOpen = true;
        }

        public static void hideForgotPassword()
        {
            ForgotPassword.Hide();

            //Mark form as closed
            ForgotPasswordOpen = false;
        }

        public static void closeForgotPassword()
        {
            ForgotPassword.Close();

            //Mark form as closed
            ForgotPasswordOpen = false;
        }
        #endregion

        #region Add Employee
        public static void createAddEmployee()
        {
            AddEmployee = new frmAddEmployee();
        }

        public static void openAddEmployee()
        {
            //Check if AddEmployee has been previously disposed
            if (AddEmployee.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createAddEmployee();
            }

            //Show form
            showAddEmployee();
        }

        public static void showAddEmployee()
        {
            AddEmployee.Show();

            //Mark form as open
            AddEmployeeOpen = true;
        }

        public static void hideAddEmployee()
        {
            AddEmployee.Hide();

            //Mark form as closed
            AddEmployeeOpen = false;
        }

        public static void closeAddEmployee()
        {
            AddEmployee.Close();

            //Mark form as closed
            AddEmployeeOpen = false;
        }
        #endregion

        #region View Employee
        public static void createViewEmployee()
        {
            ViewEmployee = new frmViewEmployee();
        }

        public static void openViewEmployee()
        {
            //Check if ViewEmployee has been previously disposed
            if (ViewEmployee.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createViewEmployee();
            }

            //Show form
            showViewEmployee();
        }

        public static void showViewEmployee()
        {
            ViewEmployee.Show();

            //Mark form as open
            ViewEmployeeOpen = true;
        }

        public static void hideViewEmployee()
        {
            ViewEmployee.Hide();

            //Mark form as closed
            ViewEmployeeOpen = false;
        }

        public static void closeViewEmployee()
        {
            ViewEmployee.Close();

            //Mark form as closed
            ViewEmployeeOpen = false;
        }
        #endregion

        #region Add Sickness
        public static void createAddSickness()
        {
            AddSickness = new frmAddSickness();
        }

        public static void openAddSickness()
        {
            //Check if AddSickness has been previously disposed
            if (AddSickness.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createAddSickness();
            }

            //Show form
            showAddSickness();
        }

        public static void showAddSickness()
        {
            AddSickness.Show();

            //Mark form as open
            AddSicknessOpen = true;
        }

        public static void hideAddSickness()
        {
            AddSickness.Hide();

            //Mark form as closed
            AddSicknessOpen = false;
        }

        public static void closeAddSickness()
        {
            AddSickness.Close();

            //Mark form as closed
            AddSicknessOpen = false;
        }
        #endregion

        #region Employee Leaver
        public static void createEmployeeLeaver()
        {
            EmployeeLeaver = new frmEmployeeLeaver();
        }

        public static void openEmployeeLeaver()
        {
            //Check if EmployeeLeaver has been previously disposed
            if (EmployeeLeaver.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createEmployeeLeaver();
            }

            //Show form
            showEmployeeLeaver();
        }

        public static void showEmployeeLeaver()
        {
            EmployeeLeaver.Show();

            //Mark form as open
            EmployeeLeaverOpen = true;
        }

        public static void hideEmployeeLeaver()
        {
            EmployeeLeaver.Hide();

            //Mark form as closed
            EmployeeLeaverOpen = false;
        }

        public static void closeEmployeeLeaver()
        {
            EmployeeLeaver.Close();

            //Mark form as closed
            EmployeeLeaverOpen = false;
        }
        #endregion

        #region View Annual Leave
        public static void createViewAnnualLeave()
        {
            ViewAnnualLeave = new frmViewAnnualLeave();
        }

        public static void openViewAnnualLeave()
        {
            //Check if ViewAnnualLeave has been previously disposed
            if (ViewAnnualLeave.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createViewAnnualLeave();
            }

            //Show form
            showViewAnnualLeave();
        }

        public static void showViewAnnualLeave()
        {
            ViewAnnualLeave.Show();

            //Mark form as open
            ViewAnnualLeaveOpen = true;
        }

        public static void hideViewAnnualLeave()
        {
            ViewAnnualLeave.Hide();

            //Mark form as closed
            ViewAnnualLeaveOpen = false;
        }

        public static void closeViewAnnualLeave()
        {
            ViewAnnualLeave.Close();

            //Mark form as closed
            ViewAnnualLeaveOpen = false;
        }
        #endregion

        #region Add Annual Leave
        public static void createAddAnnualLeave()
        {
            AddAnnualLeave = new frmAddAnnualLeave();
        }

        public static void openAddAnnualLeave()
        {
            //Check if AddAnnualLeave has been previously disposed
            if (AddAnnualLeave.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createAddAnnualLeave();
            }

            //Show form
            showAddAnnualLeave();
        }

        public static void showAddAnnualLeave()
        {
            AddAnnualLeave.Show();

            //Mark form as open
            AddAnnualLeaveOpen = true;
        }

        public static void hideAddAnnualLeave()
        {
            AddAnnualLeave.Hide();

            //Mark form as closed
            AddAnnualLeaveOpen = false;
        }

        public static void closeAddAnnualLeave()
        {
            AddAnnualLeave.Close();

            //Mark form as closed
            AddAnnualLeaveOpen = false;
        }
        #endregion

        #region View Service
        public static void createViewService()
        {
            ViewService = new frmViewService();
        }

        public static void openViewService()
        {
            //Check if ViewService has been previously disposed
            if (ViewService.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createViewService();
            }

            //Show form
            showViewService();
        }

        public static void showViewService()
        {
            ViewService.Show();

            //Mark form as open
            ViewServiceOpen = true;
        }

        public static void hideViewService()
        {
            ViewService.Hide();

            //Mark form as closed
            ViewServiceOpen = false;
        }

        public static void closeViewService()
        {
            ViewService.Close();

            //Mark form as closed
            ViewServiceOpen = false;
        }
        #endregion

        #region Assign Employee To Service
        public static void createAssignEmployeeToService()
        {
            AssignEmployeeToService = new frmAssignEmployeeToService();
        }

        public static void openAssignEmployeeToService()
        {
            //Check if AssignEmloyeeToService has been previously disposed
            if (AssignEmployeeToService.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createAssignEmployeeToService();
            }

            //Show form
            showAssignEmployeeToService();
        }

        public static void showAssignEmployeeToService()
        {
            AssignEmployeeToService.Show();

            //Mark form as open
            AssignEmployeeToServiceOpen = true;
        }

        public static void hideAssignEmployeeToService()
        {
            AssignEmployeeToService.Hide();

            //Mark form as closed
            AssignEmployeeToServiceOpen = false;
        }

        public static void closeAssignEmployeeToService()
        {
            AssignEmployeeToService.Close();

            //Mark form as closed
            AssignEmployeeToServiceOpen = false;
        }
        #endregion

        #region Add Service
        public static void createAddService()
        {
            AddService = new frmAddService();
        }

        public static void openAddService()
        {
            //Check if AddService has been previously disposed
            if (AddService.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createAddService();
            }

            //Show form
            showAddService();
        }

        public static void showAddService()
        {
            AddService.Show();

            //Mark form as open
            AddServiceOpen = true;
        }

        public static void hideAddService()
        {
            AddService.Hide();

            //Mark form as closed
            AddServiceOpen = false;

        }

        public static void closeAddService()
        {
            AddService.Close();
            //Mark form as closed
            AddServiceOpen = false;
        }

        #endregion Add Service

        #region View Training
        public static void createViewTraining()
        {
            ViewTraining = new frmViewTraining();
        }

        public static void openViewTraining()
        {
            //Check if ViewTraining has been previously disposed
            if (ViewTraining.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createViewTraining();
            }

            //Show form
            showViewTraining();
        }

        public static void showViewTraining()
        {
            ViewTraining.Show();

            //Mark form as open
            ViewTrainingOpen = true;
        }

        public static void hideViewTraining()
        {
            ViewTraining.Hide();

            //Mark form as closed
            ViewTrainingOpen = false;
        }

        public static void closeViewTraining()
        {
            ViewTraining.Close();

            //Mark form as closed
            ViewTrainingOpen = false;
        }
        #endregion

        #region Add Training
        public static void createAddTraining()
        {
            AddTraining = new frmAddTraining();
        }

        public static void openAddTraining()
        {
            //Check if AddTraining has been previously disposed
            if (AddTraining.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createAddTraining();
            }

            //Show form
            showAddTraining();
        }

        public static void showAddTraining()
        {
            AddTraining.Show();

            //Mark form as open
            AddTrainingOpen = true;
        }

        public static void hideAddTraining()
        {
            AddTraining.Hide();

            //Mark form as closed
            AddTrainingOpen = false;
        }

        public static void closeAddTraining()
        {
            AddTraining.Close();

            //Mark form as closed
            AddTrainingOpen = false;
        }
        #endregion

        #region Add Training Attendance
        public static void createAddTrainingAttendance()
        {
            AddTrainingAttendance = new frmAddTrainingAttendance();
        }

        public static void openAddTrainingAttendance()
        {
            //Check if AddTrainingAttendance has been previously disposed
            if (AddTrainingAttendance.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createAddTrainingAttendance();
            }

            //Show form
            showAddTrainingAttendance();
        }

        public static void showAddTrainingAttendance()
        {
            AddTrainingAttendance.Show();

            //Mark form as open
            AddTrainingAttendanceOpen = true;
        }

        public static void hideAddTrainingAttendance()
        {
            AddTrainingAttendance.Hide();

            //Mark form as closed
            AddTrainingAttendanceOpen = false;
        }

        public static void closeAddTrainingAttendance()
        {
            AddTrainingAttendance.Close();

            //Mark form as closed
            AddTrainingAttendanceOpen = false;
        }

        #endregion

        #region View Filter
        public static void createViewFilter()
        {
            ViewFilter = new frmViewFilter();
        }

        public static void openViewFilter()
        {
            //Check if ViewFilter has been previously disposed
            if (ViewFilter.IsDisposed)
            {
                //Has been disposed
                //Create a new form
                createViewFilter();
            }

            //Show form
            showViewFilter();
        }

        public static void showViewFilter()
        {
            ViewFilter.Show();
        }

        public static void hideViewFilter()
        {
            ViewFilter.Hide();
        }

        public static void closeViewFilter()
        {
            ViewFilter.Close();
        }

        #endregion
    }
}
