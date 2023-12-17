#include <iostream>

using namespace std;

int main()
{

    int massive[5][5];

    srand(time(0));
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
            massive[i][j] = rand() % 61 - 30;
    }

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
            cout << massive[i][j] << "\t";

        cout << endl;
    }

    int product = 1;
    for (int i = 0; i < 5; i++)
    {
        product *= massive[i][5 - 1 - i];
    }
    cout << "Произведение элементов побочной диагонали: " << product << endl;

    int schetchick = 0;

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < i; j++)
        {
            if (massive[i][j] > 0)
                schetchick++;
        }
    }

    cout << "Количество положительных чисел , ниже главной диагонали " << schetchick << endl;

    int MinimalMassive[5];
    int minimal;
    for (int j = 0; j < 5; j++)
    {
        minimal = 0;
        for (int i = 0; i < 5; i++)
        {
            if (massive[minimal][j] > massive[i][j])
            {
                minimal = i;
            }
        }
        MinimalMassive[j] = massive[minimal][j];
    }

    cout << "Минимальные элементы в каждом стобце:" << endl;
    for (int i = 0; i < 5; i++)
    {
        cout << i + 1 << ") " << MinimalMassive[i] << ";  ";
    }
}
