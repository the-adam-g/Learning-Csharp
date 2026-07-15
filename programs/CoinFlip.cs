// See for context : https://learn.microsoft.com/en-gb/training/modules/csharp-evaluate-boolean-expressions/4-exercise-challenge-conditional-operators

Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "heads" : "tails");
