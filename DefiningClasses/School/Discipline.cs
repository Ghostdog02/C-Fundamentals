using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Discipline
    {
        private string name = null;
        private int numberOfExercises = 0;
        private int numberOfLessons = 0;

        public string Name { get => name; set => name = value; }

        public int NumberOfExercises { get => numberOfExercises; set => numberOfExercises = value; }

        public int NumberOfLessons { get => numberOfLessons; set => numberOfLessons = value; }

        public Discipline(string name, int numberOfExercises, int numberOfLessons)
        {
            this.Name = name;
            this.NumberOfExercises = numberOfExercises;
            this.NumberOfLessons = numberOfLessons;
        }

       
    }
}
