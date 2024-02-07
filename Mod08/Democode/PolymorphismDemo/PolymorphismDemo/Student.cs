namespace PolymorphismDemo
{
    class Student : Person
    {
        private string school;
        private string program;

        public string School
        {
            get { return school; }
            set { school = value; }
        }
        
        public string Program
        {
            get { return program; }
            set { program = value; }
        }

        public void sleep()
        {

        }

        public void study()
        {

        }

        public override void move()
        {
            Console.WriteLine("Moving");
        }
    }
}
