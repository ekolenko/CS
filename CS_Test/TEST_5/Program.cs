/*Задача 62: Заполните спирально массив 4 на 4.*/
using System.Diagnostics;

const uint m = 10000;
const uint n = 10000;

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

int step = 0;
long arrSize = m * n;

int[,] arr = new int[m, n];

SpiralArray(arr);

stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);


void SpiralArray(int[,] arrayIn)
{   
    int startRow = 0;
    int startColumn = 0;
    int endRow = arrayIn.GetLength(0) - 1;
    int endColumn = arrayIn.GetLength(1) - 1;
        
    while (step < arrSize)
    {   
        for (int i = 0; i < 4 && step < arrSize; i++)
            FillLine(arrayIn, i, ref startRow, ref startColumn, ref endRow, ref endColumn);
    }
}

void FillLine (int[,] arrayIn, int moveDirection, ref int startRow, ref int startColumn, ref int endRow, ref int endColumn)
{
    switch (moveDirection)
    {
        case 0: FillForward(arrayIn, startColumn, endColumn, true, startRow);
                startRow++;
                break;
        case 1: FillForward(arrayIn, startRow, endRow, false, endColumn);
                endColumn--;
                break;
        case 2: FillBack(arrayIn, endColumn, startColumn, true, endRow);
                endRow--;
                break;
        case 3: FillBack(arrayIn, endRow, startRow, false, startColumn);
                startColumn++;
                break;        
    }
}

void FillForward(int[,] arrayIn, int i, int j, bool isRow, int fixedIndex)
{
    for (; i <= j; i++)
    {
        if (isRow) 
            arrayIn[fixedIndex,i] = ++step;
        else
            arrayIn[i,fixedIndex] = ++step;
    }
}

void FillBack(int[,] arrayIn, int i, int j, bool isRow, int fixedIndex)
{
    for (; i >= j; i--)
    {
        if (isRow) 
            arrayIn[fixedIndex,i] = ++step;
        else
            arrayIn[i,fixedIndex] = ++step;
    }
}
