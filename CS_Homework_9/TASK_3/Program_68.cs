/*Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. Даны два неотрицательных числа m и n.*/

uint m = InputNumber("Input number M: ");
uint n = InputNumber("Input number N: ");

System.Console.WriteLine($"A(m,n) = {Ackerman(m,n)}");

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

uint Ackerman(uint m, uint n)
{
    if (m == 0)
        return n + 1;

    else if (n == 0)
        return Ackerman(m - 1, 1);

    else if (n > 0)
        return Ackerman(m - 1, Ackerman(m, n - 1));
  
    return 0;
}