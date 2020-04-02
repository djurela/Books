#include <iostream>

using namespace std;

int DuljinaNiza(const char* niz) {
    int i = 0;
    while (*(niz + i) != 0)
        ++i;
    return i;
}

char* Preslikaj(char* odrediste, const char* izvoriste) {
    //delete [] odrediste;
    int duljina = DuljinaNiza(izvoriste);
    odrediste = new char[duljina + 1];
    do {
        odrediste[duljina] = izvoriste[duljina];
    } while (--duljina >= 0);
    return odrediste;
}

bool PromjeniZaporku(char*& zaporka) {
    char noviUnos[40];
    cout << "Upiši novu zaporku: ";
    cin >> noviUnos;
    zaporka = Preslikaj(zaporka, noviUnos);
    return true;
}

int main()
{
    char* zaporka = "tesna";
    cout << "Stara zaporka: " << zaporka << endl;
    if (PromjeniZaporku(zaporka))
        cout << "Nova zaporka: " << zaporka << endl;
    delete [] zaporka;
    return 0;
}
