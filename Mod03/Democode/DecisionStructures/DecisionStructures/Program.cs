namespace DecisionStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            /***************************************************************************/
            #region Simple if example

            //int age = 21;

            //if (age >= 21)
            //    Console.WriteLine("Insurance rates should go down.");
            //    //Console.WriteLine("Also opens many doors.");
            //Console.WriteLine("This executes after the if, regardless of the condition result.");

            //if(age >= 21)
            //{
            //    Console.WriteLine("Insurance rates should go down.");
            //    Console.WriteLine("Also opens many doors.");
            //}
            //Console.WriteLine("This executes after the if, regardless of the condition result.");
            #endregion


            #region if-else example
            /***********************************************************************************************/

            //bool isRequired = true;

            //if(isRequired)
            //{
            //    Console.WriteLine("isRequired is true");
            //}
            //else
            //{
            //    Console.WriteLine("isRequired is false");
            //}
            #endregion


            #region if-else-if example
            /***********************************************************************************************/

            //bool isRequired = true;
            //bool isElective = false;

            //if(isRequired)
            //{
            //   Console.WriteLine("isRequired is true");
            //}
            //else if(isElective)
            //{
            //   Console.WriteLine("isElective is true");
            //}
            //else
            //{
            //    Console.WriteLine("Neither value was true");
            //}
            #endregion


            #region Nested if example
            /***********************************************************************************************/

            //bool isInProgram = true;
            //bool isRequired = false;
            //bool isElective = false;

            //if(isInProgram)
            //{
            //   if(isRequired)
            //   {
            //      Console.WriteLine("isInProgram AND isRequired are true");
            //   }
            //   else if(isElective)
            //   {
            //      Console.WriteLine("isInProgram AND isElective are true");
            //   }
            //   else
            //   {
            //      Console.WriteLine("isInProgram is true but isRequired and isElective are false");
            //   }
            //}
            #endregion


            #region switch Example
            /***********************************************************************************************/

            //string dayOfWeek = "Wednesday";

            //switch (dayOfWeek)
            //{
            //    case "Wednesday":
            //        Console.WriteLine("Discussion Post is Due!");
            //        break;
            //    case "Friday":
            //        Console.WriteLine("Quiz is due!");
            //        break;
            //    case "Sunday":
            //        Console.WriteLine("Assignment is due!");
            //        break;
            //}
            #endregion


            #region switch with default case
            /***********************************************************************************************/

            //string dayOfWeek = "Wednesday";

            //switch (dayOfWeek)
            //{
            //    case "Wednesday":
            //        Console.WriteLine("Discussion Post is Due!");
            //        break;
            //    case "Friday":
            //        Console.WriteLine("Quiz is due!");
            //        break;
            //    case "Sunday":
            //        Console.WriteLine("Assignment is due!");
            //        break;
            //    default:
            //        Console.WriteLine("Go over unit study material");
            //        break;
            // }
            #endregion


            #region switch handling multiple cases
            /***********************************************************************************************/

            //string dayOfWeek = "Tuesday";

            //switch (dayOfWeek)
            //{
            //    case "Monday":
            //    case "Tuesday":
            //    case "Wednesday":
            //    case "Thursday":
            //    case "Friday":
            //        Console.WriteLine("This is a weekday");
            //        break;

            //    case "Saturday":
            //    case "Sunday":
            //        Console.WriteLine("The weekend");
            //        break;
            //}
            #endregion
        }
    }
}
