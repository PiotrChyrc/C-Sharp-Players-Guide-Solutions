double rope = 10;
double torches = 15;
double climbingEquipment = 25;
double cleanWater = 1;
double machete = 20;
double canoe = 200;
double foodSupplies = 1;

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");

Console.Write("What number do you want to see the price of? ");
string choice = Console.ReadLine();

Console.Write("What is your name?");
string name = Console.ReadLine();

if (name == "Piotr Chyrc")
{
    rope = 5;
    torches = 7.5;
    climbingEquipment = 12.5;
    cleanWater = 0.5;
    machete = 10;
    canoe = 100;
    foodSupplies = 0.5;
}

switch (choice)
{
    case "1":
        Console.WriteLine($"Rope costs {rope} gold");
        break;
    case "2":
        Console.WriteLine($"Torches costs {torches} gold");
        break;
    case "3":
        Console.WriteLine($"Climbing Equipment costs {climbingEquipment} gold");
        break;
    case "4":
        Console.WriteLine($"Clean Water costs {cleanWater} gold");
        break;
    case "5":
        Console.WriteLine($"Machete costs {machete} gold");
        break;
    case "6":
        Console.WriteLine($"Canoe costs {canoe} gold");
        break;
    case "7":
        Console.WriteLine($"Food Supplies costs {foodSupplies} gold");
        break;
}