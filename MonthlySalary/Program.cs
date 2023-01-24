//Welcome message
Console.WriteLine("Monthly Salary");
Console.WriteLine("--------------");
Console.WriteLine();

//Prepare values
List<decimal> salaries = new();
salaries.Add(5000.0M);
salaries.Add(4000.123M);
salaries.Add(6000.1M);
salaries.Add(5050.50M);

decimal monthlySalary = 0;

for (int i = 0; i < salaries.Count; i++)
{
    monthlySalary += salaries[i];
}

//Show value
Console.WriteLine($"Monthly salary is Php {monthlySalary.ToString("N")}");

//End of program
Console.WriteLine();
Console.WriteLine("End of program");
Console.ReadLine();