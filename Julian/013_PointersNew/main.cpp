#include <iostream>

using namespace std;

int main()
{
    double* pokDouble = new double(100.);
    cout << pokDouble << "\t" << *pokDouble << endl;
    delete pokDouble;
    cout << pokDouble << "\t" << *pokDouble << endl;

    int* pokInt = new int;
    cout << pokInt << "\t" << *pokInt << endl;
    cout << pokDouble << "\t" << *pokDouble << endl;
    *pokInt = 100;
    cout << pokInt << "\t" << *pokInt << endl;
    cout << pokDouble << "\t" << *pokDouble << endl;

    return 0;
}
