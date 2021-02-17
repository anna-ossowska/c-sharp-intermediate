using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class CallWebService : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Web Service has been called.");
        }
    }
}
