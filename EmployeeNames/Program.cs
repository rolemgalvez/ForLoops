//Welcome message
Console.WriteLine("Employee Names");
Console.WriteLine("--------------");

//Prepare values
List<string> names = new();
names.Add("Juan");
names.Add("Pedro");
names.Add("Susan");
names.Add("Manny");

//Show values
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine(names[i]);
}

//End of program
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();