/*Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/

uint m = InputNumber("Input number of rows: ");
uint n = InputNumber("Input number of columns: ");

int[,] arr = new int[m, n];

RandomizeArray(arr, 1, 10); 
PrintArray(arr);
Console.WriteLine();

int minSumRow = int.MaxValue;
int minSumRowIndex = FindMinSumRowIndex(arr);
Console.WriteLine($"Minimal sum {minSumRow} in row {minSumRowIndex}.");

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

void RandomizeArray(int[,] arrayIn, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arrayIn.GetLength(0); i++)
        for (int j = 0; j < arrayIn.GetLength(1); j++)
            arrayIn[i, j] = rnd.Next(min, max);
}

void PrintArray(int[,] arrayIn)
{
    for (int i = 0; i < arrayIn.GetLength(0); i++)
    {
        for (int j = 0; j < arrayIn.GetLength(1); j++)
        {
            System.Console.Write(arrayIn[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int FindMinSumRowIndex(int[,] arrayIn)
{   
    int minSumRowIndex = 0;
    for (int i = 0; i < arrayIn.GetLength(0); i++)
    {
        int SumRow = 0;
        for (int j = 0; j < arrayIn.GetLength(1); j++)
            SumRow += arrayIn[i, j];
        if (SumRow < minSumRow)
        {
            minSumRow = SumRow;
            minSumRowIndex = i;
        }
    }
    return minSumRowIndex;
}
