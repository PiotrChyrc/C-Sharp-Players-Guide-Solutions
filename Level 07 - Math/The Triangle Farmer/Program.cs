Console.WriteLine("Please enter base size");
String Base = Console.ReadLine();
Console.WriteLine("Please enter height");
String Height = Console.ReadLine();

float area = (Convert.ToSingle(Base) * Convert.ToSingle(Height) / 2 );
Console.WriteLine("The Area is " + Convert.ToString(area));