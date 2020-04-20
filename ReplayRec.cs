using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using BingoStore.Models;
using BingoStore.APIs;

namespace BingoStore
{
    public partial class ReplayRec : UserControl
    {
        
        private string last_name;
        private string first_name;
        private string email;
        private string review;
        private int review_id;
        public ReplayRec(int review_id, string email, string last_name, string first_name, string review)
        {
            InitializeComponent();
            this.email = email;
            this.review_id = review_id;
            this.review = review;
            this.last_name = last_name;
            this.first_name = first_name;

            description.Text = this.review;
            title.Text = this.first_name + " " +this.last_name;
        }

        private void send_Click(object sender, EventArgs e)
        {
            MailAddress from = new MailAddress("gi.forum99@gmail.com", "Bingo Team");
            MailAddress to = new MailAddress("med.oblla@gmail.com", "Jane Clayton");
            MailMessage message = new MailMessage(from, to);
            // message.Subject = "Using the SmtpClient class.";
            message.Subject = subject.Text;
            message.Body = @emailmessage.Text;
            // Add a carbon copy recipient.
            MailAddress copy = new MailAddress("Notification_List@contoso.com");
            message.CC.Add(copy);
            SmtpClient client = new SmtpClient();
            // Include credentials if the server requires them.
            client.UseDefaultCredentials = false;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.Credentials = new NetworkCredential("gi.forum99@gmail.com", "bestForum321");
            client.EnableSsl = true;

            Console.WriteLine("Sending an email message to {0} by using the SMTP host {1}.",
                 to.Address, client.Host);
            try
            {
                client.Send(message);
                MessageBox.Show("Succesfully Replayed !");
                Review.Reply_review(review_id);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in CreateCopyMessage(): {0}",
                    ex.ToString());
                MessageBox.Show("Something Went Wrong !");
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            ShowReports d1 = new ShowReports();
            MainControlClass.showControl(d1, this);
        }
    }
}
