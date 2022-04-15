// Для случайного числа в диапазоне 10-99 вывести наибольшую цифру

//Console.Write("Please input a number A: ");
int numberA = new Random().Next(10,100);

int dig1 = numberA%10;
int dig2 = numberA/10;

if (dig1 > dig2)
{

    Console.WriteLine(dig1);

}
else
{

    Console.WriteLine(dig2);

}

Console.WriteLine(numberA);