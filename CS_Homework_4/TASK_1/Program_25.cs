/*Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную
степень B*/

int numberA = InputIntNumber("A");
int numberB;

while ((numberB = InputIntNumber("B")) < 0)
{

    Console.WriteLine("The power must be positive! Try again");

}

Console.WriteLine($"{numberA} to the power of {numberB} = {MyPow(numberA,numberB)}");


double MyPow (int a, int b)
{   
    double result = 1;

    for (; b > 0; b--)
    {

        result *= a;

    }

    return result;

}


int InputIntNumber(string numberName)
{   
    Console.Write($"Input integer number {numberName}: ");
    int number;
    
    while (!int.TryParse(Console.ReadLine(), out number))
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write($"Input integer number {numberName}: ");
        
    }

    return number;
}