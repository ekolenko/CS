/*Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.*/

uint m1 = InputNumber("Input number of rows for Matrix 1: ");
uint n1 = InputNumber("Input number of columns Matrix 1: ");

uint m2 = InputNumber("Input number of rows for Matrix 2: ");
uint n2 = InputNumber("Input number of columns Matrix 2: ");

if (!(n1 == m2))
{
    System.Console.WriteLine("Multiplication impossible!");
    return;
}

int[,] matrix1 = new int[m1, n1];
int[,] matrix2 = new int[m2, n2];

RandomizeArray(matrix1, 1, 10); 
RandomizeArray(matrix2, 1, 10); 

PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();

int[,] mulMatrix = MultiMatrix(matrix1, matrix2);
PrintArray(mulMatrix);

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
           Console.Write(arrayIn[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] MultiMatrix(int[,] mtrx1, int[,] mtrx2)
{
    int[,] multiMatrx = new int[mtrx1.GetLength(0), mtrx2.GetLength(1)];

    for (int i = 0; i < multiMatrx.GetLength(0); i++)
        for (int j = 0; j < multiMatrx.GetLength(1); j++)
            multiMatrx[i,j] = MultiElement(mtrx1, mtrx2, i, j);

    return multiMatrx;
}

int MultiElement(int[,] mtrx1, int[,] mtrx2, int row, int column)
{   
    int result = 0;
    for (int i = 0; i < mtrx1.GetLength(1); i++)
    {
        result += mtrx1[row,i] * mtrx2[i,column];
    }

    return result;
}