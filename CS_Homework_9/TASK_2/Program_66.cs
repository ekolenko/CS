/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.*/

uint m = InputNumber("Input number M: ");
uint n = InputNumber("Input number N: ");

if (m > n)
{
    System.Console.WriteLine("M must be more than N");
    return;
}
else    
    System.Console.WriteLine($"Numbers sum from M to N = {SumNumber(n)}");

uint SumNumber(uint nNumber)
{
    if (nNumber == m)
    {
        return(nNumber);    
    }
    else 
    {
        return nNumber + SumNumber(nNumber - 1);
    }
}

uint InputNumber(string message)
{
    Console.Write(message);
    uint number;

    while (!uint.TryParse(Console.ReadLine(), out number))
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write(message);

    }

    return number;
}
