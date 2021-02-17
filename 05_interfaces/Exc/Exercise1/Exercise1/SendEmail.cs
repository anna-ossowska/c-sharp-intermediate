using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class SendEmail : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Email has been sent.");
        }
    }
}
