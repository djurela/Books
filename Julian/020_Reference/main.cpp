#include <iostream>

using namespace std;

int main()
{
    int i = 5;
    int& iref = i;
    cout << i << '\t' << iref << endl;
    i = 15;
    cout << i << '\t' << iref << endl;
    iref = 555;
    cout << i << '\t' << iref << endl;

    const double korijen2 = 1.41;
    const double& ref_kor2 = korijen2;

    double x;
    const double& ref_x = x;

    x = 7.5;
    cout << x << '\t' << ref_x << endl;
    x = 9.5;
    cout << x << '\t' << ref_x << endl;
    //ref_x = 7.7;

    return 0;
}
