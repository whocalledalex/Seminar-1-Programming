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