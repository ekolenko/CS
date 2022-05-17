/*Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.*/

int m = InputNumber("Input number of rows: ");
int n = InputNumber("Input number of columns: ");

int[,] arr = new int[m, n];

RandomizeArray(arr, 1, 10);
PrintArray(arr);

SortArray(arr);
Console.WriteLine();
PrintArray(arr);

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

void SortArray(int[,] arrayIn)
{
    for (int i = 0; i < arrayIn.GetLength(0); i++)
        SortLine(arrayIn, i);

}

void SortLine(int[,] arrayIn, int lineNumber)
{
    bool b = true;
    int k = arrayIn.GetLength(1) - 1;
    while (b)
    {
        b = false;
        for (int j = 0; j < k; j++)
            if (arrayIn[lineNumber, j] < arrayIn[lineNumber, j + 1])
            {
                Swap(ref arrayIn[lineNumber, j], ref arrayIn[lineNumber, j + 1]);
                b = true;
            }
        k--;
    }
}

void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}