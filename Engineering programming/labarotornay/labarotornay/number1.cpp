
#include <iostream>

using namespace std;

int main()
{

	double x, y;
	cout << "Введите x:"; 
	cin >> x; 
	cout << "Введите y:"; 
	cin >> y; 

	double s = 0;
	

	if (y > 2*x)
	{
		s = tan(x)+pow(x,2);
	}
	else if (y < 2*x)
	{
		s = pow(abs(x+y),3); 
	}
	else
	{
		s = cbrt(x) * sin(x); 
	}

	cout << "Ответ: s = " << s << endl; 

}
