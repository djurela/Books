#include <iostream>

using namespace std;

int DuljinaNiza(const char* niz) {
    int i = 0;
    while (*(niz + i) != 0)
        ++i;
    return i;
}

char* DolijepiLjepse(char* tekst, const char* dodatak) {
    int novaDuljina = DuljinaNiza(dodatak) + 1;
    if (tekst != 0)
        novaDuljina += DuljinaNiza(tekst);
    char* noviTekst = new char[novaDuljina];
    char* odrediste = noviTekst;
    if (tekst != 0) {
        const char* polaziste = tekst;
        while (*polaziste != 0)
            *odrediste++ = *polaziste++;
    }
    while (*dodatak != 0)
        *odrediste++ = *dodatak++;
    *odrediste = '\0';
    delete [] tekst;
    return noviTekst;
}

char* Dolijepi(char* tekst, const char* dodatak) {
    char* odrediste = tekst;
    while (*odrediste != 0)
        ++odrediste;
    while (*dodatak != 0)
        *odrediste++ = *dodatak++;
    *odrediste = '\0';
    return tekst;
}

int main()
{
    /*
    char pozdrav[40] = "Dobar dan";
    Dolijepi(pozdrav, " dobri čovječe");
    cout << pozdrav << endl;
    return 0; */
    char* pozdrav = 0;
    pozdrav = DolijepiLjepse(pozdrav, "Dobar dan");
    pozdrav = DolijepiLjepse(pozdrav, " dobri čovječe");
    cout << pozdrav << endl;
    delete pozdrav;
    return 0;
}
