using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    public class EmailService_Wrong
    {
        public void SendEmail(string message)
        {
            // email send code
        }
    }
}
