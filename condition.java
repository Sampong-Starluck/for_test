import java.util.*;

/**
 * condition
 */
// public class condition {

//     // public static void main(String[] args) {
//     //     Scanner in = new Scanner(System.in);
//     //     int num;
//     //     System.out.print("Enter the number: ");
//     //     num = in.nextInt();
//     //     if (num >= 0) {
//     //         System.out.print("This number is positive.");
//     //     } else {
//     //         System.out.print("This number is negative.");
//     //     }
//     // }

// }

/**
 * condition
 */
//public class condition {

// public static void main(String[] args) {
//     int a, b, c;
//     float delta;
//     Scanner in = new Scanner(System.in);
//     System.out.print("Enter the number for the quatric equation:\n");
//     System.out.print("Enter the number for a: ");
//     a = in.nextInt();
//     System.out.print("Enter the number for b: ");
//     b = in.nextInt();
//     System.out.print("Enter the number for c: ");
//     c = in.nextInt();
//     delta = (b * b) - (4 * a * c);
//     if (delta > 0) {
//         System.out.print("There are 2 differents roots: \n");
//         System.out.print(((-b) - Math.sqrt(delta)) / (2 * a) + ",");
//         System.out.print(((-b) + Math.sqrt(delta)) / (2 * a));
//     }else if (delta == 0) {
//         System.out.print("There is only 1 root: \n");
//         System.out.print((-b)/(2*a));
//     } else {
//         System.out.print("The roots are negative number: \n");
//         System.out.print(((-b) / (2 * a) + "+ i" + (Math.sqrt(Math.abs(delta))) / (2 * a))+"\n");
//         System.out.print(((-b) / (2 * a) + "- i" + (Math.sqrt(Math.abs(delta))) / (2 * a)));
//     }
// }

//}

/**
 * condition
 */
// public class condition {

//     // public static void main(String[] args) {
//     //     Scanner in = new Scanner(System.in);
//     //     int num, n, sum = 0;
//     //     System.out.print("Enter the amount that will be input: ");
//     //     n = in.nextInt();
//     //     for (int i = 0; i < n; i++) {
//     //         System.out.print("Enter the number: ");
//     //         num = in.nextInt();
//     //         sum += num;
//     //     }
//     //     System.out.print("The total summation is "+ sum);
//     // }
// }

// public class condition{

//     public static void main(String[] args) {
//         Scanner in = new Scanner(System.in);
//         int num,sum = 0;
//         System.out.print("Enter the number: ");
//         num = in.nextInt();
//         for(int i = 1; i <= num; i++)
//         {
//             sum += i;
//         }
//         System.out.print("The summation from 1 to " + num + " is equal to " + sum);
//     }
// }

// /**
//  * condition
//  */
// public class condition {

//     public static void main(String[] args) {
//         Scanner in = new Scanner(System.in);
//         int num;
//         System.out.print("Enter the number: ");
//         num = in.nextInt();
//         for(int i = 1; i <= num ;i++){
//             System.out.print("Number is " + i + " and the cube of " + i + " is " + (i * i * i)+"\n");
//         }
//     }
// }

/**
 * condition
 */
// public class condition {

//     public static void main(String[] args) {
//         Scanner in = new Scanner(System.in);
//         int age;
//         System.out.print("Enter your age: ");
//         age = in.nextInt();
//         if(age >= 18){
//             System.out.print("You are allow to vote.");
//         }else{
//             System.out.print("You are not allow to vote.");
//         }
//     }
// }

/**
 * condition
 */
public class condition {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String alp;
        System.out.print("\nEnter the charracter or number: ");
        alp = in.next();
        if (alp.charAt(0) >= 48 && alp.charAt(0) <= 57) {
            System.out.print(alp + " is a number.\n");
        } else if (alp.charAt(0) >= 65 && alp.charAt(0) <= 90) {
            if (alp.charAt(0) == 'A' || alp.charAt(0) == 'E' || alp.charAt(0) == 'I' || alp.charAt(0) == 'O'
                    || alp.charAt(0) == 'U') {
                System.out.print(alp + " is a vowel in uppercase.\n");
            } else {
                System.out.print(alp + " is a consonant in uppercase.\n");
            }
        } else if (alp.charAt(0) >= 97 && alp.charAt(0) <= 122) {
            if (alp.charAt(0) == 'a' || alp.charAt(0) == 'e' || alp.charAt(0) == 'i' || alp.charAt(0) == 'o'
                    || alp.charAt(0) == 'u') {
                System.out.print(alp + " is a vowel in lowercase.\n");
            } else {
                System.out.print(alp + " is a consonant in lowercase.\n");
            }
        } else {
            System.out.print(alp + " is a sysmbol.\n");
        }
    }
}

// /**
//  * condition
//  */
// public class condition {

//     public static void main(String[] args) {
//         int num1,num2,n,i = 1;
//         Scanner in = new Scanner(System.in);
//         while (i != 0) {
//             System.out.print("\n\n1.Addition \n2.Subtraction \n3.Multiplication \n4.Division \n5.Exit.");
//             System.out.print("\nEnter your option: ");
//             n = in.nextInt();
//             if (n >= 1 && n <= 4) {
//                 System.out.print("Enter the first number: ");
//                 num1 = in.nextInt();
//                 System.out.print("Enter the second number: ");
//                 num2 = in.nextInt();
//                 switch (n) {
//                     case 1:
//                         System.out.print("The Summation of "+ num1 +" and " + num2 + " = " + (num1 + num2));
//                         break;
//                     case 2:
//                         System.out.print("The Subtaction of " + num1 + " and " + num2 + " = " + (num1 - num2));
//                         break;
//                     case 3:
//                         System.out.print("The Multiplication of " + num1 + " and " + num2 + " = " + (num1 * num2));
//                         break;
//                     case 4:
//                         System.out.print("The Division of " + num1 + " and " + num2 + " = " + (num1 / num2));
//                         System.out.print(" The remain is " + (num1 % num2));
//                         break;
//                     default:
//                         break;
//                 }
//             } else if (n == 5) {
//                 System.out.print("The system is being close........ \n\n");
//                 break;
//             } else {
//                 System.out.print("Your option is incorrect !!!!!!");
//             }
//         }
//     }
// }

// /**
//  * condition
//  */
// public class condition {

//     public static void main(String[] args) {
//         int num, sum = 0;
//         Scanner in = new Scanner(System.in);
//         System.out.print("Enter the number: ");
//         num = in.nextInt();
//         for (int i = 1; i <= num; i++) {
//             for (int j = 1; j <= 10; j++) {
//                 System.out.print(i + " * " + j + " = " + (i * j) + "\n");
//             }
//             System.out.print("\n");
//         }
//     }
// }

// /**
//  * condition
//  */
// public class condition {

//     public static void main(String[] args) {
//         int num, sum1 = 0, sum2 = 0;
//         Scanner in = new Scanner(System.in);
//         System.out.print("Enter the final numeber: ");
//         num = in.nextInt();
//         for (int i = 0; i <= num; i++) {
//             if (i % 2 == 0) {
//                 sum1 += i;
//             } else {
//                 sum2 += i;
//             }
//         }
//         System.out.print("The summation of odd number from 1 to " + num + " is " + sum2 + "\n");
//         System.out.print("The summation of even number from 1 to " + num + " is " + sum1 + "\n");
//     }
// }

// /**
//  * condition
//  */
// public class condition {
//     public static int sum(int a, int b,int c) {
//         if (a == b && b == c) {
//             return (a + b + c) * 3;
//         } else {
//             return (a + b + c);
//         }
//     }
//     public static void main(String[] args) {
//         int a,  b , c;
//         Scanner in = new Scanner(System.in);
//         System.out.print("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
//         System.out.print("~~Enter the three numbers to see the result:~~\n");
//         System.out.print("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
//         System.out.print("\n");
//         System.out.print("Enter the number for a: ");
//         a = in.nextInt();
//         System.out.print("Enter the number for b: ");
//         b = in.nextInt();
//         System.out.print("Enter the number for c: ");
//         c = in.nextInt();
//         System.out.print("The result is " + sum(a, b, c));
//     }
// }