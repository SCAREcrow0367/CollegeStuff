#include <iostream>
#include <cmath>

struct newperson
{
    char name[20];
    int age;

};

int main()
{
    using namespace std;
    newperson bucky =
    {
      "Bucky",
      21
    };
    newperson hoss =
    {
        "Hoss Jones",
        45
    };
    cout << bucky.age << endl;
    cout << bucky.name << endl;
    cout << hoss.age << endl;
    cout << hoss.name << endl;
    system("pause");
    return 0;
}