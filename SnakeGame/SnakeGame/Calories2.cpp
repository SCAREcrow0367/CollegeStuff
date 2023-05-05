#include <iostream>

using namespace std;

void displayArray(int cals[], int numElements);

int main()
{
	int calories[5] = { 0 };
	for (int sub = 0; sub < 5; sub += 1)
	{
		cout << "Calories for day" << sub + 1 << ": ";
		cin >> calories[sub];
	}
	
	displayArray(calories, 5);
	return 0;
}
void displayArray(int cals[], int numElements)
{
	cout << endl << "Array contents:" << endl;
	for (int sub = 0; sub < 5; sub += 1)
		cout << "Calories for day " << sub + 1 << ": " << cals[sub] << endl;
}