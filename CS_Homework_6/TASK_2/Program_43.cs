/*Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.*/


double k1 = InputDoubleNumber("Input k1: ");
double b1 = InputDoubleNumber("Input b1: ");
double k2 = InputDoubleNumber("Input k2: ");
double b2 = InputDoubleNumber("Input b2: ");


if (k1 == k2)
{
    if (b1 == b2)
        Console.WriteLine("Line equal");
    else
        Console.WriteLine("Line parallels");
    return;
}

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Cross point = [{x},{y}]");

double InputDoubleNumber(string messageText)
{   
    Console.Write(messageText);
    double number;
    
    while (!double.TryParse(Console.ReadLine(), out number))
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write(messageText);
        
    }

    return number;
}
