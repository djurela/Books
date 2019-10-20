#include <iostream>
using namespace std;

int main() {
    cout << "Upiši broj točaka: ";
    int n;
    cin >> n;

    double* x = new double[n];
    double* y = new double[n];

    double sredX = 0.0;
    double sredY = 0.0;
    for (int i = 0; i < n; i++) {
        cout << "t(" << i + 1 << ") = ";
        cin >> x[i];
        cout << "s(" << i + 1 << ") = ";
        cin >> y[i];
        sredX += x[i];
        sredY += y[i];
    }
    sredX /= n;
    sredY /= n;

    double a = 0.0;
    double nazivnik = 0.0;
    for (int i = 0; i < n; i++){
        double deltaX = x[i] - sredX;
        a += deltaX * y[i];
        nazivnik += deltaX * deltaX;
    }
    a /= nazivnik;
    double b = sredY - a * sredX;

    delete [] x;
    delete [] y;

    cout << "Prosječna brzina trkača je " << a << " m/s" << endl;
    cout << "800 m će pretrčati za " << (800 - b) / a << " sekunde " << endl;

    return 0;
}