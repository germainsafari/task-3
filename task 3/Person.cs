using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set;}

        public Person(string LastName, string FirstName) 
        { 
            this.LastName = LastName;
            this.FirstName = FirstName;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}

