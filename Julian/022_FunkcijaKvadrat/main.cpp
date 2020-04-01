#include <iostream>
#include <iomanip>
using namespace std;

double Kvadrat(double);

int main() {
    for (int i = 0; i <= 10; ++i)
        cout << setw(5) << i << setw(5)<< "Kvadrat(i)" << endl;
    return 0;
}

double Kvadrat(double x) {
    return x * x;
}
