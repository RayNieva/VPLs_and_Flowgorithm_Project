#include <iostream>
#include <sstream>
#include <string>
#include <cstdlib>
#include <cmath>

using namespace std;

// Headers
string toString (double);
int toInt (string);
double toDouble (string);

int main() {
    // This program is intended to be used to calculate my weekly budget based on income that week and projected expenses that week.
    cout << "Calculating Weekly/ Budget" << endl;
    
    // This is usually weekly (net) income but can be another period like bi-weekly or monthly
    cout << "Get Income for week/period" << endl;
    double income1;
    
    cin >> income1;
    
    // At this point start inputting billing items. These are essentially billing items for the current week or period. 
    // The question is at this point what direction this program will go? Will there be permanently assigned billing items or billing items adhoc defined each week. Can Flowgorithm define a true OO approach?
}

// The following implements type conversion functions.

string toString (double value) { //int also
    stringstream temp;
    temp << value;
    return temp.str();
}

int toInt (string text) {
    return atoi(text.c_str());
}

double toDouble (string text) {
    return atof(text.c_str());
}
