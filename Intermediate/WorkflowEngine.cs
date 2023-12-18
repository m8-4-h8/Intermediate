using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    // Define an interface for activities
    public interface IActivity
    {
        void Execute();
    }

    // Implement activities by creating classes that implement the IActivity interface
    public class Activity1 : IActivity
    {
        public void Execute()
        {
            // Logic for Activity 1
            Console.WriteLine("Executing Activity 1");
        }
    }

    public class Activity2 : IActivity
    {
        public void Execute()
        {
            // Logic for Activity 2
            Console.WriteLine("Executing Activity 2");
        }
    }

    // Workflow class to hold a sequence of activities
    public class Workflow
    {
        private List<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity)
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

    // Workflow engine class to execute the workflows
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            workflow.Run();
        }
    }

}
