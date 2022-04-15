Console.Write("Please input a number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Please input a number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if ( numberA % numberB == 0) 
    Console.WriteLine("Кратно");
else
    Console.WriteLine("Не кратно, остаток " + numberA % numberB);