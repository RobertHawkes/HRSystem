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
    }
}
