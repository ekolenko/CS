/*Задача 15: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.*/

for (;;)
{

    Console.Write("Please input number day of the week: ");

    try
    {
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number < 1 || number > 7) 
        {

            Console.WriteLine("Inputted number is not correct day of the week!");

        }
        else if (number == 6 || number == 7)
        {

            Console.WriteLine("Yes! This is weekend!");
            break;

        }
        else
        {

            Console.WriteLine("No! This is not weekend!");
            break;

        }
    }
    catch (System.FormatException)
    {

        Console.WriteLine("Error! You inputed not integer number!");

    }
    catch (System.OverflowException)
    {

        Console.WriteLine("Error! You inputed too big number for int type!");

    }

}