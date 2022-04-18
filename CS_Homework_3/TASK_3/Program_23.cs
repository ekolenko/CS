/*Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N*/

for (; ; )
{

    Console.Write("Please input integer number: ");

    try
    {

        int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 1)
        {
            printCube(number);
            break;
        }

        else Console.WriteLine("Error! You inputed number less then 1. Try more.");
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

void printCube(int anyNumber)
{

    for (int i = 1; i <= anyNumber; i++)
    {

        Console.WriteLine(i + " -> " + Cube(i));

    }

}

double Cube(int n)
{

    return Math.Pow(n, 3);

}
