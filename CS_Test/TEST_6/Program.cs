/*
Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Числа выбираются случайно, при этом проверяется, что такого числа еще не было. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
*/
int m = InputValue ("количество рядов ");
int n = InputValue ("количество столбцов ");
int o = InputValue ("глубину массива ");

int[,,]  array = new int[m,n,o];
if (m*n*o > 99) {
    Console.WriteLine("Массив слишком большой");
}else{
    FillArray(array, 10, 99);
    PrintArray(array);
}

int InputValue (string element) {
    int value;
    Console.Write($"Введите {element}");
    while(!int.TryParse(Console.ReadLine(), out value) || value <= 0){
        Console.Write($"Ошибка ввода. Введите {element} ");
    }
    return value;
}

void FillArray (int[,,] arr, int min, int max){
    int[] digits = new int[max - min +1];       // создаем массив с числами от 10 до 99
    for (int i = 0; i < digits.Length; i++) {
        digits[i] = 10 + i;
    }
    for (int i = digits.Length - 1; i >=1; i--) {   // перемешиваем цифры в массиве
        int j = new Random().Next(i+1);
        int temp = digits[j];
        digits[j] = digits[i];
        digits[i] = temp;
    }
    int s = 0;
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            for (int l = 0; l < arr.GetLength(2); l++) {
                arr[i,j,l] = digits[s];                     // переносим из массива в трехмерный
                s++;
            }
        }
    }
}

void PrintArray (int[,,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            for (int l =0; l < arr.GetLength(2); l++) {
                Console.Write($"[{i},{j},{l}] = {arr[i,j,l]}\t");
            }
        Console.WriteLine();    
        }
    }
}