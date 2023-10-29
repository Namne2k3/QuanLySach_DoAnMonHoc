using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;

namespace BaoCao_QLSach
{
    public partial class formForgotPass : Form
    {
        private TaiKhoanService taiKhoanService;
        public static formForgotPass instance; 
        public string emailTarget = string.Empty;

        public string _from = "nhpn2003@gmail.com";
        public string _pass = "dwdm nwfs lcnl eukk";
        public SmtpClient client = new SmtpClient();
        public MailMessage msg = new MailMessage();
        public System.Net.NetworkCredential smtpCreds = new System.Net.NetworkCredential("mail", "password");

        string code = "";
        public formForgotPass(TaiKhoanService taiKhoanService)
        {
            InitializeComponent();
            this.taiKhoanService = taiKhoanService;
            instance = this;
        }
        public string sendEmail(string sendto, string subject, string content)
        {
            try
            {
                MailMessage mail = new MailMessage();
                // tao message 
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                // tao client smtl server

                mail.From = new MailAddress(_from);
                mail.To.Add(sendto);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = content;

                mail.Priority = MailPriority.High;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(_from, _pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return "OK";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        public bool isValidEmail(string inputEmail)
        {
            string strRegex = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";
            Regex re = new Regex(strRegex);
            if (inputEmail.ToLower().Contains("@gmail.com") && re.IsMatch(inputEmail))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btRequest_Click(object sender, EventArgs e)
        {
            try
            {
                if ( !isValidEmail(tbEmail.Text) )
                {
                    throw new Exception("Email khong hop le");
                }

                var findTk = taiKhoanService.FindTkByEmail(tbEmail.Text);
                if ( findTk != null )
                {
                    Random rnd = new Random();
                    int randomInt = rnd.Next(1, 999999);
                    code = randomInt.ToString();

                    if (sendEmail(tbEmail.Text, "Thay doi mat khau", "Code: " + code ) == "OK" )
                    {
                        tbCode.Enabled = true;
                        btSubmit.Enabled = true;
                    } else
                    {
                        throw new Exception(sendEmail(tbEmail.Text, "Thay doi mat khau", code));
                    }
                } else
                {
                    throw new Exception("Email chua duoc dang ky!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if ( tbCode.Text != code )
                {
                    throw new Exception("Sai code, vui long nhap lai!");
                } else
                {
                    var findTk = taiKhoanService.FindTkByEmail(tbEmail.Text);
                    formChangePass form = new formChangePass(taiKhoanService, findTk);
                    this.Hide();
                    MessageBox.Show("Xác thực thành công!");
                    form.ShowDialog();
                    this.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void formForgotPass_Load(object sender, EventArgs e)
        {
            tbCode.Enabled = false;
            btSubmit.Enabled = false;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
