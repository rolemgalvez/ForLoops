//Welcome message
Console.WriteLine("Yearly Contribution");
Console.WriteLine("-------------------");
Console.WriteLine();

//Prepare value
List<decimal> contributions = new();
contributions.Add(123.45M);
contributions.Add(234.56M);
contributions.Add(345.67M);
contributions.Add(456.78M);
contributions.Add(567.89M);

decimal yearlyContribution = 0;

for (int i = 0; i < contributions.Count; i++)
{
    yearlyContribution += contributions[i];
}

//Show value
Console.WriteLine($"Yearly contribution is Php {yearlyContribution.ToString("N")}");

//End
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();