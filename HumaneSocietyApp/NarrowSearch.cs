using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowSearch
    {
        public void narrowOption(Array arrayToNarrow)
        {
            Console.WriteLine("Would you like to narrow your search further? Type yes or no.");
            string continueSearching = Console.ReadLine().ToLower();

            if (continueSearching == "yes")
            {
                ContinueSearch continueSearchingNow = new ContinueSearch();
                continueSearchingNow.ContinueSearchMenu(arrayToNarrow);
            }
            else
            {
                Console.WriteLine("Would you like to perform an action on an animal's record , exit the application or start over? Type 1 to edit an animal's record, 2 to exit, or 3 to start over.");
                string endOrRestart = Console.ReadLine().ToLower();

                if (endOrRestart == "1")
                {
                    Console.WriteLine("To edit an animal's species type 1, to change an animal's adoption status type 2, or to process an adoption fee type 3.");
                    string actionToPerform = Console.ReadLine();

                    switch (actionToPerform)
                    {
                        case "1":
                            //change species method;
                            break;
                        case "2":
                            //change adoption status method;
                            break;
                        case "3":
                            //process payment method;
                            break;
                        default:
                            Console.WriteLine("You entered an invalid option.");
                            narrowOption(arrayToNarrow);
                            break;
                    }
                }

                else if (endOrRestart == "2")
                {
                    Environment.Exit(0);
                }
                else if (endOrRestart == "3")
                {
                    HumaneSociety startOver = new HumaneSociety();
                    startOver.Run();
                }

                else
                {
                    Console.WriteLine("You did not enter a valid option.");
                    narrowOption(arrayToNarrow);
                }
            }
        }
    }
}
