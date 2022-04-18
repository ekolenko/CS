
for (;;)
{

    int number5 = InputNumber("Please input a five-digit number: ");

    if (number5 < 10000 ||
        number5 > 99999)
    {
        Console.WriteLine("Error! You inputed not five-digit number!");
    }
    else
    {

        if (number5 / 10000 == number5 % 10 &&
            number5 / 1000 % 10 == number5 / 10 % 10)
        {

            Console.WriteLine("Yes! This number is palindrome.");

        }
        else
        {

            Console.WriteLine("No! This number is not palindrome.");

        }

        break;
    }


}

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