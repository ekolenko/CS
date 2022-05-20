
PrintNumber(InputNumber(""));

void PrintNumber(uint n)
{

    if (n == 1)
    {
        Console.Write(n + " ");    
    }
    else 
    {
        PrintNumber(n - 1);
        Console.Write(n + " ");
    }
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
