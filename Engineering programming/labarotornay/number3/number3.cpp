#include <iostream>

using namespace std;

char MoreEqualsLess(int a, int b)
{
    if (a > b)
    {
        return '>';
    }
    else if (a < b)
    {
        return '<';
    }
    else
    {
        return '=';
    }
}

int Minimum(int a, int b) 
{
    int min = a;

    if (b < min) {
        min = b;
    }

    return min;
}

int Minimum(int a, int b, int c)  
{
    int min = a;

    if (b < min) {
        min = b;
    }

    if (c < min) {
        min = c;
    }
    return min;
}

int main()
{
    int num1 = 0, num2 = 0, num3 = 0;

    cout << "Введите первое целое число: ";
    cin >> num1;

    cout << "Введите второе целое число: ";
    cin >> num2;

    char result = MoreEqualsLess(num1, num2);

    cout << "Результат: " << num1 << " " << result << " " << num2 << endl;

    cout << "Введите первое целое число: "; 
    cin >> num1;

    cout << "Введите второе целое число: ";
    cin >> num2;

    cout << "Введите третье целое число: ";
    cin >> num3;

    int minOfTwo = Minimum(num1, num2);
    int minOfThree = Minimum(num1, num2, num3);

    cout << minOfTwo << " - минимальное число, среди " << num1 << " и " << num2 << endl;
    cout << minOfThree << " - минимальное число, среди " << num1 << " , " << num2 <<  " и " << num3 << endl;

    return 0;
}
