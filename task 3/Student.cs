using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    public class Student: Person
    {
        public int IdNumber { get; set; }

        public Student(string LastName, string FirstName, int Idnumber): base(LastName, FirstName)
        {
            this.IdNumber = Idnumber;
        }
        public override string ToString()
        {
            return $"{base.ToString()} [{IdNumber}]";
        }
    }
}

