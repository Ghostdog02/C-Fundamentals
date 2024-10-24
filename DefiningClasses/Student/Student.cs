
namespace Student
{
    public class Student
    {
        public static int countObjects = 0;
        private string? firstName = null;
        private string? middleName = null;
        private string? lastName = null;
        private int course = 0;
        private Specialty specialty = 0;
        private Universety universety = 0;
        private string? email = null;
        private string? number = null;

        public string? FirstName { get => firstName; }

        public string? MiddleName { get => middleName; }

        public string? LastName { get => lastName; }

        public int Course { get => course; }

        public Specialty _Specialty { get => specialty; }

        public Universety _Universety { get => universety; }

        public string? Email { get => email; }

        public string? Number { get => number; }


        public Student(string? firstName)
            : this(firstName, null)
        {
            countObjects++;
        }

        public Student(string? firstName, string? middleName)
            : this(firstName, middleName, null)
        {
            countObjects++;
        }

        public Student(string? firstName, string? middleName, string? lastName)
            : this(firstName, middleName, lastName, 0)
        {
            countObjects++;
        }

        public Student(string? firstName, string? middleName, string? lastName, int course)
            : this(firstName, middleName, lastName, course, 0)
        {
            countObjects++;
        }

        public Student(string? firstName, string? middleName, string? lastName, int course, Specialty specialty)
            : this(firstName, middleName, lastName, course, specialty, 0)
        {
            countObjects++;
        }

        public Student(string? firstName, string? middleName, string? lastName, int course, Specialty specialty, Universety universety)
            : this(firstName, middleName, lastName, course, specialty, universety, null)
        {
            countObjects++;
        }

        public Student(string? firstName, string? middleName, string? lastName, int course, Specialty specialty, Universety universety, string? email)
            : this(firstName, middleName, lastName, course, specialty, universety, email, null)
        {
            countObjects++;
        }

        public Student(string? firstName, string? middleName, string? lastName, int course, Specialty specialty,
            Universety universety, string? email, string? number)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.course = course;
            this.specialty = specialty;
            this.universety = universety;
            this.email = email;
            this.number = number;
        }

        public enum Specialty
        {
            Architecture,
            BussinessAndManagement,
            PerformingArts,
            Economy,
            EngineeringSciences,
            ComputerSciences,
            MedicineAndHealthSciences,
            MediaAndMassCommunication,
            InternationalRelationsAndPolitics,
            NaturalSciences,
            LawScience,
            Psychology,
            Tourism,
            Hospitality,
            Culinary,
            PhilologyAndLinguistics,
            Finance,
            Accounting,
            Banking,
            Humanities
        }

        public enum Universety
        {
            Sofia,
            Technical,
            Medical,
            ChemicalTechnologyAndMetallurgy,
            ArchitectureCivilEngineeringAndGeodesy,
            NationalAndWorldEconomy,
            NewBulgarian,
            Forestry,
            MiningAndGeology,
            LibraryStudiesAndInformationTechnologies,
            Transport,
            StructuralEngineeringAndArchitecture,
        }

        public void PrintId()
        {
            Console.WriteLine($"Name: {FirstName} {MiddleName} {LastName}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Specialty: {_Specialty}");
            Console.WriteLine($"Universety: {_Universety}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Number: {Number}");
        }
    }
}