using System;
using System.Windows.Forms;

namespace SampleCompanyHRSystem
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            timerSplash.Start();
        }

        void timerSplash_Tick(object sender, EventArgs e)
        {
            if (pgbSplash.Value < pgbSplash.Maximum)
            {
                pgbSplash.Value++;
            }
            else
            {
                FormHandler.showMainForm();
                timerSplash.Stop();
            }
        }
    }
}
