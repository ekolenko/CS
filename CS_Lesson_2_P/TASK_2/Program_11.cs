
int numberA = new Random().Next(100,1000);


int dig1 = numberA % 10;

int dig2 = (numberA / 10) % 10;

int dig3 = numberA / 100;

int newNumber = dig3 * 10 + dig1;

Console.WriteLine("Для числа " + numberA + " новое число будет " + newNumber);
