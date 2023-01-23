//Welcome message
Console.WriteLine("Available Jobs");
Console.WriteLine("--------------");
Console.WriteLine();

//Prepare values
List<string> jobs = new();
jobs.Add("Technical Support");
jobs.Add("Function Consultatnt");
jobs.Add("Software Developer");
jobs.Add("Project Manager");

//Show values
for (int i = 0; i < jobs.Count; i++)
{
    Console.WriteLine(jobs[i]);
}

//End of program
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();