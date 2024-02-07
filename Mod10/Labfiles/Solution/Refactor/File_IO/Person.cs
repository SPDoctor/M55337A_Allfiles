namespace File_IO
{
    abstract class Person
    {
        public string? firstName;
        public string? lastName;
        public string? gender;
        public int age;

        // public methods

        public virtual void InputValues()
        {
            InputValues("Enter the ");
        }

        public void InputValues(string prompt)
        {
            Console.ReadLine();

            Console.WriteLine(prompt + "first name.");
            firstName = Console.ReadLine();

            Console.WriteLine(prompt + "last name.");
            lastName = Console.ReadLine();

            Console.WriteLine(prompt + "gender.");
            gender = Console.ReadLine();

            Console.WriteLine(prompt + "age.");
            age = Convert.ToInt32(Console.ReadLine());
        }

        abstract public void SaveToFile();

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
