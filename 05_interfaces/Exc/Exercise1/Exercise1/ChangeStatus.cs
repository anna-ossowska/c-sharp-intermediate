using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class ChangeStatus : IActivities
    {
        public void Execute()
        {
            Console.WriteLine("Status has been changed.");
        }
    }
}
