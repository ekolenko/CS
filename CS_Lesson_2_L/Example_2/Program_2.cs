int Max (int[] array) 
{
    int max = array[0];
    for (int i = 1; i <  array.Length; i++)
    {
    if (array[i] > max) max = array[i];
    }
    return max;
}

int[] array = {21,34,53,23,24,51,76,236,2};

//int result = Max(Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3));

Console.WriteLine(Max(array));