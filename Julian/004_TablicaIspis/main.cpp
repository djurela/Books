#include <iostream>
#include <iomanip>

using namespace std;

int main()
{
    for(int redak = 1; redak <= 10; redak++)
    {
        for(int stupac = 1; stupac <= redak; stupac++)
            cout << setw(5) << redak * stupac;
        cout << endl;
    }
    return 0;
}
