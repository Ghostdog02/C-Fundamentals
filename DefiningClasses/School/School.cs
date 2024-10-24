namespace School
{
    public class School
    {
        private SchoolClass schoolClass = null;
        private Student student = null;
        public SchoolClass SchoolClass { get => schoolClass; set => schoolClass = value; }

        public Student Student { get => student; set => student = value; }

        public School(SchoolClass schoolClass, Student student)
        {
            this.SchoolClass = schoolClass;
            this.Student = student;
        }


    }
}