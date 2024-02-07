Fibonacci(0, 1, 10);

void Fibonacci(int firstNumber, int secondNumber, int numberOfValues)
{
    Console.WriteLine(firstNumber);
    for (int counter = 0; counter <= numberOfValues; counter++)
    {
        int temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp + firstNumber;
        Console.WriteLine(firstNumber);
    }
}