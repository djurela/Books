#include <iostream>

using namespace std;

int main()
{
    const double pi = 3.14;
    double const* pipok;
    pipok = &pi;
    cout << "PI: " << *pipok << endl;

    double const e = 2.71828;
    pipok = &e;
    cout << "pipok: " << *pipok << endl;

    double r = 23.4;
    pipok = &r;
    cout << "pipok: " << *pipok << endl;
    r = 24.3;
    //*pipok = 55.5; error

    double neki_broj = 1989.1005;
    double* const ne_mrdaj = &neki_broj;
    cout << "ne_mrdaj: " << *ne_mrdaj << endl;
    neki_broj = 2009.1009;
    cout << "ne_mrdaj: " << *ne_mrdaj << endl;
    double neki_broj_2 = 1889.1005;
    //ne_mrdaj = &neki_broj_2; error

    const double q = 1.62e-19;
    const double* const naboj_elektrona = &q;
    cout << "naboj elektrona: " << *naboj_elektrona << endl;

    const char* pok_konst;
    char* pok_promj;
    pok_konst = pok_promj;
    //pok_promj = pok_konst; error
    pok_promj = const_cast<char*>(pok_konst);

    return 0;
}
