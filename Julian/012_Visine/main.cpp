#include <iostream>

using namespace std;

int main()
{
    int visine[5] = {162, 193, 205, 150, 178};
    int* najvisi = nullptr;

    for(int i = 0; i < 5; i++) {
        if(najvisi == nullptr)
            najvisi = visine + i;
        else if(visine[i] > *najvisi)
            najvisi = visine + i;
    }
    cout << "visine: " << visine << endl;
    cout << "najvisi: " << najvisi << endl;
    cout << "Najveća visina (*najvisi): " << *najvisi << endl;

    return 0;
}
