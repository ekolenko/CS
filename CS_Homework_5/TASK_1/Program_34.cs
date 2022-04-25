/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве. 
Длина массива задается с терминала.*/

const int FROM = 100;
const int TO = 1000;


int arrLength = InputIntNumber("Input array size: ");
if (arrLength <= 0) 
{   
    Console.WriteLine("Array size must be more than 0");
    return;
}
int[] arr = new int [arrLength];
RandomizeArray(arr, FROM, TO);
PrintArray(arr);
Console.WriteLine("Number of even elements = " + FindCountEvenElements(arr));


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

int FindCountEvenElements(int[] arrayIn)
{
    int result = 0;
    foreach (int element in arrayIn)
        if (element % 2 == 0) result++;

    return result;
}