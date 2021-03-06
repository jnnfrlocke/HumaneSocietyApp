﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class AdopterNarrowSearch
    {
        public void adopterNarrowOption(List<animal> listToNarrow)
        {
            Console.WriteLine("Would you like to narrow your search further? Type yes or no.");
            string continueSearching = Console.ReadLine().ToLower();

            if (continueSearching == "yes")
            {
                AdopterContinueSearch continueSearchingNow = new AdopterContinueSearch();
                continueSearchingNow.ContinueSearchMenu(listToNarrow);
            }
            else if (continueSearching == "no")
            {
                Console.WriteLine("Would you like to exit the application or start over? Type 1 to exit or 2 to start over.");
                string endOrRestart = Console.ReadLine().ToLower();

                if (endOrRestart == "1")
                {
                    Environment.Exit(0);
                }

                else if (endOrRestart == "2")
                {
                    HumaneSociety startOver = new HumaneSociety();
                    startOver.Run();
                }
                else
                {
                    Console.WriteLine("You did not enter a valid option.");
                    adopterNarrowOption(listToNarrow);
                }
            }
        }
    }
}
