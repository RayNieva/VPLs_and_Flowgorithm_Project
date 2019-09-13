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
    cout << "Dispatcher Receives Call/Email and Request for Service" << endl;
    cout << "Need to Look up Status of Caller in Database" << endl;
    int caller;
    
    caller = 1;
    int currentCustomer;
    
    cin >> currentCustomer;
    if (caller == currentCustomer) {
        cout << "Does Customer Have an Outstanding Balance?" << endl;
        string balanceDueStatus;
        
        cin >> balanceDueStatus;
        if (balanceDueStatus == "Yes") {
            cout << "Request Payment/and or resolve due balance for further service" << endl;
        } else {
            cout << "Get information regarding requested Service and start a Helpdesk ticket" << endl;
            cout << "Contact Available Agent.  Available Agent will contact Customer" << endl;
            cout << "Agent Contacts Customer and determines if the problem/service can be completed on the phone or will require an on-premise visit or might even determine requires a referred service." << endl;
            int phoneResolution;
            
            cin >> phoneResolution;
            if (phoneResolution == "Yes") {
                cout << "Resolve or Provide Service over phone. Add information to Helpdesk ticket and Fillout Order Form. Collect payment electronically somehow. Customer Invoice Needs to be sent to customer." << endl;
                string referredServiceReqd;
                
                cin >> referredServiceReqd;
                if (referredServiceReqd == "Yes") {
                    cout << "External Agent Contact is required ie Plumbing Contractor, HVAC Contractor, Computer or Phone Repair Service Etc...." << endl;
                }
                cout << "Order Form Needs to be entered into Database" << endl;
            } else {
                cout << "Travel to customer premises resolve or provide service. Fill out paper order form. Collect payment. Carbon copy is receipt." << endl;
                string referredServiceReqd;
                
                cin >> referredServiceReqd;
                if (referredServiceReqd == "Yes") {
                    cout << "External Agent Contact is required ie Plumbing Contractor, HVAC Contractor, Computer or Phone Repair Service Etc...." << endl;
                }
                cout << "Order Form Needs to be entered into Database" << endl;
            }
        }
    } else {
        cout << "Enter Information Regarding New Customer into Database";
        cout << "Get information regarding requested Service and start a Helpdesk ticket" << endl;
        cout << "Contact Available Agent.  Available Agent will contact Customer" << endl;
        cout << "Agent Contacts Customer and determines if the problem/service can be completed on the phone or will require an on-premise visit or might even determine requires a referred service." << endl;
        string phoneResolution;
        
        cin >> phoneResolution;
        if (phoneResolution == "Yes") {
            cout << "Resolve or Provide Service over phone. Add information to Helpdesk ticket and Fillout Order Form. Collect payment electronically somehow. Customer Invoice Needs to be sent to customer.";
            string referredServiceReqd;
            
            cin >> referredServiceReqd;
            if (referredServiceReqd == "Yes") {
                cout << "External Agent Contact is required ie Plumbing Contractor, HVAC Contractor, Computer or Phone Repair Service Etc...." << endl;
            }
            cout << "Order Form Needs to be entered into Database" << endl;
        } else {
            cout << "Travel to customer premises resolve or provide service. Fill out paper order form. Collect payment. Carbon copy is receipt." << endl;
            string referredServiceReqd;
            
            cin >> referredServiceReqd;
            if (referredServiceReqd == "Yes") {
                cout << "External Agent Contact is required ie Plumbing Contractor, HVAC Contractor, Computer or Phone Repair Service Etc...." << endl;
            }
            cout << "Order Form Needs to be entered into Database" << endl;
        }
    }
    return 0;
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
