#include <iostream>

using namespace std;

template <class T>
    inline T Kvadrat(T x) {
        return x * x;
    }

int main()
{
    float f = 1.2;
    int i = 9;
    double d = 3.14159;

    cout << Kvadrat(f) << endl;
    cout << Kvadrat(i) << endl;
    cout << Kvadrat(d) << endl;
    cout << Kvadrat(1.4) << endl;

    return 0;
}
