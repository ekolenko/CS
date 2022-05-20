/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.*/

int a = InputNumber("-> ");
int b = InputNumber("-> ");
//uint sum = 0;

System.Console.WriteLine(Pow(a,b));

int Pow(int a, int b)
{

    if (b == 1)
    {
        return a;
    }
    else
    {
        return a * Pow(a, --b);
    }

}

int InputNumber(string message)
{
    Console.Write(message);
    int number;

    while (!int.TryParse(Console.ReadLine(), out number) & number < 0)
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write(message);

    }

    return number;
}