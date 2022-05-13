/*Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.*/

int m = InputNumber("Input number of rows: ");
int n = InputNumber("Input number of columns: ");

int [,] arr = new int [m,n];

RandomizeArray(arr,1,10);
PrintArray(arr);

int i = InputNumber("Input index [i]: ");
int j = InputNumber("Input index [j]: ");

if (i >= m || j >= n)
    System.Console.WriteLine("No element with inputed index.");
else
    System.Console.WriteLine($"a[{i},{j}] = {arr[i,j]}");

int InputNumber(string message)
{   
    Console.Write(message);
    int number;
    
    while (!int.TryParse(Console.ReadLine(), out number) && number < 0)
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write(message);
        
    }

    return number;
}

void RandomizeArray(int[,] arrayIn, int min, int max) 
{   
    Random rnd = new Random();
    for (int i = 0; i < arrayIn.GetLength(0); i++)  
        for (int j = 0; j < arrayIn.GetLength(1); j++)      
            arrayIn[i,j] = rnd.Next(min,max);
}

void PrintArray(int [,] arrayIn)
{
    for (int i = 0; i < arrayIn.GetLength(0); i++)  
    {
        for (int j = 0; j < arrayIn.GetLength(1); j++) 
        {
            System.Console.Write(arrayIn[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}
