/*Задача 13: Напишите программу, которая выводит
третью цифру заданного числа или сообщает, что третьей
цифры нет.*/

for (; ; )
{

    Console.Write("Please input integer number: ");

    try
    {
        int number = Convert.ToInt32(Console.ReadLine());
        number = Math.Abs(number);

        if (number < 100)
        {

            Console.WriteLine("Inputted number has no third digit!");

        }
        else
        {

            while (number > 999) number /= 10;            
            
            Console.WriteLine("The third digit of number: " + number % 10);
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