

String[] carManufacturers = { "Ford", "Toyota", "BMW", "Honda" };

Array.Sort(carManufacturers);


foreach (string car in carManufacturers)
{
    Console.WriteLine(car);
}

//for (int carIndex = 0; carIndex <= carManufacturers.Length; carIndex++)
{
   // Console.WriteLine(carManufacturers[carIndex]);
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




