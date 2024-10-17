using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class EmailService_Correct : IMessageService
    {
        public void SendMessage(string message)
        {
            // email send code
        }
    }
}
