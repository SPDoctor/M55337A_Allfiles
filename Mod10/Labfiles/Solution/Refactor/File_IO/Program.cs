namespace File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Person newPerson;

            Console.WriteLine("Do you want to create a:");
            Console.WriteLine();
            Console.WriteLine("S - Student");
            Console.WriteLine();
            Console.WriteLine("I - Instructor");
            Console.WriteLine();
            Console.WriteLine("Q - Quit");
            Console.WriteLine();

            char response = Convert.ToChar(Console.Read());

            switch (response)
            {
                case 's':
                case 'S':
                    newPerson = new Student();
                    break;

                case 'i':
                case 'I':
                    newPerson = new Instructor();
                    break;

                default:
                    return;
            }
            newPerson.InputValues();
            newPerson.SaveToFile();
        }

        static public void WriteContents(string header, string fileName, Person person)
        {
            if (!File.Exists(fileName))
            {
                StreamWriter writer = new StreamWriter(fileName);
                writer.WriteLine(header);
                writer.Write(person.firstName + ", ");
                writer.Write(person.lastName + ", ");
                writer.Write(person.gender + ", ");
                writer.Write(person.age);
                writer.Close();
            }
            else
            {
                StreamWriter writer = File.AppendText(fileName);
                writer.WriteLine();
                writer.WriteLine("{0}, {1}, {2}, {3}", person.firstName, person.lastName, person.gender, person.age);
                writer.Close();
            }
            ReadFile(fileName);
        }

        static void ReadFile(string fileName)
        {
            Console.WriteLine("The file was saved with the following content:");
            StreamReader reader = new StreamReader(fileName);
            Console.WriteLine();
            Console.WriteLine(reader.ReadToEnd());
        }
    }
}
