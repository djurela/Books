#include <iostream>

using namespace std;

void Ispis(int param[3][3]);

int main()
{
    int mat[3][3] = {{1, 2, 3}, {2, 3, 4}};

    for(int i = 0; i < 3; i++)
        mat[2][i] = i + 3;

    Ispis(mat);

    for(int i = 0; i < 3; i++)
        for(int j = 0; j < 3; j++)
            mat[i][j] *= 2;

    Ispis(mat);
    cout << endl;

    return 0;
}

void Ispis(int param[3][3])
{
    for(int i = 0; i < 3; i++)
        cout << param[i][0] << " " << param[i][1] << " " << param[i][2] << endl;
    cout << endl;
}
