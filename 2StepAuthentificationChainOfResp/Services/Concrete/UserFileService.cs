using _2StepAuthentificationChainOfResp.Models;
using _2StepAuthentificationChainOfResp.Services.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace _2StepAuthentificationChainOfResp.Services.Concrete
{
    public class UserFileService : IUserFileService
    {
        public IEnumerable<User> Open(string fileName)
        {
            var users = new List<User>();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                users = jsonFormatter.ReadObject(fs) as List<User>;
            }

            return users;
        }

        public void Save(string fileName, IEnumerable<User> users)
        {
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<User>));
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, users);
            }
        }
    }
}
