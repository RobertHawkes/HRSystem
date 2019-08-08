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
    public partial class frmLogout : Form
    {
        public frmLogout()
        {
            InitializeComponent();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            try
            {
                //UserHandler.logout();
                FormHandler.closeLogout();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            try
            {
                FormHandler.closeLogout();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }
    }
}
