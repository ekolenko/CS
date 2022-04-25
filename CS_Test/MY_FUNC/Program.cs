void PrintArray(int[] arrayIn) 
{    
    string someChars;
    Console.Write("[");

    for (int i = 0; i < arrayIn.Length; i++)
    {   

        someChars = (i == 0)?"":", ";
        Console.Write(someChars+arrayIn[i]);

    }

    Console.WriteLine("]");
}

void RandomizeArray(int[] arrayIn, int from, int to) 
{
    for (int i = 0; i < arrayIn.Length; i++)        
        arrayIn[i] = new Random().Next(from,to);
}

void RandomizeArray(int[] arrayIn) 
{
    for (int i = 0; i < arrayIn.Length; i++)        
        arrayIn[i] = new Random().Next();
}

int InputIntNumber(string numberName)
{   
    Console.Write($"Input integer number {numberName}: ");
    int number;
    
    while (!int.TryParse(Console.ReadLine(), out number))
    {

        Console.WriteLine("You inputed something wrong! Try again.");
        Console.Write($"Input integer number {numberName}: ");
        
    }

    return number;
}
