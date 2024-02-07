namespace File_IO
{
    class Student : Person
    {
        public override void InputValues()
        {
            InputValues("Enter the student's ");
        }

        public override void SaveToFile()
        {
            string fileName = "../../../Students.txt";
            string header = "Students";
            Program.WriteContents(header, fileName, this);
        }

        public override void eat()
        {
            Console.WriteLine("chugging");
        }
    }
}
