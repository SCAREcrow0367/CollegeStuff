#include <iostream>

using namespace std;

int main()
{
	int calories[5] = { 0 };
	for (int sub = 0; sub < 5; sub += 1)
	{
		cout << "Calories for day " << sub + 1 << ": ";
		cin >> calories[sub];
	}

	cout << endl << "Array contents:" << endl;
	for (int sub = 0; sub < 5; sub += 1)
		cout << "Calories for day " << sub + 1 << ": " << calories[sub] << endl;

	return 0;
}