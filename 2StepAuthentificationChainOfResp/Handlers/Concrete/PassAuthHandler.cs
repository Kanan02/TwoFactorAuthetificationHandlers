using _2StepAuthentificationChainOfResp.Models;
using _2StepAuthentificationChainOfResp.Services.Abstract;
using _2StepAuthentificationChainOfResp.Services.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _2StepAuthentificationChainOfResp.Handlers.Concrete
{
    class PassAuthHandler : Handler
    {
        public override void Handle(Receiver receiver,User user)
        {
            if (receiver.firstAuth)
            {
                IUserFileService fileService = new UserFileService();
                List<User> users=(List<User>)fileService.Open("users.json");
                bool found = false;
                foreach (var item in users)
                {
                    if (item.Username==user.Username&&item.Password==user.Password&&Successor!=null)
                    {
                        user.Email = item.Email;
                        Successor.Handle(receiver, user);
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    MessageBox.Show("Wrong credentials!!","Error",MessageBoxButton.OK,MessageBoxImage.Error);
                }
            }
        }
    }
}
