using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2StepAuthentificationChainOfResp.ViewBindings
{
    public class CodeGenerator
    {
        public int CreateCode()
        {
            Random random = new Random();
            return random.Next(1000,5000);
        }
    }
}
