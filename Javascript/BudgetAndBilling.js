function Main() {
    // This program is intended to be used to calculate my weekly budget based on income that week and projected expenses that week.
    output("Calculating Weekly/ Budget");
    
    // This is usually weekly (net) income but can be another period like bi-weekly or monthly
    output("Get Income for week/period");
    var income1;
    
    income1 = input("Income1");
    
    // At this point start inputting billing items. These are essentially billing items for the current week or period. 
    // The question is at this point what direction this program will go? Will there be permanently assigned billing items or billing items adhoc defined each week. Can Flowgorithm define a true OO approach?
}

// The following functions are called whenever the program needs to input or output data.
// You can change these functions to use other webpage elements rather than pop-up
// windows.

function input (name) {
    return window.prompt("Please enter a value for " + name, "");
}

function output (text) {
    window.alert(text);
}

