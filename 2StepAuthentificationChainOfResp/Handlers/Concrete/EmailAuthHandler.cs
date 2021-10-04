using _2StepAuthentificationChainOfResp.Models;
using _2StepAuthentificationChainOfResp.ViewBindings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _2StepAuthentificationChainOfResp.Handlers.Concrete
{
    public class EmailAuthHandler : Handler
    {
        public override void Handle(Receiver receiver, User user)
        {
            if (receiver.snAuth)
            {
                VerificationGetter verificationGetter = new VerificationGetter();
                if (verificationGetter.VerificationPassed(user.Email))
                {
                    MessageBox.Show("Success");
                }
            }
        }
       
    }
}
