using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class Adopter
    {
        public void AdopterOptions()
        {
            Console.WriteLine("Would you like to search for a pet or fill out an adopter profile? Please enter 'search' or 'new profile'.");
            string adopterSelection = Console.ReadLine();

            if (adopterSelection == "search")
            {
                Search adopterSearch = new Search();
                adopterSearch.SearchMenu();
            }
            else if (adopterSelection == "new profile")
            {
                AdopterProfile newProfile = new AdopterProfile();
                newProfile.CreateNewProfile();
            }
            else
            {
                Console.WriteLine("You did not enter a valid option. Would you like to continue, exit the application, or restart? Type 1 to continue, 2 to exit, or 3 to restart.");
                string adopterRestartSelection = Console.ReadLine();

                if (adopterRestartSelection == "1")
                {
                    AdopterOptions();
                }
                else if (adopterRestartSelection == "2")
                {
                    Environment.Exit(0);
                }
                else if (adopterRestartSelection == "3")
                {
                    HumaneSociety startOver = new HumaneSociety();
                    startOver.Run();
                }
                else
                {
                    Console.WriteLine("You did not enter a valid option.");
                    AdopterOptions();
                }
            }
        }
    }
}
