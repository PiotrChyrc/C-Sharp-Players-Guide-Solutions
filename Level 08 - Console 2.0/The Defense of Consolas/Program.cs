Console.Write("What is the target row? ");
int targetRow = Convert.ToInt32(Console.ReadLine());

Console.Write("What is the target column? ");
int targetColumn = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Deploy to:");
Console.WriteLine($"{targetRow},{targetColumn - 1}");
Console.WriteLine($"{targetRow - 1},{targetColumn}");
Console.WriteLine($"{targetRow},{targetColumn + 1}");
Console.WriteLine($"{targetRow + 1},{targetColumn}");

Console.Title = "Defense of Consolas";
Console.Beep();
