﻿using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LlblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHandler.openForgotPassword();
        }
    }
}
