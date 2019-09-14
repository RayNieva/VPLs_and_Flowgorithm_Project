using System;

namespace ConsoleAppSayvaServicesOrderformWorkflow2
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Dispatcher Receives Call/Email and Request for Service");
            Console.WriteLine("Need to Look up Status of Caller in Database");
            int caller;

            caller = 1;
            int currentCustomer;

            currentCustomer = (int)readValue();
            if (caller == currentCustomer)
            {
                Console.WriteLine("Does Customer Have an Outstanding Balance?");
                string balanceDueStatus;

                balanceDueStatus = Console.ReadLine();
                if (balanceDueStatus == "Yes")
                {
                    Console.WriteLine("Request Payment/and or resolve due balance for further service");
                }
                else
                {
                    Console.WriteLine("Get information regarding requested Service and start a Helpdesk ticket");
                    Console.WriteLine("Contact Available Agent.  Available Agent will contact Customer");
                    Console.WriteLine("Agent Contacts Customer and determines if the problem/service can be completed on the phone or will require an on-premise visit or might even determine requires a referred service.");
                    string phoneResolution;

                    phoneResolution = Console.ReadLine();
                    if (phoneResolution == "Yes")
                    {
                        Console.WriteLine("Resolve or Provide Service over phone. Add information to Helpdesk ticket and Fillout Order Form. Collect payment electronically somehow. Customer Invoice Needs to be sent to customer.");
                        string referredServiceReqd;

                        referredServiceReqd = Console.ReadLine();
                        if (referredServiceReqd == "Yes")
                        {
                            Console.WriteLine("External Agent Contact is required ie Plumbing Contractor, HVAC Contractor, Computer or Phone Repair Service Etc....");
                        }
                        Console.WriteLine("Order Form Needs to be entered into Database");
                    }
                    else
                    {
                        Console.WriteLine("Travel to customer premises resolve or provide service. Fill out paper order form. Collect payment. Carbon copy is receipt.");
                        string referredServiceReqd;

                        referredServiceReqd = Console.ReadLine();
                        if (referredServiceReqd == "Yes") 
                        {
                            Console.WriteLine("External Agent Contact is required ie Plumbing Contractor, HVAC Contractor, Computer or Phone Repair Service Etc....");
                        }
                        Console.WriteLine("Order Form Needs to be entered into Database");
                    }
                }
            }
            else
            {
                Console.Write("Enter Information Regarding New Customer into Database");
                Console.WriteLine("Get information regarding requested Service and start a Helpdesk ticket");
                Console.WriteLine("Contact Available Agent.  Available Agent will contact Customer");
                Console.WriteLine("Agent Contacts Customer and determines if the problem/service can be completed on the phone or will require an on-premise visit or might even determine requires a referred service.");
                string phoneResolution;

                phoneResolution = Console.ReadLine();
                if (phoneResolution == "Yes")
                {
                    Console.Write("Resolve or Provide Service over phone. Add information to Helpdesk ticket and Fillout Order Form. Collect payment electronically somehow. Customer Invoice Needs to be sent to customer.");
                    string referredServiceReqd;

                    referredServiceReqd = Console.ReadLine();
                    if (referredServiceReqd == "Yes")
                    {
                        Console.WriteLine("External Agent Contact is required ie Plumbing Contractor, HVAC Contractor, Computer or Phone Repair Service Etc....");
                    }
                    Console.WriteLine("Order Form Needs to be entered into Database");
                }
                else
                {
                    Console.WriteLine("Travel to customer premises resolve or provide service. Fill out paper order form. Collect payment. Carbon copy is receipt.");
                    string referredServiceReqd;

                    referredServiceReqd = Console.ReadLine();
                    if (referredServiceReqd == "Yes")
                    {
                        Console.WriteLine("External Agent Contact is required ie Plumbing Contractor, HVAC Contractor, Computer or Phone Repair Service Etc....");
                    }
                    Console.WriteLine("Order Form Needs to be entered into Database");
                }
            }
        }

        // .NET can only read single characters or entire lines from the console.
        // The following function safely reads a double value.
        private static double readValue()
        {
            double result;
            while (!double.TryParse(Console.ReadLine(), out result)) ;
            return result;
        }
    }
}
