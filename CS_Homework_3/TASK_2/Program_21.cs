/*Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.*/

int[] A = new int[3];
int[] B = new int[3];

string[] coordinateNames = {"x","y","z"};

A = InputCoordinates(A, "A");
B = InputCoordinates(B, "B");

int tempSum = 0;

for (int i = 0; i < 3; i++)
{

    tempSum += Sqr(A[i] - B[i]);    

}

Console.WriteLine("The distance between A and B = " + Math.Sqrt(tempSum));

int[] InputCoordinates(int[] arrayIn,string dotName)
{
    for (int i = 0; i < 3; i++)
    {

        arrayIn[i] = InputNumber($"{dotName}[{coordinateNames[i]}]");

    }

    return arrayIn;           

}

int InputNumber(string Text)
{
    for (;;)
    {
        try
        {

            Console.Write($"Please input a coordinate {Text}: ");
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

int Sqr(int n)
{

    return n*n;

}
