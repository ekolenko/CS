﻿// Console.Write("Please input a quadrant number: ");
// int qNumber = Convert.ToInt32(Console.ReadLine());


//  string getRange(int qNumber)
//  {

//      if (qNumber == 1) return "X > 0 , Y > 0";    
//      if (qNumber == 2) return "X > 0 , Y < 0";
//      if (qNumber == 3) return "X < 0 , Y < 0";
//      if (qNumber == 4) return "X < 0 , Y > 0";


//      return "-1";

//  }

// Console.WriteLine(getRange(qNumber));

 Console.Write("Please input a quadrant number: ");
 
 string getRange(string anyString2)
 {

     if (anyString2 == "1") return "X > 0 , Y > 0";    
     if (anyString2 == "2") return "X > 0 , Y < 0";
     if (anyString2 == "3") return "X < 0 , Y < 0";
     if (anyString2 == "4") return "X < 0 , Y > 0";


     return "You inputed wrong quadrant!";

 }

 Console.WriteLine(getRange(Console.ReadLine()));