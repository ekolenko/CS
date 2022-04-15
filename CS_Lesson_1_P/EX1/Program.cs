Console.Write("Please input a number A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input a number B: ");
int numberB = Convert.ToInt32(Console.ReadLine());


if (numberA * numberA == numberB) {
    
    Console.Write("True. Number B is sqr(number A)");

} else {

    Console.Write("False. Number B is not sqr(number A)"); 

}