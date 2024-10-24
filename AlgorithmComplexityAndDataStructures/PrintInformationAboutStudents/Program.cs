namespace PrintInformationAboutStudents
{
    public class Student : IComparable<Student>
    {
        public string FirstName { get; }

        public string LastName { get; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public int CompareTo(Student? other)
        {
            var result = this.LastName.CompareTo(other.LastName);
            if (result == 0)
            {
                result = this.FirstName.CompareTo(other.FirstName);
            }

            return result;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    public class Program
    {
        static SortedDictionary<string, List<Student>> ReadStudents(string path)
        {
            var studentsInformation = new SortedDictionary<string, List<Student>>();
            using var reader = new StreamReader(path);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var information = line.Split('|');
                var fullName = information[0].Trim().Split(" ");
                var student = new Student(fullName[0], fullName[1]);
                var specialty = information[1].Trim();
                List<Student> students;
                if (!studentsInformation.TryGetValue(specialty, out students))
                {
                    students = new List<Student>();
                    students.Add(student);
                    studentsInformation.Add(specialty, students);
                }

                else
                {
                    studentsInformation[specialty].Add(student);
                }

                
            }

            return studentsInformation;
        }

        static void PrintStudents(SortedDictionary<string, List<Student>> studentsInformation)
        {
            foreach (var specialty in studentsInformation.Keys)
            {
                var students = studentsInformation[specialty];
                students.Sort();
                Console.Write($"{specialty}: ");
                for (int i = 0; i < students.Count; i++)
                {
                    if (i == students.Count - 1)
                    {
                        Console.WriteLine($"{students[i]}");
                    }

                    else
                    {
                        Console.Write($"{students[i]}, ");
                    }
                }
            }
        }

        static void Main()
        {
            var path = @"D:\Documents\PrintInformationAboutStudentsAlphabeticaly\students.txt";
            var studentsInformation = ReadStudents(path);
            PrintStudents(studentsInformation);
        }
    }
}