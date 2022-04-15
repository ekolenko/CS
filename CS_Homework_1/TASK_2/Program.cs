Console.Write("Please input a number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input a number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input a number С: ");
int numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine("Max = " + max);