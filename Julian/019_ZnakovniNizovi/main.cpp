#include <iostream>
#include <string>

using namespace std;

int main()
{
    cout << "Test dijakritika: čćšđž ČĆŠĐŽ" << endl;

    wchar_t w  = L'л';
    wchar_t ru[] = L"Привет";
    wcout << "Wide character value:: " << w << endl ;
    cout << "Size of the wide char is:: " << sizeof(w) << endl;
    wcout << ru << endl;

    char padobran[] = "Faust Vrančić";
    char minijature[] = "Julije Klović";

    padobran[0] = 'f';
    //padobran[15] = '&';
    for (int i = 0; i < 20; i++) {
        char znak = padobran[i];
        cout << znak << "\t" << static_cast<int>(static_cast<unsigned char>(znak)) << endl;
    }

    cout << padobran << "\t" << sizeof(padobran) << endl;
    cout << minijature << "\t"<< sizeof(minijature) << endl;

    const char* bjarne = "C++";
    cout << bjarne << endl;
    cout << bjarne[1] << endl;
    //bjarne[2] = '-';

    const wchar_t* duplerica = L"abc";
    wcout << "Duplerica: " << duplerica << endl;

    char* dani[] = {"nedjelja", "ponedjeljak", "utorak", "srijeda", "četvrtak", "petak", "subota"};
    for (int i = 0; i < 7; i++)
        cout << dani[i] << endl;

    std::string ime = "Marin";
    std::string prezime = "Getaldić";
    cout << ime + " " + prezime << endl;

    return 0;
}
