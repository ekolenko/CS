const int m = 4;
const int n = 3;

int [,] arr = new int [m, n];

RandomizeArray(arr, -99, 100);

PrintArray(arr);

void RandomizeArray(int[,] arrayIn, int min, int max) 
{
    for (int i = 0; i < arrayIn.GetLength(0); i++)  
        for (int j = 0; j < arrayIn.GetLength(1); j++)      
            arrayIn[i,j] = new Random().Next(min,max);
}

void PrintArray(int[,] arrayIn)
{
    for (int i = 0; i < arrayIn.GetLength(0); i++)  
    {
        for (int j = 0; j < arrayIn.GetLength(1); j++) 
        {
            System.Console.Write(arrayIn[i,j] + " ");
        }
        System.Console.WriteLine();
    }
}