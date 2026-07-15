// See for context : https://learn.microsoft.com/en-gb/training/modules/csharp-arrays/2-exercise-array-basics

string[] fraudulentOrderIDs = [ "A123", "B456", "C789", "C999"];
int[] Inventory = [400, 699, 259];

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassigned First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

int cClass = 0;

foreach (string orderID in fraudulentOrderIDs)
{
    Console.WriteLine(orderID);
    if (orderID.StartsWith("C"))
    {
        cClass += 1;
    }
}

int sum = 0;

foreach (int Items in Inventory)
{
    sum += Items;
}

Console.WriteLine($"There are {sum} in Inventory");
Console.WriteLine($"There are {cClass} C-Class items in Inventory");
