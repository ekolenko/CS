Console.Write("Please input a number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input a number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB) 
{
    Console.WriteLine("Max = " + numberA);   
    Console.WriteLine("Min = " + numberB);
}
else if (numberB > numberA) 
{
    Console.WriteLine("Max = " + numberB);   
    Console.WriteLine("Min = " + numberA);
}
else
{
    Console.WriteLine("The numbers are equal");
}