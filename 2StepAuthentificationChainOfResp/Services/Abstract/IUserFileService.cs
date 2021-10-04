using _2StepAuthentificationChainOfResp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StepAuthentificationChainOfResp.Services.Abstract
{
    public interface IUserFileService
    {
        IEnumerable<User> Open(string fileName);
        void Save(string fileName, IEnumerable<User> users);
    }
}
