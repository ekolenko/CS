Console.Write("Please input a number X: ");
int numberX = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input a number Y: ");
int numberY = Convert.ToInt32(Console.ReadLine());

int Part(int x, int y)
{

    if (x > 0 && y > 0) return 1;
    if (x > 0 && y < 0) return 2;
    if (x < 0 && y < 0) return 3; 
    if (x < 0 && y > 0) return 4;
    
    return -1;

}

Console.WriteLine(Part(numberX,numberY));