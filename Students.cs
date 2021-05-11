using EventDelegatePractice1.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegatePractice1
{
    public delegate int SchoolHierarchyHandler(int years, SchoolType schoolType);
    public class Students 
    {
        public event SchoolHierarchyHandler StudentPassed;
        public event EventHandler ClassPassed;

        public void DoScoolLevel(int years, SchoolType schoolType)
        {
            for (int i = 0; i < years; i++)
            {
                System.Threading.Thread.Sleep(1000);
                OnStudentPassed(i + 1, schoolType);
            }
            OnClassPassed();
        }

        protected virtual void OnStudentPassed(int years, SchoolType schoolType)
        {
            var del = StudentPassed as SchoolHierarchyHandler;
            if (del != null)
            {
                del(years, schoolType);
            }
        }

        protected virtual void OnClassPassed()
        {
            var del = ClassPassed as EventHandler;
            if (del != null)
            {
                del(this, EventArgs.Empty);
            }
        }
    }
}
