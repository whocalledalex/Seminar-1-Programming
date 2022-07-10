// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Insert the first number:");
int numberA = Convert.ToInt32(Console.ReadLine( ));
Console.WriteLine("Insert the second number:");
int numberB = Convert.ToInt32(Console.ReadLine( ));
Console.WriteLine("Insert the third number:");
int numberC = Convert.ToInt32(Console.ReadLine( ));
int max = numberA;
if (max < numberB)
{
    max = numberB;
}
else if (max < numberC)
{
    max = numberB;
}
Console.WriteLine($"Maximum number = {max}");