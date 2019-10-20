#include <iostream>
#include <fstream>

using namespace std;

// Bubble sort, pointer version
int main()
{
    const int nmax = 100;
    double brojevi[nmax];
    ifstream tok("/home/davor/git/hub/Books/Julian/010_BubbleSortPointers/Brojevi.txt");
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

    // Punjenje niza pointera
    double* poks[n];
    for(int i = 0; i < n; i++)
        poks[i] = &brojevi[i];

    // Sort
    for(int i = n - 1; i > 0; i--) {
        bool zamjena = false;
        for(int j = 0; j < i; j++) {
            if(*poks[j] > *poks[j + 1]) {
                double* privremeni = poks[j + 1];
                poks[j + 1] = poks[j];
                poks[j] = privremeni;
                zamjena = true;
            }
        }
        if(!zamjena) break;
    }

    cout << "Originalni niz:" << endl;
    for(int i = 0; i < n; i++)
        cout << brojevi[i] << " ";
    cout << endl;

    cout << "Sortirani niz:" << endl;
    for(int i = 0; i < n; i++)
        cout << *poks[i] << " ";
    cout << endl;
}
