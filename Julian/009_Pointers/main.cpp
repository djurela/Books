#include <iostream>

using namespace std;

int main()
{
    int i = 1;
    int j = 10;
    int* p = &j;
    *p *= *p;
    i = i + j;
    p = &i;

    cout << p << endl;
    cout << i << endl << j << endl << *p <<endl;
    cout << p << endl;

    cout << sizeof(int*) << endl;
    cout << sizeof(float*) << endl;
    double* xyz;
    cout << sizeof(xyz) << endl;

    return 0;
}
