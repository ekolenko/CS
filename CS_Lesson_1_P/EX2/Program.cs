Console.Write("Please input day number: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day == 1) 
{
    Console.WriteLine("This is Monday");
} 
else if (day == 2) 
{
    Console.WriteLine("This is Tuesday");
}
else if (day == 3) 
{
    Console.WriteLine("This is Wednesday");
}
else if (day == 4) 
{
    Console.WriteLine("This is Thursday");
}
else if (day == 5)
{
    Console.WriteLine("This is Friday");
}
else if (day == 6) 
{
    Console.WriteLine("This is Saturday");
}
else if (day == 7) 
{
    Console.WriteLine("This is Sunday");
}
else 
{
    Console.WriteLine("This is not correct day of week");
}