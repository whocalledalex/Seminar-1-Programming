﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Insert the number:");
int N = Convert.ToInt32(Console.ReadLine( ));
int index = 0;
int number = 0;
while (index < N)
{
    if (number % 2 == 0)
    {
        Console.Write($"{number}, ");
    }
    index = index + 1;
    number = number + 1;
}
if (N % 2 == 0)
{
    Console.Write(N);
}
