using System.Diagnostics;
using System;

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
int sum = 0;
int [] arr = new int [10000000];

int count = arr.Length;

for (int i = 0; i < count; i++)
{

    arr[i] = i;

}


for (int i = 0; i < count; i++)
{

    sum += arr[i];

}



stopwatch.Stop();
Console.WriteLine(sum);
Console.WriteLine(stopwatch.ElapsedTicks);