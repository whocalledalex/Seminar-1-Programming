﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Insert the first number:");
int numberA = Convert.ToInt32(Console.ReadLine( ));
Console.WriteLine("Insert the second number:");
int numberB = Convert.ToInt32(Console.ReadLine( ));
int max = numberA;
if (max < numberB)
{
    max = numberB;
}
Console.WriteLine($"Maximum number = {max}");