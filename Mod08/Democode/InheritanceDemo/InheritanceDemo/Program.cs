namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student newStudent = new Student();
            newStudent.Age = 21;
            newStudent.eat();

            Instructor newInstructor = new Instructor();
            newInstructor.Height = 5.9F;
            newInstructor.move();

        }
    }
}
