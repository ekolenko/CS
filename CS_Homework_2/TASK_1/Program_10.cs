/*Задача 10: Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа.*/

for (;;)
{

    Console.Write("Please input a three-digit number: ");

    try
    {
        int number = Convert.ToInt32(Console.ReadLine());

        number = Math.Abs(number);

        if (number < 100 || number > 999)
        {

            Console.WriteLine("Error! You inputed not a three-digit number!");

        }
        else
        {

            Console.WriteLine("The second digit of number: " + number / 10 % 10);
            break;

        }
    }
    catch (System.FormatException)
    {

        Console.WriteLine("Error! You inputed not an integer number!");

    }
    catch (System.OverflowException)
    {

        Console.WriteLine("Error! You inputed too big number for int type!");

    }
}