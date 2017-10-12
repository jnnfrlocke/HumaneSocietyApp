using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowSearch
    {
        public void narrowOption(Array arrayToBeginNarrow)
        {
            List<animal> listToNarrow = new List<animal>();
            
            foreach (animal listItem in arrayToBeginNarrow)
            {
                listToNarrow.Add(listItem);
            }
            
            Console.WriteLine("Would you like to narrow your search further? Type yes or no.");
            string continueSearching = Console.ReadLine().ToLower();

            if (continueSearching == "yes")
            {
                ContinueSearch continueSearchingNow = new ContinueSearch();
                continueSearchingNow.ContinueSearchMenu(listToNarrow);
            }
            else
            {
                Console.WriteLine("Would you like to modify an animal's record, exit the application, or start over? Type 1 to modify an animal's record, 2 to exit, or 3 to start over.");
                string endOrRestart = Console.ReadLine().ToLower();

                if (endOrRestart == "1")
                {
                    Console.WriteLine("To edit an animal's species type 1, to change an animal's adoption status type 2, or to process an adoption fee type 3.");
                    string actionToPerform = Console.ReadLine();

                    switch (actionToPerform)
                    {
                        case "1":
                            Animal changeSpecies = new Animal();
                            changeSpecies.ChangeSpecies();
                            break;
                        case "2":
                            Animal changeAdoptionStatus = new Animal();
                            changeAdoptionStatus.ChangeStatus();
                            break;
                        case "3":
                            Animal processAdoptionFee = new Animal();
                            processAdoptionFee.ProcessPayment();
                            break;
                        default:
                            Console.WriteLine("You entered an invalid option. Would you like to continue, exit the application or start over? Type 1 to continue, 2 to exit, or 3 to start over.");
                            string endNarrowSearch = Console.ReadLine();

                            if (endNarrowSearch == "1")
                            {
                                narrowOption(arrayToBeginNarrow); ;
                            }
                            else if (endNarrowSearch == "2")
                            {
                                Environment.Exit(0);
                            }
                            else if (endNarrowSearch == "3")
                            {
                                HumaneSociety startOver = new HumaneSociety();
                                startOver.Run();
                            }
                            else
                            {
                                Console.WriteLine("You did not enter a valid option.");
                                narrowOption(arrayToBeginNarrow);
                            }
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
                    narrowOption(arrayToBeginNarrow);
                }
            }

        }
    }
}
