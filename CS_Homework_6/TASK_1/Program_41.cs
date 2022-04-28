/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.*/

int count = 0;
string[] arrayStr;
Console.WriteLine("Input some numbers separated with space:");
string? inputStr = Console.ReadLine();

if (inputStr != null) //убрать "warning CS8602: Разыменование вероятной пустой ссылки"
    arrayStr = inputStr.Split(" ");
else
    return;

foreach (string e in arrayStr)
{
    if (!CheckNumber(e, ref count)) 
        continue;
}

Console.WriteLine($"Count numbers less than 0 = {count}");

bool CheckNumber(string numberStr,ref int count)
{
    int number;
    if (numberStr == String.Empty)
        return false;
    if (int.TryParse(numberStr, out number))
    {
        if (number < 0) count++;
    }
    else 
        Console.WriteLine($"Warning! Inputed value [{numberStr}] will be ignored. Not integer number");

    return true;
}