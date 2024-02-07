namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string errorMessage;
            int numerator;
            int denominator;
            int result;

            Console.WriteLine("Enter the numerator");
            numerator = Int32.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Enter the denominator");
            denominator = Int32.Parse(Console.ReadLine());

            try
            {
                result = numerator / denominator;

                Console.WriteLine();
                Console.WriteLine("The result is: " + result);
            }
            catch (OverflowException ex)
            {
                errorMessage = ex.Message;
                Console.WriteLine(ex.Message);
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }
    }
}
