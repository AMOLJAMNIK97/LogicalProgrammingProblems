


using LogicalProgramming;

while (true)
{
    Console.WriteLine("1.Eter the Prime Number");
    int option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1:
            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.CheckPrime();
            break;
        default:
            Console.WriteLine("Please Enter the Valid Choice");
            break;
    }
}