using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class SchoolClass
    {
        private Teacher teacher = null;
        private string identificator = null;

        public Teacher Teacher { get => teacher; set => teacher = value; }

        public string Identificator { get => identificator; set => identificator = value; }

        public SchoolClass(Teacher teacher, string identificator)
        {
            this.Teacher = teacher;
            this.Identificator = identificator;
        }

        
    }
}
