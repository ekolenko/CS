
int result = 2;
int[] arr = new int[5];


for (int i = 0; i < 5; i++)
    arr[i] = new Random().Next(0,10);
MyFunc(arr);

/*static*/ void MyFunc (int[] arrayIn)
{
result = 1;
foreach (int e in arrayIn)
   Console.Write(e+" "+result);

}

Console.WriteLine("\n"+result);