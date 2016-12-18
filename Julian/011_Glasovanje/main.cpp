#include <iostream>
#include <fstream>

using namespace std;

int main()
{
    enum {nijeZaokruzio, hhdz, hps, sph, phs, hts, abs, acdc, izaZadnjeg};

    int kandidati[izaZadnjeg];
    for(int i = 0; i < izaZadnjeg; i++)
        kandidati[i] = 0;

    const int brojGlasaca = 100;
    int* glasaci[brojGlasaca];
    for(int i = 0; i < brojGlasaca; i++)
        glasaci[i] = nullptr;

    ifstream tok("/home/davor/Code/CPP/Julijan/011_Glasovanje/GlasackaLista.txt");
    int redniBroj;
    int glasovaoZa;
    while(tok >> redniBroj >> glasovaoZa) {
        if(glasaci[redniBroj] != nullptr) {
            cout << "Dvostruki glasački listić za " << redniBroj << endl;
            return 1;
        }
        if(glasovaoZa > izaZadnjeg) {
            cout << "Neispravan glas za " << redniBroj << endl;
            return 2;
        }
        if(glasovaoZa > nijeZaokruzio) {
            glasaci[redniBroj] = &kandidati[glasovaoZa];
            ++kandidati[glasovaoZa];
        }
    }

    for(int i = 1; i < izaZadnjeg; i++)
        cout << "Kandidat pod brojem " << i << " skupio je " << kandidati[i] << " glasova" << endl;

    return 0;
}
