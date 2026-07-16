// for context see: https://learn.microsoft.com/en-gb/training/modules/csharp-arrays-operations/2-exercise-sort-reverse

string[] pallets = [ "B14", "A11", "B12", "A13" ];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine($"First place before: {pallets[0]}");
Array.Clear(pallets, 0, 2);
Console.WriteLine($"First place after: {pallets[0]}");

Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// resizing arrays
Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

// turning a string to an array
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);
// merging an array into a single string with "-" between each element
string joined = String.Join("-", valueArray);
Console.WriteLine(joined);

// split back into an array again
string[] items = joined.Split('-');
foreach (string item in items)
{
    Console.WriteLine(item);
}
