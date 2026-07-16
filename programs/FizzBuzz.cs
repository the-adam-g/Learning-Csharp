// for context see: https://learn.microsoft.com/en-gb/training/modules/csharp-for/3-exercise-challenge-for-statements

for (int i = 0; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine($"{i} FizzBuzz");
    } else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} Fizz");
    } else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} Buzz");
    } else
    {
        Console.WriteLine($"{i}");
    }
}
