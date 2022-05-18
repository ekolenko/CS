/*Задача 62: Заполните спирально массив 4 на 4.*/


uint m = InputNumber("Input number of rows: ");
uint n = InputNumber("Input number of columns: ");

int step = 0;
long arrSize = m * n;

int[,] arr = new int[m, n];

SpiralArray(arr);
PrintArray(arr);

uint InputNumber(string message)
{
    Console.Write(message);
    uint number;

    while (!uint.TryParse(Console.ReadLine(), out number) & number < 0)
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write(message);

    }

    return number;
}

void PrintArray(int[,] arrayIn)
{
    for (int i = 0; i < arrayIn.GetLength(0); i++)
    {
        for (int j = 0; j < arrayIn.GetLength(1); j++)
        {
            AddSpace(arrayIn[i, j]);
            Console.Write(arrayIn[i, j] + " ");
        }
        Console.WriteLine();
    }
}

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

void AddSpace(int number)
{   
    long size = arrSize;
    while (size / 10 > 0) 
    {
        if (number / 10 == 0)
            Console.Write(" ");
        size /= 10;
        number /= 10;
    }
}
