using _2StepAuthentificationChainOfResp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StepAuthentificationChainOfResp.ViewBindings
{
    public class VerificationGetter
    {
        
        public bool VerificationPassed(string mail)
        {
            CodeGenerator codeGenerator = new CodeGenerator();
            int code = codeGenerator.CreateCode();
            MailSender mailSender = new MailSender();
            mailSender.SendMail(code, mail);
            VerificationWindow verificationWindow = new VerificationWindow(mail, code);
            verificationWindow.ShowDialog();
            return (bool)verificationWindow.DialogResult;
        }
    }
}
