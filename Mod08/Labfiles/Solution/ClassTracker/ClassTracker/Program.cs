namespace ClassTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCourse credCourse = new CreditCourse();

            credCourse.CourseTitle = "CS101";
            credCourse.CreditHours = 6;
            credCourse.Program = "Computer Science";
            credCourse.EnrollStudent("Tom Thumb");

            float GPA = credCourse.CalculateGPA(98.5F);
            Console.WriteLine("Tom Thumb has a GPA of {0} in course {1}.", GPA, credCourse.CourseTitle);

            NonCreditCourse nonCreditCourse = new NonCreditCourse();
            nonCreditCourse.CourseTitle = "Introduction to Excel";
            char grade = nonCreditCourse.CalculateGrade(87.0F);
            Console.WriteLine("Tom also received a {0} in {1}", grade, nonCreditCourse.CourseTitle);

            CreditCourse newCredCourse = new CreditCourse();
            Console.WriteLine(newCredCourse.CourseTitle);

            CreditCourse newCredCourseTwo = new CreditCourse("CS102", 6, "Computer Science");
            Console.WriteLine(newCredCourseTwo.CourseTitle);
        }
    }
}
