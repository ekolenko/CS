/*Напишите программу, которая принимает на
вход число и выдаёт сумму цифр в числе.
*/

int number = InputIntNumber("");
int tempNumber = Math.Abs(number);
int sum = 0;

for (; tempNumber > 0; tempNumber /=10) 
{   
    sum += tempNumber % 10;
}

Console.WriteLine($"Digits sum of number {number} = {sum}");


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