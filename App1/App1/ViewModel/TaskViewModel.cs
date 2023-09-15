using App1.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.ViewModel
{
    class TaskViewModel
    {
        public Class1 TaskModelSet { get; set; }

        public TaskViewModel()
        {
            TaskModelSet = new Class1()
            {
                Subjectcode = "PDC06",
                SubjectTitle = "Xamarin Mobile Programming",
                Unit = 3,

            };
        }
    }
}
