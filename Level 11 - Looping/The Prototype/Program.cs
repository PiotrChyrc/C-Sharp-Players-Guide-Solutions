using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;

int realNumber;
int guessNumber = -1;
do
    {
        Console.Write("User 1, enter a number between 0 and 100: ");
        realNumber = Convert.ToInt32(Console.ReadLine());
    }
while (realNumber < 0 || realNumber > 100);

Console.Clear();

Console.WriteLine("User 2, guess the number.");

while (realNumber != guessNumber)
{

    Console.Write("What is your next guess? ");
    guessNumber = Convert.ToInt32(Console.ReadLine());

    if (realNumber == guessNumber)
    {
        Console.WriteLine("You guessed the number!");
    }
    else if (realNumber > guessNumber)
    {
        Console.WriteLine($"{guessNumber} is too low.");
    }
    else if (realNumber < guessNumber)
    {
        Console.WriteLine($"{guessNumber} is too high.");
    }
}


