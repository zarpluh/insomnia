// ConsoleApplication1.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
using namespace std;

int main()
{
	int x, y;
	cout << "Enter two numbers: ";
	cin >> x >> y;
	if (x > y)
	{
		int w = x;
		x = y;
		y = w;
	}
	cout << x << " " << y << endl;
	system("pause>nul")
		return 0;
}


