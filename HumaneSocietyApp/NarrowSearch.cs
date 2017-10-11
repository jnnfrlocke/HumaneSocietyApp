using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowSearch
    {
        //private object converter;

        //static string ConvertStringArrayToString(Array array)
        //{
            // Concatenate all the elements into a StringBuilder.
        //    StringBuilder builder = new StringBuilder();
        //    foreach (string value in array)
        //    {
        //        builder.Append(value);
        //        builder.Append(',');
        //    }
        //    return builder.ToString();
        //}

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
                Console.WriteLine("Would you like to perform an action on an animal's record, exit the application, or start over? Type 1 to edit an animal's record, 2 to exit, or 3 to start over.");
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
