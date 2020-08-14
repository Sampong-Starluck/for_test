using System;
using System.IO;

namespace c_
{
    class Program
    {
        //     static void Main(string[] args)
        //     {
        //         int n1, n2;
        //         Console.WriteLine("Enter the first number: ");
        //         n1 = int.Parse(Console.ReadLine());
        //         Console.Write("Enter the second number: ");
        //         n2 = int.Parse(Console.ReadLine());
        //         if (n1 == n2)
        //         {
        //             Console.WriteLine("These numbers are the same. ");
        //         }
        //         else
        //         {
        //             Console.WriteLine("These numbers are different from one another. ");
        //         }

        //     }
        // }
        // static void Main()
        // {
        //     int num;
        //     Console.WriteLine("Enter the number: ");
        //     num = int.Parse(Console.ReadLine());
        //     if (num % 2 == 0)
        //     {
        //         Console.WriteLine("{0} is even number.", num);
        //     }
        //     else
        //     {
        //         Console.WriteLine("{0} is odd number.", num);
        //     }
        // }

        // static void Main()
        // {
        //     int num;
        //     Console.WriteLine("Enter the number: ");
        //     num = int.Parse(Console.ReadLine());
        //     if (num > 0)
        //     {
        //         Console.WriteLine("This number is positive number.");
        //     }
        //     else if (num < 0)
        //     {
        //         Console.WriteLine("This number is negative number.");
        //     }
        //     else
        //     {
        //         Console.WriteLine("This number is neutral number(zero). ");
        //     }
        // }

        // static void Main()
        // {
        //     int height;
        //     Console.WriteLine("Enter your height in centimeter: ");
        //     height = int.Parse(Console.ReadLine());
        //     if (height <= 150)
        //     {
        //         Console.WriteLine("You are dwarf.");
        //     }
        //     else if (height > 150 && height <= 165 )
        //     {
        //         Console.WriteLine("You are normal people.");
        //     }
        //     else
        //     {
        //         Console.WriteLine("You are so tall");
        //     }
        // }

        // static void Main()
        // {
        //     int n1, n2, n3;
        //     Console.WriteLine("Enter the number: ");
        //     n1 = int.Parse(Console.ReadLine());
        //     Console.WriteLine("Enter the number: ");
        //     n2 = int.Parse(Console.ReadLine());
        //     Console.WriteLine("Enter the number: ");
        //     n3 = int.Parse(Console.ReadLine());

        //     if (n1 >= n2 && n1 >= n3)
        //     {
        //         Console.WriteLine("{0} is the biggest number.", n1);
        //     }
        //     else if (n2 >= n1 && n2 >= n3)
        //     {
        //         Console.WriteLine("{0} is the biggest number.", n2);
        //     }
        //     else if (n3 >= n1 && n3 >= n1)
        //     {
        //         Console.WriteLine("{0} is the bigges numnber.", n3);
        //     }
        // }

        // static void find_quadrant(int x, int y)
        // {
        //     if (x > 0 && y > 0)
        //     {
        //         Console.WriteLine("The coordinated of ({0},{1}) is in the first quadrant.", x, y);
        //     }
        //     else if (x < 0 && y > 0)
        //     {
        //         Console.WriteLine("The coordinated of ({0},{1}) is in the seond quadrant.", x, y);
        //     }
        //     else if (x < 0 && y < 0)
        //     {
        //         Console.WriteLine("The coordinated of ({0},{1}) is in the third quadrant.", x, y);
        //     }
        //     else if (x > 0 && y < 0)
        //     {
        //         Console.WriteLine("The coordinated of ({0},{1}) is in the fourth quadrant.", x, y);
        //     }
        //     else if (x == 0 && y == 0)
        //     {
        //         Console.WriteLine("The coordinated of ({0},{1}) is in the origin.", x, y);
        //     }
        // }
        // static void Main()
        // {
        //     int x, y;
        //     Console.WriteLine("Enter the coordinated X: ");
        //     x = int.Parse(Console.ReadLine());
        //     Console.WriteLine("Enter the coordinated Y: ");
        //     y = int.Parse(Console.ReadLine());

        //     find_quadrant(x, y);
        // }

        // static void Main()
        // {
        //     int num, i = 1, n;
        //     while (i != 0)
        //     {
        //         Console.WriteLine("Enter the number: ");
        //         num = int.Parse(Console.ReadLine());
        //         Console.WriteLine("1. Raise to the power");
        //         Console.WriteLine("2. Sum natural number.");
        //         Console.WriteLine("3. Sum square.");
        //         Console.WriteLine("4. Factorial.");
        //         Console.WriteLine("5. count digit.");
        //         Console.WriteLine("6. Exit");
        //         Console.WriteLine("Enter your option: ");
        //         n = int.Parse(Console.ReadLine());
        //         Console.WriteLine("\n");
        //         switch (n)
        //         {
        //             case 1:
        //                 int p;
        //                 Console.WriteLine("Enter the power: ");
        //                 p = int.Parse(Console.ReadLine());
        //                 Console.WriteLine("{0} raise to the power of {1} equal to {2}.\n", num, p, power(num, p));
        //                 break;
        //             case 2:
        //                 Console.WriteLine("The summtion from 1 to {0} is {1}.\n", num, sum_num(num));
        //                 break;
        //             case 3:
        //                 Console.WriteLine("The square summtion from 1 to {0} is {1}.\n", num, sum_square(num));
        //                 break;
        //             case 4:
        //                 Console.WriteLine("The factorial of {0} is {1}.\n", num, factorial(num));
        //                 break;
        //             case 5:
        //                 Console.WriteLine("{0} have {1} digit(s).\n", num, count_digit(num));
        //                 break;
        //             case 6:
        //                 Console.WriteLine("The program is being exit .....\n\n");
        //                 Environment.Exit(0);
        //                 break;
        //             default:
        //                 Console.WriteLine("Your input is invalid !!!");
        //                 break;
        //         }
        //     }
        // }
        // static long power(int num, int p)
        // {
        //     if (p != 0)
        //     {
        //         return (num * power(num, p - 1));
        //     }
        //     else
        //     {
        //         return 1;
        //     }
        // }
        // static int sum_num(int num)
        // {
        //     if (num != 0)
        //     {
        //         return (sum_num(num - 1) + num);
        //     }
        //     else
        //     {
        //         return 0;
        //     }
        // }
        // static int sum_square(int num)
        // {
        //     if (num != 1)
        //     {
        //         return (sum_square(num - 1) + (num * num));
        //     }
        //     else
        //     {
        //         return 1;
        //     }
        // }
        // static long factorial(int num)
        // {
        //     if (num == 1 || num == 0)
        //     {
        //         return 1;
        //     }
        //     else
        //     {
        //         return (factorial(num - 1) * num);
        //     }
        // }
        // static int count_digit(int num)
        // {
        //     int count = 0;
        //     if (num > 0)
        //     {
        //         count++;
        //         count_digit(num / 10);
        //     }
        //     return count;
        // }
    }
}
