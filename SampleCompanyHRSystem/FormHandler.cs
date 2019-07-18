using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCompanyHRSystem
{
    static class FormHandler
    {
        static frmLogin LoginForm = new frmLogin();
        static frmMain MainForm = new frmMain();
        static frmAddEmployee AddEmployee = new frmAddEmployee();
        static frmViewEmployee ViewEmployee = new frmViewEmployee();
        static frmAddSickness AddSickness = new frmAddSickness();
        static frmEmployeeLeaver EmployeeLeaver = new frmEmployeeLeaver();
        static frmViewAnnualLeave ViewAnnualLeave = new frmViewAnnualLeave();
        static frmAddAnnualLeave AddAnnualLeave = new frmAddAnnualLeave();
        static frmViewService ViewService = new frmViewService();
        static frmAssignEmployeeToService AssignEmployeeToService = new frmAssignEmployeeToService();
        static frmAddService AddService = new frmAddService();
        static frmViewTraining ViewTraining = new frmViewTraining();

        public static void showMainForm()
        {
            MainForm.Show();
        }

        public static void hideMainForm()
        {
            MainForm.Hide();
        }

        public static void showLoginForm()
        {
            LoginForm.Show();
        }

        public static void hideLoginForm()
        {
            LoginForm.Hide();
        }

        public static void showAddEmployee()
        {
            AddEmployee.Show();
        }

        public static void hideAddEmployee()
        {
            AddEmployee.Hide();
        }

        public static void showViewEmployee()
        {
            ViewEmployee.Show();
        }

        public static void hideViewEmployee()
        {
            ViewEmployee.Hide();
        }

        public static void showAddSickness()
        {
            AddSickness.Show();
        }

        public static void hideAddSickness()
        {
            AddSickness.Hide();
        }

        public static void showEmployeeLeaver()
        {
            EmployeeLeaver.Show();
        }

        public static void hideEmployeeLeaver()
        {
            EmployeeLeaver.Hide();
        }

        public static void showViewAnnualLeave()
        {
            ViewAnnualLeave.Show();
        }

        public static void hideViewAnnualLeave()
        {
            ViewAnnualLeave.Hide();
        }

        public static void showAddAnnualLeave()
        {
            AddAnnualLeave.Show();
        }

        public static void hideAddAnnualLeave()
        {
            AddAnnualLeave.Hide();
        }

        public static void showViewService()
        {
            ViewService.Show();
        }

        public static void hideViewService()
        {
            ViewService.Hide();
        }

        public static void showAssignEmployeeToService()
        {
            AssignEmployeeToService.Show();
        }

        public static void hideAssignEmployeeToService()
        {
            AssignEmployeeToService.Hide();
        }

        public static void showAddService()
        {
            AddService.Show();
        }

        public static void hideAddService()
        {
            AddService.Hide();
        }

        public static void showViewTraining()
        {
            ViewTraining.Show();
        }

        public static void hideViewTraining()
        {
            ViewTraining.Hide();
        }
    }
}
