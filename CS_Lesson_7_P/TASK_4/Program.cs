/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
*/

int m = InputIntNumber("M");
int n = InputIntNumber("N");

int [,] arr = new int [m,n];

RandomizeArray(arr, 1, 10);
PrintArray(arr);
Console.WriteLine($"Сумма главной диагонали = {SumDiag(arr)}");

void RandomizeArray(int[,] arrayIn, int min, int max) 
{   
    Random rnd = new Random();
    for (int i = 0; i < arrayIn.GetLength(0); i++)  
        for (int j = 0; j < arrayIn.GetLength(1); j++)      
            arrayIn[i,j] = rnd.Next(min,max);
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

int SumDiag(int [,] arrayIn)
{   
    int minValue = Min(m,n);
    int sum = 0;
    for (int i = 0; i < minValue; i++)
        sum += arrayIn[i,i];
        
    return sum;
}

int Min(int a, int b)
{
    if (a < b) return a; 
    else return b;
}
