/*Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.*/

uint m = InputNumber("Input number M: ");
uint n = InputNumber("Input number N: ");

if (m > n)
{
    System.Console.WriteLine("M must be more than N");
    return;
}
else    
    PrintNumber(n);

void PrintNumber(uint nNumber)
{
    if (nNumber == m)
    {
        Console.Write(nNumber + " ");    
    }
    else 
    {
        PrintNumber(nNumber - 1);
        Console.Write(nNumber + " ");
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
