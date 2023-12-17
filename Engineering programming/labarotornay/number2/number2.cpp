#include <iostream>

using namespace std;

int main()
{
    double a = 0.1;
    double b = 1.2;
    double h = 0.1;

    cout << "x\t|\ty(x)" << endl<<" \t|"<< endl; 
    
    for (double x = a; x <= b; x += h) {
        double y = 0.0;

        for (int i = 1; i <= 20; i++) {
            y += pow(1+x,i-1) / abs(pow(sin(x),i));
        }

        cout << x << "\t|\t" << y << endl;
    }
}
