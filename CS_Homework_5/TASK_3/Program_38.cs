/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным значением элементов массива. 
Длина массива задается с терминала.*/

int arrLength = InputIntNumber("Input array size: ");
if (arrLength <= 0) 
{   
    Console.WriteLine("Array size must be more than 0");
    return;
}
double[] arr = new double [arrLength];
FillArray(arr);
PrintArray(arr);
Console.WriteLine("Difference between MAX and MIN values = " + FindDifferenceMaxMin(arr));


int InputIntNumber(string messageText)
{   
    Console.Write(messageText);
    int number;
    
    while (!int.TryParse(Console.ReadLine(), out number))
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write(messageText);
        
    }

    return number;
}

double InputDoubleNumber(string messageText)
{   
    Console.Write(messageText);
    double number;
    
    while (!double.TryParse(Console.ReadLine(), out number))
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write(messageText);
        
    }

    return number;
}

void FillArray( double[] arrayIn)
{
    for (int i = 0; i < arrayIn.Length; i++)
        arrayIn[i] = InputDoubleNumber($"Input array element [{i}]: ");
}

void PrintArray(double[] arrayIn) 
{    
    string someChars;
    Console.Write("[");

    for (int i = 0; i < arrayIn.Length; i++)
    {   
        someChars = (i == 0)?"":" ";
        Console.Write(someChars + arrayIn[i]);

    }

    Console.WriteLine("]");
}

double FindDifferenceMaxMin(double[] arrayIn)
{   
    double max = arrayIn[0];
    double min = arrayIn[0];

    foreach (double element in arrayIn)
    {
        if (element > max) 
            max = element;
        else if (element < min)
            min = element;
    };

    return Math.Abs(max - min);    

}