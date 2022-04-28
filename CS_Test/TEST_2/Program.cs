var arr = new int[5]{1,2,3,4,5};

MyFunc(arr);

void MyFunc (int[] arrayIn)
{
   foreach (int e in arrayIn)
   Console.Write(e + " ");
}