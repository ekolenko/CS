/*Задача 65: Дано натуральное число N. Выведите слово YES, 
если число N является точной степенью двойки, или слово NO в противном случае. 
Операцией возведения в степень пользоваться нельзя. N = 5 -> “NO" N = 4096 -> “YES"
*/

uint n = InputNumber(":");

if (n < 2) System.Console.WriteLine("Number less 2");

if (check(n))
    System.Console.WriteLine("yes");
else
    System.Console.WriteLine("no");

bool check(uint n)
{

    if (n == 2)
        return true;

    if (n % 2 > 0)
        return false;
    else
        return check(n / 2);

}

uint InputNumber(string message)
{
    Console.Write(message);
    uint number;

    while (!uint.TryParse(Console.ReadLine(), out number) & number < 0)
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write(message);

    }

    return number;
}
