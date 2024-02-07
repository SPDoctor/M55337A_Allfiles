namespace File_IO
{
    class Student : Person
    {
        public Student(string first, string last, string gender, int age)
        {
            this.firstName = first;
            this.lastName = last;
            this.gender = gender;
            this.age = age;
        }

        public override void eat()
        {
            Console.WriteLine("chugging");
        }
    }
}
