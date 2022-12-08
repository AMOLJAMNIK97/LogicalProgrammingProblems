


using LogicalProgramming;

while (true)
{
    Console.WriteLine("1.Prime Number\n 2. Fibonacci Series");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.CheckPrime();
            break;
        case 2:
            FibonacciSeries fibonacci = new FibonacciSeries();
            fibonacci.CheckFibonacciSeries();
            break;
        default:
            Console.WriteLine("Please Enter the Valid Choice");
            break;
    }
}