using System.Diagnostics;

const int line = 10000;
const int column = 10000;
const int min = 0;
const int max = 10;


Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();


int[,] array = new int[line, column];

FillArray(array, min, max, line, column);

stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);

void FillArray(int[,] arr, int minValue, int maxValue, int line, int column) //Сам я здесь не смог справиться 
{
    int i = 0; 
    int j = 0;
    int a = 1; 
    int b = 0; 
    int directChanges = 0;
    int count = column;

    for (int k = 0; k < arr.Length; k++)
    {
        arr[i, j] = k + 1;
        count--;
        if (count == 0)
        {
            count = column * (directChanges % 2) + line * ((directChanges + 1) % 2) - (directChanges / 2 - 1) - 2;
            int temp = a;
            a = -b;
            b = temp;
            directChanges++;
        }
        i += b;
        j += a;
    }
}
