#include <iostream>
#include <string>

using namespace std;

struct student
{
    string name;
    int grade;
};

int mian()
{
    student pupil1;
    student pupil2;

    cout << "Please enter student's name: " << endl;
    cin >> pupil1.name;

    cout << "Please enter  student's grade: " << endl;
    cin >> pupil1.grade;

    cout << "Please enter student's name: " << endl;
    cin >> pupil2.name;

    cout << "Please enter  student's grade: " << endl;
    cin >> pupil2.grade;

    cout << "Name" << "      " << "Grade" << endl;
    cout << pupil1.name << "      " << pupil1.grade << endl;

    cout << pupil2.name << "      " << pupil2.grade << endl;
    system("pause");
    return 0;
}
