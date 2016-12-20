using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_1_7
{         // Scott Robinson
          // Assignment 2
          // 770020625
    class Program
    {
        static void Main(string[] args)
        {

            // Assignment 2 - 1

            //Console.Write("Please enter the first number: ");
            //int Num1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please enter the second number: ");
            //int Num2 = Convert.ToInt32(Console.ReadLine());

            //if (Num1 > Num2)
            //{
            //    Console.WriteLine("The positive difference is: " + (Num1 - Num2));
            //}
            //else if (Num2 > Num1)
            //{
            //    Console.WriteLine("The positive difference is: " + (Num2 - Num1));
            //}

            // Assignment 2-2

            //Console.Write("Please enter a number between 1 and 10: ");
            //int Number = Convert.ToInt32(Console.ReadLine());

            //if (Number > 0 && Number <= 10)
            //{
            //    if (Number == 1)
            //    {
            //        Console.WriteLine("The number with its appropriate two letter ending is: " + Number + "st");
            //    }
            //    if (Number == 2)
            //    {
            //        Console.WriteLine("The number with its appropriate two letter ending is: " + Number + "nd");
            //    }
            //    if (Number == 3)
            //    {
            //        Console.WriteLine("The number with its appropriate two letter ending is: " + Number + "rd");
            //    }
            //    if (Number > 3)
            //    {
            //        Console.WriteLine("The number with its appropriate two letter ending is: " + Number + "th");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("You did not enter a number between 1 and 10!!!!");
            //}

            // Assignment 2-3

            //Console.Write("Please enter a value for A: ");
            //int A = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please enter a value for B, that is not the same as A: ");
            //int B = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Please enter a value for C, that is not the same as A or B: ");
            //int C = Convert.ToInt32(Console.ReadLine());

            //if (A == B || A == C || B == C)
            //{
            //    Console.WriteLine("You entered duplicate values, please close the window and try again.");
            //}
            //else if (A > B && A > C)
            //{
            //    if (B > C)
            //    {
            //        Console.WriteLine("The middle value is: " + B);
            //    }
            //    else
            //    {
            //        Console.WriteLine("The middle value is: " + C);
            //    }
            //}
            //else if (B > A && B > C)
            //{
            //    if (A > C)
            //    {
            //        Console.WriteLine("The middle value is: " + A);
            //    }
            //    else
            //    {
            //        Console.WriteLine("The middle value is: " + C);
            //    }
            //}
            //else if (C > A && C > B)
            //{
            //    if (A > B)
            //    {
            //        Console.WriteLine("The middle value is: " + A);
            //    }
            //    else
            //    {
            //        Console.WriteLine("The middle value is: " + B);
            //    }
            //}

            //Assignment 2-4

            //Console.Write("please enter a value for A: ");
            //int A = Convert.ToInt32(Console.ReadLine());

            //Console.Write("please enter a value for B: ");
            //int B = Convert.ToInt32(Console.ReadLine());

            //Console.Write("please enter a value for C: ");
            //int C = Convert.ToInt32(Console.ReadLine());

            //Console.Write("please enter a value for D: ");
            //int D = Convert.ToInt32(Console.ReadLine());

            //Console.Write("please enter a value for E: ");
            //int E = Convert.ToInt32(Console.ReadLine());

            //if (A <= B && A <= C && A <= D && A <= E)
            //{
            //    Console.WriteLine(A + " is the lowest value.");
            //}
            //else if (B <= A && B <= C && B <= D && B <= E)
            //{
            //    Console.WriteLine(B + " is the lowest value.");
            //}
            //else if (C <= B && C <= A && C <= D && C <= E)
            //{
            //    Console.WriteLine(C + " is the lowest value.");
            //}
            //else if (D <= B && D <= C && D <= A && D <= E)
            //{
            //    Console.WriteLine(D + " is the lowest value.");
            //}
            //else if (E <= B && E <= C && E <= D && E <= A)
            //{
            //    Console.WriteLine(E + " is the lowest value.");
            //}

            //Assignment 2-5

            //Console.Write("please enter Score 1: ");
            //int Score1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("please enter Score 1: ");
            //int Score2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("please enter Score 1: ");
            //int Score3 = Convert.ToInt32(Console.ReadLine());

            //int testAverage = (Score1 + Score2 + Score3) / 3;

            //Console.WriteLine("The average score is: " + testAverage);

            //if (testAverage < 100 && testAverage >= 90)
            //{
            //    Console.WriteLine("This makes the average grade of these scores an A.");
            //}
            //else if (testAverage < 89.999 && testAverage >= 80)
            //{
            //    Console.WriteLine("This makes the average grade of these scores a B.");
            //}
            //else if (testAverage < 79.999 && testAverage >= 70)
            //{
            //    Console.WriteLine("This makes the average grade of these scores a C.");
            //}
            //else if (testAverage < 69.999 && testAverage >= 60)
            //{
            //    Console.WriteLine("This makes the average grade of these scores a D.");
            //}
            //else if (testAverage < 59.999)
            //{
            //    Console.WriteLine("This makes the average grade of these scores an F.");
            //}

            //Assignment 2-6

            //Console.Write("Please enter a number between 1 and 1000: ");
            //int Number = Convert.ToInt32(Console.ReadLine());
            //int Mod1 = Number % 10;
            //int Mod0 = Number % 100;

            //if (Number > 1000 || Number <= 0)
            //{
            //    Console.WriteLine("You failed to enter a number between 1 and 1000!!!");
            //    Console.WriteLine("Please close the window and try again.");
            //}
            //else if (Mod1 > 3 || Mod1 == 0 || Mod0 == 11 || Mod0 == 12 || Mod0 == 13)
            //{
            //    Console.WriteLine("The value with its appropriate two-letter ending is: " + Number + "th");
            //}
            //else if (Mod1 == 1)
            //{
            //    Console.WriteLine("The value with its appropriate two-letter ending is: " + Number + "st");
            //}
            //else if (Mod1 == 2)
            //{
            //    Console.WriteLine("The value with its appropriate two-letter ending is: " + Number + "nd");
            //}
            //else if (Mod1 == 3)
            //{
            //    Console.WriteLine("The value with its appropriate two-letter ending is: " + Number + "rd");
            //}

            //Assignment 2-7

            //Console.Write("Please input the Rectangles Width: ");
            //float RW = Convert.ToSingle(Console.ReadLine());

            //Console.Write("Please input the Rectangles Height: ");
            //float RH = Convert.ToSingle(Console.ReadLine());

            //Console.Write("Please input the Squares Side: ");
            //float SS = Convert.ToSingle(Console.ReadLine());

            //float rectArea = RW * RH;
            //float squArea = SS * SS;

            //if (squArea > rectArea)
            //{
            //    Console.WriteLine("The object with the greatest area is the square.");
            //}
            //if (rectArea > squArea)
            //{
            //    Console.WriteLine("The Object with the greatest area is the rectangle.");
            //}
            //if (rectArea == squArea)
            //{
            //    Console.WriteLine("The rectangle and square have the same area.");
            //}
            //if (RH < SS && RW < SS)
            //{
            //    Console.WriteLine("The rectangle fits inside the square.");
            //}
            //else if (SS < RH && SS < RW)
            //{
            //    Console.WriteLine("The square fits inside the rectangle.");
            //}
            //else if (RH >= SS && RW >= SS)
            //{
            //    Console.WriteLine("Neither shape fits inside the other.");
            //}
            //else if (RH <= SS || RW <= SS)
            //{
            //    Console.WriteLine("Neither shape fits inside the other.");
            //}

            Console.ReadKey();
        }
    }
}
