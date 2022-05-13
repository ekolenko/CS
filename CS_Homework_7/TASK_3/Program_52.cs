/*Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/

int m = InputNumber("Input number of rows: ");
int n = InputNumber("Input number of columns: ");

int [,] arr = new int [m,n];

RandomizeArray(arr,1,10);
PrintArray(arr);
PrintAverage(arr);

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

void PrintAverage(int [,] arrayIn)
{   
    Console.ForegroundColor = ConsoleColor.Yellow;
    for (int j = 0; j < arrayIn.GetLength(1); j++)  
    {   
        double sum = 0;        
        for (int i = 0; i < arrayIn.GetLength(0); i++) 
            sum += arrayIn[i,j];
        Console.Write(sum / arrayIn.GetLength(0) + " ");
    }
    Console.ResetColor();
}