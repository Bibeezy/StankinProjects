using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Net.Mail;
using System.Net;
using MailKit.Net.Pop3;
using MailKit;
using MimeKit;
using OpenPop;

namespace ESbyMail
{
    public partial class Form1 : Form
    {
        public string filepath = string.Empty;
        public string destpath = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult res = dialog.ShowDialog();
            if(res==DialogResult.OK)
            {
                filepath = dialog.FileName;
                FileInfo file = new FileInfo(filepath);
                
                textBox1.Text = file.Name;

            }
        }

        

        

        

        private void button7_Click(object sender, EventArgs e)
        {
            ElectroSigner sign = new ElectroSigner();
            ElectroSigner.GetCheckSum(filepath);
            
            Cryptomachine.EncryptData(filepath);
            FileInfo file = new FileInfo(filepath);
            MailAddress from = new MailAddress("testingtesterbib@gmail.com", "Bbz");
            MailAddress to = new MailAddress("testingtesterbib@gmail.com", "Bibeezy");
            MailMessage Mm = new MailMessage(from, to);
            Mm.Subject = "God please";
            // текст письма
            Mm.Body = "<h2>Письмо-тест работы smtp-клиента</h2>";
            Mm.IsBodyHtml = true;
            Mm.Attachments.Add(new Attachment(filepath+" enc"+ file.Extension));
            Mm.Attachments.Add(new Attachment(filepath+" key.txt"));
            Mm.Attachments.Add(new Attachment(filepath + " sign.txt"));
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("testingtesterbib@gmail.com", "qwerty123456!@#$%^");
            
            smtp.Send(Mm);
            
           


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var client = new OpenPop.Pop3.Pop3Client();
            
            FileInfo finf = new FileInfo(filepath);
            string dpath = Path.Combine(@"C:\Users\bibik\Desktop\Test data\Downoloaded Test Data", finf.Name);
            client.Connect("pop.gmail.com", 995, true);
            client.Authenticate("testingtesterbib@gmail.com", "qwerty123456!@#$%^", OpenPop.Pop3.AuthenticationMethod.UsernameAndPassword);
            
            OpenPop.Mime.Message message = client.GetMessage(client.GetMessageCount());
            var att = message.FindAllAttachments();
            foreach(var file in att)
            {
                file.Save(new FileInfo(Path.Combine(@"C:\Users\bibik\Desktop\Test data\Downoloaded Test Data",file.FileName))) ;

            }
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult res = dialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                 destpath= dialog.FileName;
                FileInfo file = new FileInfo(filepath);

                textBox4.Text = file.Name;

            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            FileInfo finf = new FileInfo(destpath);
            Cryptomachine.DecryptData(destpath);
            if(ElectroSigner.CheckCheckSum(destpath))
            {
                MessageBox.Show("Vse 4etko", "Equal sums", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Vse grustno", "Sums ne equal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



        }

        
    }
}
