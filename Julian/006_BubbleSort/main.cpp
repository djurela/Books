#include <iostream>
#include <fstream>

using namespace std;

// Bubble sort
int main()
{
    const int nmax = 100;
    double brojevi[nmax];
    ifstream tok("/home/davor/git/hub/Books/Julian/006_BubbleSort/Brojevi.txt");
    if(!tok) {
        cerr << "Nemogu otvoriti datoteku." << endl;
        return 1;
    }

    int n = 0;
    double broj;
    while(tok >> broj) {
        if(n >= nmax) {
            cerr << "Previše podataka." << endl;
            return 2;
        }
        brojevi[n++] = broj;
    }
    if(n <= 0) {
        cerr << "Nema podataka." << endl;
        return 3;
    }

    for(int i = n - 1; i > 0; i--) {
        bool zamjena = false;
        for(int j = 0; j < i; j++) {
            if(brojevi[j] > brojevi[j + 1]) {
                double privremeni = brojevi[j + 1];
                brojevi[j + 1] = brojevi[j];
                brojevi[j] = privremeni;
                zamjena = true;
            }
        }
        if(!zamjena) break;
    }

    cout << "Brojevi složeni po veličini:" << endl;
    for(int i = 0; i < n; i++)
        cout << brojevi[i] << " ";
    cout << endl;
}
