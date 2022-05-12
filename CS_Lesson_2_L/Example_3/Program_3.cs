void FillArray(int [] arrayGen)
{
    for (int i = 0; i < arrayGen.Length; i++)
    {

        arrayGen[i] = new Random().Next(1,10);

    }
}

void PrintArray(int [] arrayPrint)
{
    for (int i = 0; i < arrayPrint.Length; i++)
    {

        Console.Write(arrayPrint[i] + " ");

    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);