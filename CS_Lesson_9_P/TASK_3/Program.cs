/*Задача 67: Напишите программу, которая будет принимать 
на вход число и возвращать сумму его цифр.*/

uint n = InputNumber(":");
//uint sum = 0;

System.Console.WriteLine(sumM(n));

uint sumM(uint n)
{

    if (n < 10)
    {
        return n ;
    }
    else
    {
        return n % 10 + sumM(n / 10);
    }

}

uint InputNumber(string message)
{
    Console.Write(message);
    uint number;

    while (!uint.TryParse(Console.ReadLine(), out number) & number < 0)
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write(message);

    }

    return number;
}
