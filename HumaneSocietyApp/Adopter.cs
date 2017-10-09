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
                CreateProfile();
            }
            else
            {
                Console.WriteLine("You did not enter a valid option.");
                AdopterOptions();
            }
        }

        public void CreateProfile()
        {
            AdopterProfile newProfile = new AdopterProfile();
            newProfile.CreateNewProfile();
        }

    }
}
