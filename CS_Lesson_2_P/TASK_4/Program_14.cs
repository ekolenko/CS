Console.Write("Please input a number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (( numberA % 7 == 0) && (numberA % 23 == 0)) 
    Console.WriteLine("Кратно");
else
    Console.WriteLine("Не кратно");


// if ( numberA % 7 == 0)
// {

//     if (numberA % 23 == 0)
//     {
//         Console.WriteLine("Кратно");  
//     }
//     else Console.WriteLine("Не кратно");

// }
// else Console.WriteLine("Не кратно");