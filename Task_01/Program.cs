Console.WriteLine("Insert the first number:");
int numberA = Convert.ToInt32(Console.ReadLine( ));
Console.WriteLine("Insert the second number:");
int numberB = Convert.ToInt32(Console.ReadLine( ));
double power = Math.Pow(numberB, 2);
if (numberA == power)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
