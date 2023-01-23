//Welcome message
Console.WriteLine("Monthly Expense");
Console.WriteLine("---------------");
Console.WriteLine();

//Prepare values
List<decimal> expenses = new();
expenses.Add(123.34M);
expenses.Add(34234M);
expenses.Add(34.23M);
expenses.Add(324M);
expenses.Add(348230948.123213M);

decimal total = 0;

//Sum expenses
for (int i = 0; i < expenses.Count; i++)
{
    total += expenses[i];
}

//Show total
Console.WriteLine($"Total monthly expense is Php {total.ToString("N")}");

//End of program
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();