Console.Write("Please input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 1) 

{

   Console.WriteLine("You need input a number more then 1. Try next time)"); 

}
else
{

    for (int i = 2; i <= number; i += 2) 
    {

       Console.Write(i + " ");

    }

}