/*Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты
*/

int m = InputIntNumber("M");
int n = InputIntNumber("N");

int [,] arr = new int [m,n];

RandomizeArray(arr, 1, 10);
PrintArray(arr);

ChangeArray(arr);

System.Console.WriteLine();

PrintArray(arr);


void RandomizeArray(int[,] arrayIn, int min, int max) 
{   
    Random rnd = new Random();
    for (int i = 0; i < arrayIn.GetLength(0); i++)  
        for (int j = 0; j < arrayIn.GetLength(1); j++)      
            arrayIn[i,j] = rnd.Next(min,max);
}

int InputIntNumber(string numberName)
{   
    Console.Write($"Input integer number {numberName}: ");
    int number;
    
    while (!int.TryParse(Console.ReadLine(), out number))
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write($"Input integer number {numberName}: ");
        
    }

    return number;
}

void PrintArray(int [,] arrayIn)
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

void ChangeArray(int [,] arrayIn)
{   
    for (int i = 2; i < arrayIn.GetLength(0); i+=2)
        for (int j = 2; j < arrayIn.GetLength(1); j+=2) 
        arrayIn[i,j] *= arrayIn[i,j];
        
}
