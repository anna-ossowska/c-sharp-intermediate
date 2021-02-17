using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    class WorkflowEngine
    {
        public readonly IList<IActivities> _activities;

        public WorkflowEngine()
        {
            this._activities = new List<IActivities>();
        }

        public void RegisterActivity(IActivities activity)
        {
            _activities.Add(activity);
        }

        public void Run()
        {
            foreach (var activity in _activities)
            {
                activity.Execute();
            }
        }
    }
}
