using _2StepAuthentificationChainOfResp.ViewBindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _2StepAuthentificationChainOfResp.View
{
    /// <summary>
    /// Interaction logic for VerificationWindow.xaml
    /// </summary>
    public partial class VerificationWindow : Window
    {
        private int code;
        private string mail;
        public VerificationWindow(string mail,int code )
        {
            InitializeComponent();

            this.code = code;
            this.mail = mail;
            label1.Content = $"We sent a verification code on mail:\n {mail}\n Write down the verificaiton code.";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(int.Parse(textbox1.Text) == code)
            {
                DialogResult = true;
                Close();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CodeGenerator codeGenerator = new CodeGenerator();
            code = codeGenerator.CreateCode();
            MailSender mailSender = new MailSender();
            mailSender.SendMail(code, mail);
            MessageBox.Show("Code Was Resend!");

        }
    }
}
