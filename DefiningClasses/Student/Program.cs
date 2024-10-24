
namespace Student
{
    public class StudentTest
    {
        private static Student? student = null;
        private static Student? student1 = null;

        static Student? Student { get => student; }

        static Student? Student1 { get => student1; }

        static void Main()
        {
            Student student = new("Aleandro", "Veliki");
            StudentTest.student = student;
            Student.PrintId();
            Console.WriteLine();
            Student student1 = new("Alehandro", "The Great", "Bulgarian King", 8, Student.Specialty.ComputerSciences,
                Student.Universety.Technical);
            StudentTest.student1 = student1;
            Student1.PrintId();

        }


    }
}
