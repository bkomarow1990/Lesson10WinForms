using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewLesson10
{
    class Student
    {
        string name;
        public string Name { 
            get => name;
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ApplicationException("Incorrect name");
                }
                name = value;
            }
        }
    }
}
