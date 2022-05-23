

int a = InputNumber("a -> ");
int b = InputNumber("b -> ");
int n = InputNumber("n -> ");

int [] temp = new int[n + 2];

temp[0] = a;
temp[1] = b;

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


for (int i = 2; i < temp.Length; i++)
{
    temp[i] = temp[i-2] + temp[i-1];
}


for (int i = 0; i < temp.Length; i++)
{
    System.Console.Write(temp[i]+ " "); 
}
