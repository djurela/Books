#include <iostream>

using namespace std;

int main()
{
    int a = 0x0025;
    int maska = 0x000f;

    cout << "Original: " << a << ", hex: " << hex << a << endl;
    cout << (a & maska) << endl;
    cout << (a | maska) << endl;
    cout << (a ^ maska) << endl;
    cout << (a ^ maska ^ maska) << endl;
    cout << endl;

    a = 20;
    cout << dec;
    cout << a << endl;
    cout << (a << 1) << endl;
    cout << (a >> 2) << endl;
    cout << endl;

    cout << "sizeof int: " << sizeof(a) << endl;
    float b;
    cout << "sizeof float: " << sizeof(b) << endl;
    cout << sizeof("Testni string.") << endl;

    return 0;
}
