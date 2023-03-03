using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Security.Permissions;
using System.IO;

namespace GROUP16

{

    public partial class SendingEmail : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        int empNum;
        string filePath;
        bool auto = false;
        bool fromHome;



        public SendingEmail(int num, bool fromHome)
        {
            InitializeComponent();
            this.empNum = num;
            this.filePath = null;
            this.auto = false;
            this.fromHome = fromHome;
        }

        public SendingEmail(int num, string sendTo, string subject, string body, bool fromHome, bool auto)
        {
            InitializeComponent();
            this.empNum = num;
            this.forAddress.Text = sendTo;
            this.textSubject.Text = subject;
            this.Main.Text = body;
            this.auto = auto;
            this.fromHome = fromHome;
        }

        public SendingEmail(int num, string sendTo, string subject, string body, string fileRecieved, bool fromHome)
        {
            InitializeComponent();
            this.empNum = num;
            this.forAddress.Text = sendTo;
            this.textSubject.Text = subject;
            this.Main.Text = body;
            this.filePath = fileRecieved;
            this.auto = true;
            this.fromHome = fromHome;
        }

        private int checkParameters()
        {
            if (forAddress.Text.Length == 0 || textSubject.Text.Length == 0 || Main.Text.Length == 0)
            {
                String message = ("עליך למלא את כל השדות");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }

            if (!forAddress.Text.Contains("@") || !forAddress.Text.Contains("."))
            {
                String message = ("האימייל שהכנסת אינו תקין, אנא בדוק שהכתובת מכילה @, נקודה ואותיות באנגלית בלבד ");
                String title = ("שגיאה");
                MessageBox.Show(message, title);
                return (0);
            }

            return (1);
           
        }

        private void SendMail_Click(object sender, EventArgs e)
        {
            if (checkParameters() == 1)
            {
                login = new NetworkCredential("madbekaBerega", "ztggxprzfexzqybl");
                client = new SmtpClient("smtp.gmail.com");
                client.Port = Convert.ToInt32("587");
                client.EnableSsl = true;
                client.Credentials = login;
                msg = new MailMessage { From = new MailAddress("madbekaberega@gmail.com", "madbekaberega", Encoding.UTF8) };
                msg.To.Add(new MailAddress(this.forAddress.Text));
                msg.Subject = this.textSubject.Text;
                msg.Body = this.Main.Text;
                if (this.filePath != null)
                {

                    msg.Attachments.Add(new Attachment(filePath));
                }
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                string userstate = "..שולח";
                client.SendAsync(msg, userstate);


            }

        }
        private static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show(string.Format("{0} התבטלה ההודעה.", e.UserState), "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("המייל נשלח בהצלחה", "הודעה", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            welcomeScreen a = new welcomeScreen();
            a.Show();
            this.Hide();
        }

        private void backFromMail_Click(object sender, EventArgs e)
        {
            if (this.fromHome)
            {
                homePage a = new homePage(empNum);
                a.Show();
                this.Hide();
            }
            else
            {
                ExistingInventory ex = new ExistingInventory(this.empNum);
                ex.Show();
                this.Hide();
            }
        
        }

        private void AddFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog upload = new OpenFileDialog())
            {
                upload.Filter = null;

               upload.FilterIndex = 2;
                upload.RestoreDirectory = true;

                upload.Title = "Select File";
                if (upload.ShowDialog() == DialogResult.OK)
                {
                    filePath = upload.FileName;
                    this.filePath = filePath;
                    MessageBox.Show(fileContent, "קובץ נוסף בהצלחה " + filePath, MessageBoxButtons.OK);
                }

            }
            
        }

        private void forAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendingEmail_Load(object sender, EventArgs e)
        {
            if (this.auto)
            {
                if (this.filePath != null)
                {
                    bool fileExist = File.Exists(filePath);
                    if (fileExist)
                    {
                        this.SendMail.PerformClick();

                    }
                    else
                    {
                        MessageBox.Show("הקובץ אותו אתה מנסה לשלוח לא קיים");
                    }
                    
                }
                else
                {
                    this.SendMail.PerformClick();
                }
            }
        }
    }




}