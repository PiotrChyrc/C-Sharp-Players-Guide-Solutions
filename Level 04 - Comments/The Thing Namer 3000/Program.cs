using System.Text;

Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); //This stores the noun of the sentence
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); /* This Stores the adjective describing the noun*/
string c = "of Doom"; // This Stores text
string d = "3000"; //This stores the version number
Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");
