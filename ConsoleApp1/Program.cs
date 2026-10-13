

using System.Linq.Expressions;

String[] carManufacturers = { "Ford", "Toyota", "BMW", "Honda" };

Array.Sort(carManufacturers);


foreach (string car in carManufacturers)
{
    Console.WriteLine(car);
}


try{
for (int carIndex = 0; carIndex <= carManufacturers.Length; carIndex++)
{
    Console.WriteLine(carManufacturers[carIndex]);
}
} catch(Exception e) {
    Console.WriteLine($"Exception: {e.Message}");
} finally
{
    Console.WriteLine("Array processing complete");
}






List<string> months = new List<string>();

months.Add("January");
months.Add("February");
months.Add("March");
months.Add("April");
months.Add("May");
months.Add("June");
months.Add("July");
months.Add("August");
months.Add("September");
months.Add("October");
months.Add("November");
months.Add("December");

Console.WriteLine(months.Count);

months.Remove("September");
months.Remove("November");

Console.WriteLine(months.Count);

Console.WriteLine(months.IndexOf("December"));

String[] monthNamesArray = months.ToArray();


Dictionary<string, int> inventory= new Dictionary<string, int>();

inventory.Add("Health potion", 5);
inventory.Add("Mana potion", 2);
inventory.Add("Gold coin", 200);

inventory["Health potion"] = 20;

try
{
    Console.WriteLine(inventory["Iron Sword"]);
}
catch (KeyNotFoundException e)
{
    Console.WriteLine($"Exception: {e.Message}");
}
finally
{
    Console.WriteLine("Inventory processing complete");
}