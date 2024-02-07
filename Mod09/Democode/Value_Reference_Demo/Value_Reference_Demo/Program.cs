namespace Value_Reference_Demo
{
    class Program
    {
        struct TestStruct
        {
            public void print() /* can't be virtual because method on a struct */
            {
                Point newPoint = new Point();
                Object[] objArray = new Object[]{"one", 2, newPoint};

                try
                {
                    string newSTring = (string)objArray[0];
                    int newInt = (int)objArray[1];
                    //int newInt2 = (int)objArray[2]; // throws Invalid Cast exception
                    Point aPoint = (Point)objArray[2];
                }
                catch (InvalidCastException castEx)
                {
                    Console.WriteLine("Cast failed, {0}", castEx.Message);
                }
            }
        }

        struct Point
        {
            int x;
            int y;
        }

        static void Main(string[] args)
        {
            TestStruct t;
            t.print();
        }
    }
}
