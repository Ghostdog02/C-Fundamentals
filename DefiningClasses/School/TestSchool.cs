using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class TestSchool
    {
        static void Main()
        {
            var school = new School(new SchoolClass(new Teacher(new Discipline("Math", 68, 68)), "fsfsdfs"), new Student("Alehandro", 2));
            Console.WriteLine($"{school.Student.Name} {school.SchoolClass.Teacher.Discipline.Name} {school.SchoolClass.Identificator}");
        }
    }
}
