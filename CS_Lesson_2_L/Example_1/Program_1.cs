int a1 = 1;
int b1 = 321;
int c1 = 24;
int a2 = 1532;
int b2 = 5;
int c2 = 2;
int a3 = 54;
int b3 = 23;
int c3 = 123;

int Max (int a1, int b1, int c1) 
{

    int max = a1;
    if (b1 > max) max = b1;
    if (c1 > max) max = c1;

    return max;
}


// int max1 = Max(a1,b1,c1);
// int max2 = Max(a2,b2,c2);
// int max3 = Max(a3,b3,c3);

int result = Max(Max(a1,b1,c1), Max(a2,b2,c2), Max(a3,b3,c3));

Console.WriteLine(result);