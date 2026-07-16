// for context see: https://learn.microsoft.com/en-gb/training/modules/csharp-format-strings/5-challenge

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine($"Dear {customerName},\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\nCurrently, you own {currentShares:N} shares at a return of {currentReturn:P2}");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:N}.");
Console.WriteLine("Here's a quick comparison:\n");
Console.WriteLine("");

Console.WriteLine($"{currentProduct.PadRight(20)} {String.Format("{0:P}", currentReturn).PadRight(10)} {String.Format("{0:C}", currentProfit).PadRight(20)}");
Console.WriteLine($"{newProduct.PadRight(20)} {String.Format("{0:P}", newReturn).PadRight(10)} {String.Format("{0:C}", newProfit).PadRight(20)}");
