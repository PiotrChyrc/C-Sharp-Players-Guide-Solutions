Console.WriteLine("How many Estates?");
int enteredEstate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many duchies?");
int enteredDuchies = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("How many provinces?");
int enteredProvinces = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Total points: " + Convert.ToString((enteredDuchies * 3) + (enteredEstate * 1) + (enteredProvinces * 6)));