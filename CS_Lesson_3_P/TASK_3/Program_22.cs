Console.Write("Please input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

void printSQR (int anyNumber)
{

    for (int i=0; i<anyNumber ; i++)
    {

        Console.WriteLine( i + " -> " + sqr(i));

    }

}


int sqr(int n)
{

    return n*n;

}

printSQR(number);