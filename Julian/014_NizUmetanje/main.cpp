#include <iostream>
using namespace std;

int main() {
    cout << "Test niza" << endl;
    int brClanova = 9;
    int niz[10] = {10, 20, 30, 40, 50, 60, 70, 80, 90};
    int* odrediste = niz + brClanova;
    int novi = 15;
    while (*(--odrediste) > novi) {
        if (odrediste <  niz) break;
        *(odrediste + 1) = *odrediste;
    }
    *(odrediste + 1) = novi;
    ++brClanova;

    for (int i = 0; i < brClanova; i++) {
        cout << *(niz + i) << " ";
    }
    cout << endl << "Done." << endl;

    return 0;
}