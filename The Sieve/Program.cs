using The_Sieve;
int userNumberTested;
int menuSelection;



    Console.WriteLine($"How would you like to test this number?" +
        $"\n1 - Check if EVEN number." +
        $"\n2 - Check if MULTIPLE OF TEN number." +
        $"\n3 - Check if POSITIVE number");
    menuSelection = Convert.ToInt16(Console.ReadLine());

    Sieve sieve = menuSelection switch
    {
        1 => new Sieve(IsEven),
        2 => new Sieve(IsMultipleOfTen),
        3 => new Sieve(IsPositive)
    };

while (true)
{
    Console.WriteLine("enter the number you would like to test.");
    userNumberTested = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine(userNumberTested + "-" + sieve.IsGood(userNumberTested));
}
//

bool IsEven(int number) => number % 2 == 0;
bool IsMultipleOfTen(int number) => number % 10 == 0;
bool IsPositive(int number) => number > 0;




