int result = AskForNumber("What is the airspeed velocity of an unladen swallow?");

int AskForNumber(string text)
{
    Console.WriteLine($"{text} ");
    int convertedText = Convert.ToInt32(Console.ReadLine());
    return convertedText;
}

int AskForNumberInRange(string text, int min, int max)
{
    while (true)
    {
        int number = AskForNumber("Please give a number");

        if (number >= min && number <= max)
        {
            return number;
        }    
    }
}