#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    ifstream tok("/home/davor/git/hub/Books/Julian/005_CitanjeIzDatoteke/Brojevi.txt");
    //ifstream tok("Brojevi.txt");
    cout << "Sadržaj datoteke" << endl << endl;

    double broj;
    while((tok >> broj) != 0)
        cout << broj << endl;

    /*
    double broj;
    for(tok >> broj; broj != 0; tok >> broj)
        cout << broj << endl;
    */

    return 0;
}
