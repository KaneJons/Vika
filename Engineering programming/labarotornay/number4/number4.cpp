#include <iostream>

using namespace std;

int main()
{
	int massive[10];
	srand(time(0)); 
	for (int i = 0; i < 10; i++)
	{
		massive[i] = rand() % 41 - 20;
	}

	cout << "Сгенерированный массив: ";
	for (int i = 0; i < 10; ++i) {
		cout << massive[i] << " ";
	}

	cout << endl;
	// 1)
	long long product = 1;
	for (int i = 0; i < 10; ++i) {
		product *= massive[i];
	}
	cout << "Произведение всех элементов: " << product << endl;

	// 2)
	int schet = 0;
	for (int i = 0; i < 10; ++i) {
		if (massive[i] % 2 != 0) {
			schet++;
		}
	}

	cout << "Количество нечетных чисел: " << schet << endl;

	// 3)
	schet = 0;
	for (int i = 0; i < 10; i++)
	{
		if (massive[i] % 3 == 0)
			schet++;
	}

	cout << "Количнство чисел, кратных трем: " << schet << endl;

	// 4)

	int a = 0;
	for (int i = 1; i < 10; i++)
	{
		if (massive[i - 1] < massive[i])
		{
			a++;
			break;
		}
	}
	if (a==0)
		cout << "Элементы массива упорядочены" << endl;
	else
		cout << "Элементы массива не упорядочены" << endl;

	// 5) отриц, ноль, положительны

	int flag;

	for (int i = 0; i < 10; i++)
	{
		if (massive[i] <= 0)
		{
			for (int j = 0; j < i; j++)
			{
				if (massive[j] > 0)
				{
					flag = massive[i];
					massive[i] = massive[j];
					massive[j] = flag;
				}
			}
		}
	}

	cout << "Отсортированные элементы массивов: ";

	for (int i = 0; i < 10; i++)
	{
		cout << massive[i] << " ";
	}

}
