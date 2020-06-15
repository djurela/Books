#include <iostream>
#include <cassert>
#include <math.h>

using namespace std;

double kvadratni_korijen(double broj) {
    assert(broj > 0);
    double rezultat = sqrt(broj);
    printf("%lf\n", rezultat * rezultat);
    assert((rezultat * rezultat) - broj < 0.00000000001);
    return rezultat;
}

int main()
{
    cout << "Upiši broj" << endl;
    double broj;
    cin >> broj;
    cout << "Kvadratni korijen od " << broj << " je " << kvadratni_korijen(broj) << endl;

    return 0;
}
