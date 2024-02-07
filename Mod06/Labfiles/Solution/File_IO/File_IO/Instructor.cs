namespace File_IO
{
    class Instructor : Person
    {
        public Instructor(string first, string last, string gender, int age)
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
