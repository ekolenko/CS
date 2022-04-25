/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях. 
Длина массива задается с терминала.*/

int arrLength = InputIntNumber("Input array size: ");
if (arrLength <= 0) 
{   
    Console.WriteLine("Array size must be more than 0");
    return;
}
int[] arr = new int [arrLength];
RandomizeArray(arr, int.MinValue, int.MaxValue);
PrintArray(arr);
Console.WriteLine("Sum of odd index elements = " + FindSumOddIndexElements(arr));


int InputIntNumber(string messageText)
{   
    Console.Write(messageText);
    int number;
    
    while (!int.TryParse(Console.ReadLine(), out number))
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write(messageText);
        
    }

    return number;
}

void RandomizeArray(int[] arrayIn, int from, int to) 
{
    for (int i = 0; i < arrayIn.Length; i++)        
        arrayIn[i] = new Random().Next(from,to);
}

void PrintArray(int[] arrayIn) 
{    
    string someChars;
    Console.Write("[");

    for (int i = 0; i < arrayIn.Length; i++)
    {   

        someChars = (i == 0)?"":", ";
        Console.Write(someChars+arrayIn[i]);

    }

    Console.WriteLine("]");
}

long FindSumOddIndexElements(int[] arrayIn)
{
    long result = 0;
    for (int i = 1; i < arrayIn.Length; i += 2)
        result += arrayIn[i];

    return result;
}