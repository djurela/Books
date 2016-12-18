#include <iostream>

using namespace std;

int main()
{
    int a = 100000;
    int b = 200000;
    long c = a * b;

    cout << c << endl;
    cout << a * b << endl;
    cout << static_cast<float>(a) * b << endl;
    cout << ((float) a) * b << endl;
    cout << static_cast<long>(a) * b << endl;
    cout << static_cast<long>(a * b) << endl;
    cout << a * static_cast<long>(b) << endl;

    cout << static_cast<long>(10) << endl;

    float d = 1.;
    cout << d << endl;

    return 0;
}
