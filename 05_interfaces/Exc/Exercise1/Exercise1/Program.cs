using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();

            workflowEngine.RegisterActivity(new UploadVideo());
            workflowEngine.RegisterActivity(new CallWebService());
            workflowEngine.RegisterActivity(new SendEmail());
            workflowEngine.RegisterActivity(new ChangeStatus());
            workflowEngine.Run();

        }
    }
}
