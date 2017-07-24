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

double GetIncome(double, double, double);

int main() {
    // This program is intended to be used to calculate my weekly budget based on income that week and projected expenses that week.
    cout << "Calculating Weekly/ Budget" << endl;
    
    // Call Function to calculate total income
    double paySource1;
    
    cin >> paySource1;
    double paySource2;
    
    cin >> paySource2;
    double paySource3;
    
    cin >> paySource3;
    GetIncome(paySource1, paySource2, paySource3);
    cout << "Returning to Main" << endl;
    
    // At this point should have total income
    // At this point start inputting billing items. These are essentially billing items for the current week or period. 
    // The question is at this point what direction this program will go? Will there be permanently assigned billing items or billing items adhoc defined each week. Can Flowgorithm help define a true OO approach?
}

double GetIncome(double paySource1, double paySource2, double paySource3) {
    double totalPay;
    
    totalPay = paySource1 + paySource2 + paySource3;
    cout << totalPay << endl;
    
    return totalPay;
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
