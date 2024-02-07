namespace File_IO
{
    class Instructor : Person
    {
        public override void InputValues()
        {
            InputValues("Enter the instructor's ");
        }

        public override void SaveToFile()
        {
            string fileName = "../../../Instructors.txt";
            string header = "Instructors";
            Program.WriteContents(header, fileName, this);
        }

        public override void eat()
        {
            Console.WriteLine("scoffing");
        }
    }
}
