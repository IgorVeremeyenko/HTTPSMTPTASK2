using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace HTTPSMTPTASK2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Send_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress(textBoxMessage.Text);
            MailAddress to = new MailAddress(textBoxRecipient.Text);
            MailMessage m = new MailMessage(from, to);
            m.Subject = textBoxTheme.Text;
            m.Body = textBoxMessage.Text;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("viruscomp7@gmail.com", "mypassword");
            try
            {
                smtpClient.Send(mailMessage);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
