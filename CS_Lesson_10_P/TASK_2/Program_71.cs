/*Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.*/

string ABC = "abcdefghijklm";
string str;

int n = InputNumber("n -> ");
char[] word = new char[n];

int InputNumber(string message)
{
    Console.Write(message);
    int number;

    while (!int.TryParse(Console.ReadLine(), out number) & number < 0)
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write(message);

    }

    return number;
}

printWord(ABC, "", n);

void printWord(string arr, string str, int count)
{

    if (count == 0)
        System.Console.WriteLine(str);

    else
        foreach (char c in ABC) printWord(arr,str + c,count -1);

};
