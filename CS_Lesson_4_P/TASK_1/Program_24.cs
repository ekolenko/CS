/* Напишите программу, которая
принимает на вход число (А) и выдаёт сумму чисел
от 1 до А. */

int InputNumber(string Text)
{
    for (;;)
    {
        try
        {

            Console.Write(Text);
            int number = Convert.ToInt32(Console.ReadLine());
            return number;

        }

        catch (System.FormatException)
        {

            Console.WriteLine("Error! You inputed not integer number!");

        }
        catch (System.OverflowException)
        {

            Console.WriteLine("Error! You inputed too big number for int type!");

        }
    }

}

int numberA = InputNumber("Input number A: ");
int result = 0;
for (int i = 1; i <= numberA;  i++ )
{

    result +=i;

}

Console.WriteLine($"Summary = {result}");
