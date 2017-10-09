using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class Adopter
    {

        string name;
        int streetNumber;
        string streetName;
        string city;
        string state;
        int zipCode;
        string phoneNum;
        string email;
        string speciesDesired;
        string lifestyleTraits;
        string residenceOwnership;
        string allergies;
        string previousPets;
        string currentPets;
        string veterinarian;
        string homeVisitPossibility;

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
            //name = GetName();
            //streetNumber = GetStreetNumber();
            //streetName = GetStreetName();
            //city = GetCity();
            //state = GetState();
            //zipCode = GetZipCode();
            //phoneNum = GetPhoneNum();
            //email = GetEmail();
            //speciesDesired = GetSpeciesDesired();
            //GetLifestyleTraits();
            //GetResidenceOwnership();
            //GetAllergies();
            //GetPreviousPets();
            //GetCurrentPets();
            //GetVeterinarian();// ow to do with 2 tables??
            //GetHomeVisitPossibility();

        }
    }
}
