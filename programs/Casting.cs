// for context see: https://learn.microsoft.com/en-gb/training/modules/csharp-convert-cast/4-challenge

using System.Runtime.CompilerServices;

decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

Console.WriteLine($"String concatenated: {myInt.ToString() + myInt.ToString()}");

string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine($"String to integer: {sum}");

string value1 = "3";
string value2 = "2";
int sumresult = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine($"String to integer: {sumresult}");

string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}");

Console.WriteLine("\nChallenge\n");
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal total = 0;
string message = "";
foreach (string item in values)
{
    bool IsANum = decimal.TryParse(item, out decimal number);
    if (IsANum)
    {
        total += decimal.Parse(item);
    }
    else
    {
        message += item;
    }
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
