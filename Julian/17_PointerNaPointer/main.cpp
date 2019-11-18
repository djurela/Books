#include <iostream>

using namespace std;

int main()
{
    double** dvaPolja;
    int redaka, stupaca;

    cout << "Broj redaka: ";
    cin >> redaka;
    dvaPolja = new double*[redaka];
    for (int i = 0; i < redaka; i++) {
        cout << "Broj članova u " << (i + 1) <<". retku: ";
        cin >> stupaca;
        dvaPolja[i] = new double[stupaca + 1];
        dvaPolja[i][0] = stupaca;
        for (int j = 1; j <= stupaca; j++)
            dvaPolja[i][j] = i + 1 + j / 100.;
    }

    cout << "Ispis članova niza: " << endl;
    for (int i = 0; i < redaka; i++) {
        for (int j = 1; j <= dvaPolja[i][0]; j++)
            cout << "[" << i << "][" << j << "] = " << dvaPolja[i][j] << endl;
    }

    for (int i = 0; i < redaka; i++)
        delete [] dvaPolja[i];
    delete [] dvaPolja;

    return 0;
}
