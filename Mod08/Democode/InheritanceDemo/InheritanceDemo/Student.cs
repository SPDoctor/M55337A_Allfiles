namespace InheritanceDemo
{
    class Student : Person
    {
        public override void move()
        {
            Console.WriteLine("Student.move() called");
        }
    }
}
