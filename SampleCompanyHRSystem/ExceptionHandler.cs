using System;
using System.Windows.Forms;

namespace SampleCompanyHRSystem
{
    static class ExceptionHandler
    {
        static public void throwException(Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
