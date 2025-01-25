using System;

int[] array = new int[5];
Console.WriteLine("Please enter 5 numbers ");

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Please enter number {i + 1}");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int[] secondArray = new int[5];

for  (int i = 0; i < secondArray.Length;i++)
{
    secondArray[i] = array[i];
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{array[i]} and {secondArray[i]}");
}
