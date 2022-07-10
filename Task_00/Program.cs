Console.WriteLine("Insert your number:");
int number = Convert.ToInt32(Console.ReadLine( ));
Console.WriteLine("Insert the power:");
int power = Convert.ToInt32(Console.ReadLine( ));
double result = Math.Pow(number, power);
Console.WriteLine($"Power {power} of number {number} = {result}");
Console.WriteLine("Thank you for using our program!");
