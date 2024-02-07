namespace ProgramFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            SetInstructorName("John Smith");
            SetCourseTitle("CS 101");
            AddClass("CS 101", false, false, false);
            DisplayReminders("Wednesday");
            CalculateAverage();
            CalculateAverageWithWhile();
        }

        static void SetInstructorName(string newName)
        {
            string instructorName = newName;
            Console.WriteLine("Instructor name is " + instructorName);
        }
        static void SetCourseTitle(string newTitle)
        {
            bool result = ValidateCourseTitleLength(newTitle);
            if (result)
            {
                string courseTitle = newTitle;
                Console.WriteLine("Course title is " + courseTitle);
            }
            else
            {
                Console.WriteLine("Class name exceeds 50 characters, please shorten.");
            }
        }

        static bool ValidateCourseTitleLength(string title)
        {
            if (title.Length <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void AddClass(string title, bool isInProgram, bool isRequired, bool isElective)
        {
            if (isInProgram)
            {
                if (isRequired)
                {
                    Console.WriteLine(title + " is in the program and is a required course.");
                }
                else if (isElective)
                {
                    Console.WriteLine(title + " is in the program and is an elective course.");
                }
                else
                {
                    Console.WriteLine(title + " is in the program and is an extra credit course.");
                }
            }
            else
            {
                Console.WriteLine(title + " is not in the Program.");
            }
        }

        static void DisplayReminders(string day)
        {
            switch (day)
            {
                case "Wednesday":
                    Console.WriteLine("Discussion post is due today!");
                    break;
                case "Friday":
                    Console.WriteLine("Quiz is due today!");
                    break;
                case "Sunday":
                    Console.WriteLine("Assignment is due today!");
                    break;
                default:
                    Console.WriteLine("Study new material, nothing due today.");
                    break;
            }
        }

        static void CalculateAverage()
        {
            double[] grades = new double[] { 89, 98, 99, 90, 95 };
            double average = 0.0;
            double total = 0.0;
            int gradeCounter;

            for (gradeCounter = 0; gradeCounter < grades.Length; gradeCounter++)
            {
                total = total + grades[gradeCounter];
            }

            average = total / gradeCounter;
            Console.WriteLine("Grade average is " + average);
        }

        static void CalculateAverageWithWhile()
        {
            double grade = 0.0;
            double total = 0.0;
            int numberOfGrades = -1;

            Console.WriteLine("Enter a grade number, or 200 to end:");
            while (grade < 200)
            {
                numberOfGrades++;
                total = total + grade;
                while (!Double.TryParse(Console.ReadLine(), out grade))
                {
                    Console.WriteLine("That's not a valid grade!");
                }
            }

            var average = total / numberOfGrades;
            Console.WriteLine("Grade average is: " + average);
        }
    }
}
