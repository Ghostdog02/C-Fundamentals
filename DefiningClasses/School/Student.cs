using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        private string name = null;
        private int number = 0;

        public string Name { get => name; set => name = value; }

        public int Number { get => number; set => number = value; }

        public Student(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }

        
    }
}
