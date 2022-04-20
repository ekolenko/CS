int [] arr ={ 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray ( int [] arrayIn)
{

    int count = arrayIn.Length;

    for (int i=0; i < count; i++)
    {

        Console.Write(arrayIn[i]+" ");
        
    }

    Console.WriteLine();

}

int [] SortArray ( int [] arrayIn)
{

    int count = arrayIn.Length;
    for (int i = 0; i < count-1; i++)
    {
        int max = i;
        for (int j = i + 1 ; j < count; j++)
        {
            if (arrayIn[j] > arrayIn[max]) max = j;

        }

        if (max > i) 
        {
            
            int buf = arrayIn[max];
            arrayIn[max] = arrayIn[i];
            arrayIn[i] = buf;

           
        }

        
    }
    return arrayIn;
}

PrintArray(arr);
int [] newarr = SortArray(arr);
PrintArray(newarr);