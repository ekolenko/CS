Console.Write("Please input a number: ");
int n = Convert.ToInt32(Console.ReadLine());

int numberA = new Random().Next( Convert.ToInt32(Math.Pow(10,n-1)), Convert.ToInt32(Math.Pow(10,n)));

Console.WriteLine(numberA);

int[] array = new int[n];
int tempNumber = numberA;
for (int i = 0; i < n; i ++)

{

array[i] = tempNumber % 10;
tempNumber = tempNumber / 10;

};

for (int i = 0; i < n; i ++)  Console.Write(array[i]);

