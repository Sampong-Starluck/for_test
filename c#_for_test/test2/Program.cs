using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

namespace C__for_test
{
    class Program
    {
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

        // static void Main()
        // {
        //     int num, sum = 0;
        //     Console.WriteLine("Enter the number: ");
        //     num = Convert.ToInt32(Console.ReadLine());
        //     for (int i = 1; i <= num; i++)
        //     {
        //         sum += i;
        //     }
        //     Console.WriteLine("The summation from 1 to {0} equal to {1}.", num, sum);
        // }

        // static void Main()
        // {
        //     int num, sum = 0;
        //     for (int i = 1; i <= 10; i++)
        //     {
        //         Console.WriteLine("Number {0}: ", i );
        //         num = int.Parse(Console.ReadLine());
        //         sum += i;
        //     }
        //     Console.WriteLine("The result: the summation {0} and the average {1}.", sum, sum / 10);
        // }

        // static void Main()
        // {
        //     int num;
        //     Console.WriteLine("Enter the number: ");
        //     num = int.Parse(Console.ReadLine());
        //     for (int i = 1; i <= num; i++)
        //     {
        //         Console.WriteLine("Number is {0} and the cube of {1} is {2}", i, i, Math.Pow(i, 3));
        //     }
        // }

        // static void Main()
        // {
        //     int num;
        //     Console.WriteLine("Enter the number: ");
        //     num = int.Parse(Console.ReadLine());
        //     for (int i = 1; i <= 10; i++)
        //     {
        //         Console.WriteLine("{0} * {1} = {2}", num, i, (num * i));
        //     }
        // }
        // static void Main()
        // {
        //     char alp;
        //     int i;
        //     Console.WriteLine("Enter the character or number: ");
        //     alp = char.Parse(Console.ReadLine());
        //     i = alp;
        //     if (i >= 48 && i <= 57)
        //     {
        //         Console.WriteLine("{0} is a number.", alp);
        //     }
        //     else if (i >= 65 && i <= 90)
        //     {
        //         if (alp == 'A' || alp=='E' || alp == 'I' || alp == 'O' || alp == 'U')
        //         {
        //             Console.WriteLine("{0} is vowel in uppercase.", alp);
        //         }
        //         else
        //         {
        //             Console.WriteLine("{0} is consonant in uppercase.", alp);
        //         }
        //     }
        //     else if (i >= 97 && i <= 122)
        //     {
        //         if (alp == 'a' || alp == 'e' || alp == 'i' || alp == 'o' || alp == 'u')
        //         {
        //             Console.WriteLine("{0} is vowel in lowercase.", alp);
        //         }
        //         else
        //         {
        //             Console.WriteLine("{0} is consonant in lowercase.", alp);
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine("{0} is a symbol.",alp);
        //     }
        // }

        // static void Main()
        // {
        //     string name;
        //     int ID;
        //     double charge = 0, unit,grant,sur= 0,netamt = 0;
        //     Console.WriteLine("Enter the client's name: ");
        //     name = Console.ReadLine();
        //     Console.WriteLine("Enter the client's ID number: ");
        //     ID = int.Parse(Console.ReadLine());
        //     Console.WriteLine("Enter the unit that client have consume: ");
        //     unit = double.Parse(Console.ReadLine());
        //     if (unit < 200 )
        //     {
        //         charge = 1.20;
        //     }
        //     else if (unit >= 200 && unit < 400)
        //     {
        //         charge = 1.50;
        //     }
        //     else if (unit >= 400 && unit < 600)
        //     {
        //         charge = 1.80;
        //     }
        //     else if(unit >= 600)
        //     {
        //         charge = 2.00;
        //     }
        //     grant = unit * charge;
        //     if (unit > 300)
        //     {
        //         sur = (grant * 15) / 100;
        //         netamt = grant + sur;
        //     }
        //     else if (unit < 99)
        //     {
        //         netamt = 100;
        //     }
        //     Console.WriteLine("Customer's ID number and name: {0}    {1}.", ID,name);
        //     Console.WriteLine("Unit consomtion: {0}.", unit);
        //     Console.WriteLine("Extra charge: {0}.", charge);
        //     Console.WriteLine("Surcharge: {0}, and total: {1}.", sur,grant);
        //     Console.WriteLine("Grand total: {0}",netamt);
        // }

        // static void Main()
        // {
        //     int num1, num2, n;
        //     Console.WriteLine("Enter the first integer: ");
        //     num1 = int.Parse(Console.ReadLine());
        //     Console.WriteLine("Enter the second integer: ");
        //     num2 = int.Parse(Console.ReadLine());
        //     Console.WriteLine("1.Add");
        //     Console.WriteLine("2.Subtract");
        //     Console.WriteLine("3.Multiply");
        //     Console.WriteLine("4.Divide");
        //     Console.WriteLine("5.Exit");
        //     Console.WriteLine("Enter your option: ");
        //     n = int.Parse(Console.ReadLine());
        //     switch (n)
        //     {
        //         case 1:
        //             Console.WriteLine("The addition of {0} and {1} is: {2}", num1, num2, num1 + num2);
        //             break;
        //         case 2:
        //             Console.WriteLine("The subtraction of {0} and {1} is: {2}", num1, num2, num1 - num2);
        //             break;
        //         case 3:
        //             Console.WriteLine("The multiplication of {0} and {1} is: {2}", num1, num2, num1 * num2);
        //             break;
        //         case 4:
        //             Console.WriteLine("The sevision of {0} and {1} is: {2}", num1, num2, num1 / num2);
        //             Console.WriteLine("The modulus is {0}", num1 % num2);
        //             break;
        //         case 5:
        //             Environment.Exit(0);
        //             break;
        //         default:
        //             Console.WriteLine("Your input is invalid !!!!!");
        //             break;
        //     }
        // }

        // static void Main()
        // {
        //     int num;
        //     Console.WriteLine("Enter the number: ");
        //     num = int.Parse(Console.ReadLine());
        //     for (int i = 1; i <= num; i++)
        //     {
        //         for (int j = 1; j <= 10; j++)
        //         {
        //             Console.WriteLine("{0} * {1} = {2}", i, j, (i * j));
        //         }
        //         Console.WriteLine("\n");
        //     }
        // }

        // static void Main()
        // {
        //     int num, sum = 0;
        //     Console.WriteLine("Input the number: ");
        //     num = int.Parse(Console.ReadLine());
        //     for (int i = 1; i <= num; i++)
        //     {
        //         if (i % 2 == 0)
        //         {
        //             continue;
        //         }
        //         Console.WriteLine("{0} ", i);
        //         sum += i;
        //     }
        //     Console.WriteLine("The summation of odd number is {0}", sum);
        // }

        static void Main()
        {
            int num, sum = 0;
            Console.WriteLine("Enter the number: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i += 2)
            {
                Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine("The Summation is {0}.", sum);
        }
    }
}
