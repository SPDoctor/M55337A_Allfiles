namespace File_IO
{
    abstract class Person
    {
        public string? firstName;
        public string? lastName;
        public string? gender;
        public int age;

        // public methods
        public virtual void eat()
        {
            Console.WriteLine("slurping");
        }

        public void sleep()
        {
            Console.WriteLine("Snoring");
        }
    }
}
