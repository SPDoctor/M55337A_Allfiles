namespace File_IO
{
    class Student : Person
    {
        public Student(string first, string last, string gender, int age)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Gender = gender;
            this.Age = age;
        }

        public override void move()
        {

        }
    }
}
