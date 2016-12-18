#include <iostream>

using namespace std;

int main()
{
    int a[] = {10, 20, 30};
    int b[] = {40, 50, 60};
    int c[] = {70, 80};

    cout << b[-1] << " " << b[0] << endl;
    cout << b[3] << " " << b[2] << endl;

    int x[5] = {100, 101, 102, 103, 104};
    cout << "x: " << x << endl;
    cout << "&x: " << &x << endl;
    cout << "&x[0]: " << &x[0] << endl;
    cout << "(x + 1): " << x + 1 << endl;
    cout << "*(x + 1): " << *(x + 1) << endl;

    float f[3][4] = {{1.1F, 1.2F, 1.3F, 1.4F}, {2.1F, 2.2F, 2.3F, 2.4F}};
    cout << *f[0] << "\t" << *f[1] << endl;
    cout << &f[0] << "\t" << f[1] << endl;

    return 0;
}
