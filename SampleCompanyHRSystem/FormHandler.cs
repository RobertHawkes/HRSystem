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
    }
}
