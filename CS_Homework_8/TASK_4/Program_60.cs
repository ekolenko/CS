/*Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Числа выбираются случайно, при этом проверяется, что такого числа еще не было. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/
using System.Linq;

const int MAX_NUMBER_COUNT = 90;

uint x = InputNumber("Input dimension X: ");
uint y = InputNumber("Input dimension Y: ");
uint z = InputNumber("Input dimension Z: ");

int[,,] arr = new int[x, y, z];

if (x * y * z > MAX_NUMBER_COUNT)
{
    Console.WriteLine("Array too big for 2-digits numbers.");
    return;
}

RandomizeArray(arr, 10, 100);
PrintArray(arr);

uint InputNumber(string message)
{
    Console.Write(message);
    uint number;

    while (!uint.TryParse(Console.ReadLine(), out number))
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write(message);

    }

    return number;
}

void RandomizeArray(int[,,] arrayIn, int min, int max)
{
    bool checkedNumber = false;
    int rndNumber = 0;
    Random rnd = new Random();
    for (int i = 0; i < arrayIn.GetLength(0); i++)
        for (int j = 0; j < arrayIn.GetLength(1); j++)
            for (int k = 0; k < arrayIn.GetLength(2); k++)
            {
                while (!checkedNumber)
                {
                    rndNumber = rnd.Next(min, max);
                    checkedNumber = CheckNumber(arrayIn, rndNumber);
                }
                arrayIn[i, j, k] = rndNumber;
                checkedNumber = false;
            }
}

void PrintArray(int[,,] arrayIn)
{
    for (int k = 0; k < arrayIn.GetLength(2); k++)
        for (int i = 0; i < arrayIn.GetLength(0); i++)
        {
            for (int j = 0; j < arrayIn.GetLength(1); j++)

            {
                PrintIndex(i, j, k);
                Console.Write(arrayIn[i, j, k] + " ");
            }
            Console.WriteLine();
        }
}

void PrintIndex(int i, int j, int k)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write($"[{i},{j},{k}] ");
    Console.ResetColor();
}

bool CheckNumber(int[,,] arrayIn, int rndNumber)
{
    foreach (int item in arrayIn)
        if (item == rndNumber) return false;

    return true;
}