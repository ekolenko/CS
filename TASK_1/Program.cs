const int ARRAY_LENGTH = 123;
const int FROM = 10;
const int TO = 99;

int [] arr = new int[ARRAY_LENGTH];

FillArray(arr);
PrintArray(arr);

Console.WriteLine(FindCount(arr,FROM,TO));


void FillArray(int[] arrayIn) //заполняем массив
{

    for (int i = 0; i < arrayIn.Length; i++)
    {
        
        arrayIn[i] = new Random().Next(0,1000); //вот тут ограничиваем чтобы было наглядно до 1000

    }
    
}

int FindCount(int[] ArrayIn, int from, int to) //ищем количество
{
    int result = 0;
    
    foreach (int e in arr)
    {
        if (e >= 10 && e <= 99) result++;
    }
    
    return result;
}

void PrintArray(int[] arrayIn) //выводим массив
{
    
    string someChars;
    Console.Write("[");

    for (int i = 0; i < arrayIn.Length; i++)
    {   

        someChars = (i == 0)?"":", ";
        Console.Write(someChars+arrayIn[i]);

    }

    Console.WriteLine("]");
}
