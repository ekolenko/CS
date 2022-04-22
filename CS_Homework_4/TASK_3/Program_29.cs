/*Напишите программу, которая задаёт
массив из 8 случайных целых чисел и выводит их на
экран. Диапазон – любое целое число.*/

const int ARRAY_LENGTH = 8;

int[] arr = new int [ARRAY_LENGTH];

arr = RandomizeArray(arr);
PrintArray(arr);

int[] RandomizeArray(int[] arrayIn)
{

    for (int i = 0; i < arrayIn.Length; i++)
    {
        
        arrayIn[i] = new Random().Next(int.MinValue,int.MaxValue);

    }
    
    return arrayIn;
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
