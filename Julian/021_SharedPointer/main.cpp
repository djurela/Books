#include <iostream>
#include <memory>
using namespace std;

int main()
{
    shared_ptr<int> pametni_pok (new int(10));
    cout << pametni_pok << '\t' << *pametni_pok <<endl;

    shared_ptr<double> pok_1;
    {
        shared_ptr<double> pok_2 (new double(5.55));
        pok_1 = pok_2;
        cout << pok_1 << '\t' << *pok_1 <<endl;
    }
    cout << pok_1 << '\t' << *pok_1 <<endl;

    return 0;
}
