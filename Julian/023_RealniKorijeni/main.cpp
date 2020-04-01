#include <iostream>
#include <cmath>

using namespace std;

int RealnihKorijena(double a, double b, double c, double& korijen1, double& korijen2) {
    double diskriminanta = b * b - 4 * a * c;
    if (diskriminanta < 0)
        return 0;
    if (diskriminanta == 0) {
        korijen1 = korijen2 = -b /2 / a;
        return 1;
    }
    korijen1 = (-b - sqrt(diskriminanta)) / 2 / a;
    korijen2 = (-b + sqrt(diskriminanta)) / 2 / a;
    return 2;
}


int main()
{
    double kor1, kor2;
    if (RealnihKorijena(1, 3, 2, kor1, kor2) > 0) {
        cout << "Prvi korijen: " << kor1 << endl;
        cout << "Drugi korijen: " << kor2 << endl;
    }
    else
        cout << "Nema realnih korijena" << endl;

    return 0;
}
