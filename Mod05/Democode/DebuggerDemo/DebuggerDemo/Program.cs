namespace DebuggerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 4, 5, 9, 1, 8, 3 };
            BubbleSort(myArray);
            Console.WriteLine("Sorted array...");

            foreach (int number in myArray)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Fibonacci numbers...");
            Console.WriteLine(Fibonacci(20));
        }

        static int[] BubbleSort(int[] array)
        {
            for (int i = 1; i <= (array.Length - 1); i++)
            {
                for (int j = 0; j < (array.Length - 1); j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        static string Fibonacci(int numberOfValues)
        {
            int a = 0;
            int b = 1;
            var list = "";

            for(int counter =  0; counter < numberOfValues; counter++)
            {
                int temp = a;
                a = b;
                b = temp + a;
                list += a + " ";
            }

            return list;
        }
    }
}
