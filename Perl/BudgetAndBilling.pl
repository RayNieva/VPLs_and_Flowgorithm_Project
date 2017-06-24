#!/usr/bin/perl
use strict;
use warnings;
use Math::Trig;

# This program is intended to be used to calculate my weekly budget based on income that week and projected expenses that week.
print "Calculating Weekly/ Budget", "\n";

# This is usually weekly (net) income but can be another period like bi-weekly or monthly
print "Get Income for week/period", "\n";
my $income1;

$income1 = <>;
chomp($income1);

# At this point start inputting billing items. These are essentially billing items for the current week or period. 
# The question is at this point what direction this program will go? Will there be permanently assigned billing items or billing items adhoc defined each week. Can Flowgorithm define a true OO approach?
