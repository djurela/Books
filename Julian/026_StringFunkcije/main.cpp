#include <iostream>
#include <cstring>
#include <clocale>
using namespace std;

int main()
{
    const char* prvi = "mali";
    const char* drugi = "princ";
    char* praznina = " ";
    int ukupna_duljina = strlen(prvi) + strlen(praznina) + strlen(drugi);
    char* oba = new char[ukupna_duljina + 1];
    strcpy(oba, prvi);
    strcat(oba, praznina);
    strcat(oba, drugi);
    int usporedba = strcmp(oba, prvi);
    if (usporedba) {
        if (usporedba > 0)
            cout << "\"" << oba << "\" je veći of \"" << prvi << "\"" << endl;
        else
            cout << "\"" << oba << "\" je manj of \"" << prvi << "\"" << endl;
    }
    else
        cout << "\"" << prvi << "\" i \"" << oba << "\" su jednaki" << endl;

    char deponij[25];
    strcpy(deponij, "kanal");
    strcpy(deponij + 3, "tata u F-duru");
    cout << deponij << endl;

    const char* knjiski = "tata";
    const char* naski = "ćaća";
    cout << "strcmp: " << strcmp(knjiski, naski) << endl;
    setlocale(LC_ALL, "Croatian");
    cout << "strcoll: " << strcoll(knjiski, naski) << endl;

    return 0;
}
