using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StepAuthentificationChainOfResp
{
    public class Receiver
    {
        public Receiver(bool firstAuth, bool snAuth)
        {
            this.firstAuth = firstAuth;
            this.snAuth = snAuth;
        }

        public bool firstAuth { get; set; }
        public bool snAuth { get; set; }
    }
}
