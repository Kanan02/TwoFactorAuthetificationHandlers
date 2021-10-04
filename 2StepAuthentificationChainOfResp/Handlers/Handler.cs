using _2StepAuthentificationChainOfResp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StepAuthentificationChainOfResp.Handlers
{
    public abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void Handle(Receiver receiver,User user);
    }
}
