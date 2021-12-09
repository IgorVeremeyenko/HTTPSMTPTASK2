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
            try
            {
                MailAddress from = new MailAddress(textBoxSender.Text.Trim());
                MailAddress to = new MailAddress(textBoxRecipient.Text.Trim());
                MailMessage m = new MailMessage(from, to);
                m.Subject = textBoxTheme.Text;
                m.Body = textBoxMessage.Text;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("viruscomp7@gmail.com", "qw79@dsg");
                smtp.EnableSsl = true;
                /*smtp.SendAsync(m,"test message1");*/
                smtp.Send(m);
                smtp.Timeout = 100;
                var temp = "Время отправки: меньше " + (smtp.Timeout / 100) + " сек";
                string message = temp.ToString();
                string caption = "Письмо отправлено";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                this.Close();
            }
            catch (Exception msg)
            {
                string message = msg.Message;
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(message, caption, buttons);
                
            }
        }
    }
}
