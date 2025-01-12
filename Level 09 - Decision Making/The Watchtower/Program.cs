Console.Write("What is the value of X? ");
int xValue = Convert.ToInt32(Console.ReadLine());
Console.Write("What is the value of Y? ");
int yValue = Convert.ToInt32(Console.ReadLine());

if (xValue > 0 && yValue > 0) Console.WriteLine("The enemy is to the northeast!");
if (xValue > 0 && yValue == 0) Console.WriteLine("The enemy is to the east!");
if (xValue > 0 && yValue < 0) Console.WriteLine("The enemy is to the southeast!");
if (xValue == 0 && yValue > 0) Console.WriteLine("The enemy is to the north!");
if (xValue == 0 && yValue == 0) Console.WriteLine("The enemy is here!");
if (xValue == 0 && yValue < 0) Console.WriteLine("The enemy is to the south!");
if (xValue < 0 && yValue > 0) Console.WriteLine("The enemy is to the northwest!");
if (xValue < 0 && yValue == 0) Console.WriteLine("The enemy is to the west!");
if (xValue < 0 && yValue < 0) Console.WriteLine("The enemy is to the southwest!");