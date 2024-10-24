using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher
    {
        private Discipline discipline = null;

        public Discipline Discipline { get => discipline; set => discipline = value; }

        public Teacher(Discipline discipline)
        {
            this.Discipline = discipline;
        }
    }
}
