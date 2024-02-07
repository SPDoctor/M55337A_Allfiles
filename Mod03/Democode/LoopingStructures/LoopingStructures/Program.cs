namespace LoopingStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            #region simple for loop
            /***************************************************************************/
            //double total = 0;

            //for (int loopCounter = 0; loopCounter < 10; loopCounter++)
            //{
            //    Console.WriteLine("loopCounter is at: " + loopCounter);
            //    total = total + loopCounter;
            //}

            //Console.WriteLine("Total of values is: " + total);
            //Console.WriteLine("Average is: " + total / 10); 
            #endregion

            #region Nested for loop
            /***************************************************************************/
            //string[] students = new string[] {"Tom", "Jerry", "Fred", "George"};
            //double[] grades = new double[] {91, 89, 95, 82 };
            //int totalAGrades = 0;
            //int totalBGrades = 0;

            //for(int studentCounter = 0; studentCounter < students.Length; studentCounter++)
            //{
            //   for(int gradeCounter = 0; gradeCounter < grades.Length; gradeCounter++)
            //   {
            //      if(grades[gradeCounter] >= 90)
            //      {
            //         totalAGrades++;
            //      }
            //      else if(grades[gradeCounter] >= 80 && grades[gradeCounter] < 90)
            //      {
            //         totalBGrades++;
            //      }
            //   }
            //}
            #endregion

            #region foreach loop
            /***************************************************************************/
            //string[] students = new string[] { "Tom", "Jerry", "Fred", "George" };
            //double[] grades = new double[] { 91, 89, 95, 82 };
            //int totalAGrades = 0;
            //int totalBGrades = 0;

            //foreach (string student in students)
            //{
            //    foreach (double grade in grades)
            //    {
            //        if (grade >= 90)
            //        {
            //            totalAGrades++;
            //        }
            //        else if (grade >= 80 && grade < 90)
            //        {
            //            totalBGrades++;
            //        }
            //    }
            //}
            #endregion

            #region while loop
            /***************************************************************************/
            //int loopCounter = 0;

            //while (loopCounter < 4)
            //{
            //    Console.WriteLine(loopCounter);
            //    loopCounter++;
            //}
            #endregion

            #region do-while loop
            /***************************************************************************/
            //int loopCounter = 0;

            //do
            //{
            //    Console.WriteLine(loopCounter);
            //    loopCounter++;
            //} while (loopCounter < 4);
            #endregion

            #region recursion call
            /***************************************************************************/
            //long value = Factorial(10);
            //Console.WriteLine(value);
            #endregion

        }

        #region recursive function
        //static long Factorial(int n)
        //{
        //    if (n == 0)
        //    {
        //        return 1;
        //    }

        //    return n * Factorial(n - 1);
        //}
        #endregion
    }
}
