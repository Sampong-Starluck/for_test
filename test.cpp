#include <iostream>
#include <stdlib.h>
#include <conio.h>

using namespace std;

int main()
{
    char alp;
    cout << "Enter the character or number: ";
    cin >> alp;
    if (alp >= 48 && alp <= 57)
    {
        cout << alp << " is a number." << endl;
    }
    else if (alp >= 65 && alp <= 90)
    {
        if (alp == 'A' || alp=='E' || alp == 'I' || alp == 'O' || alp == 'U')
        {
            cout << alp << " is a vowel in uppercase." << endl;
        }
        else
        {
            cout << alp << " is a consonant in uppercase." << endl;
        }
    }
    else if(alp >= 97 && alp <= 122)
    {
        if (alp == 'a' || alp =='e' || alp == 'i' || alp == 'o' || alp == 'u')
        {
            cout << alp << " is a vowel in lowercase." << endl;
        }
        else
        {
            cout << alp << " is a consonant in lowercase." << endl;
        }
    }
    else
    {
        cout << alp << " is a symbol." << endl;
    }
}

// int fact(int);
// int main()
// {
//     int num;
//     cout << "Enter the number: ";
//     cin >> num;
//     cout << num << " factorial is " << fact(num) << endl;
// }
// int fact(int a)
// {
//     if (a > 1)
//     {
//         return fact(a - 1) * a;
//     }
//     else
//     {
//         return 1;
//     }
// }