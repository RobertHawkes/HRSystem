using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SampleCompanyHRSystem
{
    public partial class frmForgotPassword : Form
    {
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.sender.email.com");

                mail.From = new MailAddress("sender@email.com");
                mail.To.Add(txtEmail.Text);
                mail.Subject = "Password Reset";
                mail.Body = "Hello {0},\nA Password Reminder has been sent for your account.\nYour password is {1}";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("sender@email.com","senderPassword");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                MessageBox.Show("An email has been sent if the email is registered");

                FormHandler.closeForgotPassword();
            }
            catch (Exception ex)
            {
                ExceptionHandler.throwException(ex);
            }
        }
    }
}
