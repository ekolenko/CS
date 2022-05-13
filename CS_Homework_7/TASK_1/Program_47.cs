/*Задача 47: Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.*/

int m = InputNumber("Input number of rows: ");
int n = InputNumber("Input number of columns: ");

double [,] arr = new double [m,n];

RandomizeArray(arr);
PrintArray(arr);

int InputNumber(string message)
{   
    Console.Write(message);
    int number;
    
    while (!int.TryParse(Console.ReadLine(), out number) && number < 0)
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write(message);
        
    }

    return number;
}

void RandomizeArray(double [,] arrayIn) 
{   
    Random rnd = new Random();
    for (int i = 0; i < arrayIn.GetLength(0); i++)  
        for (int j = 0; j < arrayIn.GetLength(1); j++)     
            arrayIn[i,j] = rnd.NextDouble();
}

void PrintArray(double [,] arrayIn)
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