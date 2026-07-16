// for context see: https://learn.microsoft.com/en-gb/training/modules/create-c-sharp-methods-return-values/2-exercise-understand-return-type-syntax

double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd) // to return from a method, define a type
{
    int rate = 23500;
    return (int) (rate * usd);
}

double VndToUsd(int vnd) 
{
    double rate = 23500;
    return vnd / rate;
}

/* 
on reflection it does make quite a bit of sense.
A procedure (method that returns nothing) is defined as a type void as it has no data to attribute
whereas a function must have an attributed data type so it knows what to return the data in the form of
*/

//recursive time

string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));

string ReverseSentence(string input) 
{
    string result = "";
    string[] words = input.Split(" ");
    foreach(string word in words) 
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}

string ReverseWord(string word) 
{
    string result = "";
    for (int i = word.Length - 1; i >= 0; i--) 
    {
        result += word[i];
    }
    return result;
}

// and finally array methods (yikes)

int[] inputnums = new int[] { 5, 2, 7, 1, 9 };

int[] OrderNum(int[] functioninput) 
{
    Array.Sort(functioninput);
    return functioninput; 
}

OrderNum(inputnums);   
