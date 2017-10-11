using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class AdopterProfile
    {
        string getName;
        string getStreetNumber;
        string getStreetName;
        string getCity;
        string getState;
        int getZipCode;
        string getPhoneNum;
        string getEmail;
        string getSpeciesDesired;
        //int lifestyleTraits;
        string getResidenceOwnership;
        string getAllergies;
        string getPreviousPets;
        string getCurrentPets;
        string getVeterinarian;
        string getHomeVisitPossibility;

        public void CreateNewProfile()
        {
            getName = GetName();
            getStreetNumber = GetStreetNumber();
            getStreetName = GetStreetName();
            getCity = GetCity();
            getState = GetState();
            getZipCode = GetZipCode();
            getPhoneNum = GetPhoneNum();
            getEmail = GetEmail();
            getSpeciesDesired = GetSpeciesDesired();
            getResidenceOwnership = GetResidenceOwnership();
            getAllergies = GetAllergies();
            getPreviousPets = GetPreviousPets(); //create new classes to deal with tables?
            getCurrentPets = GetCurrentPets(); //create new classes to deal with tables?
            getVeterinarian = GetVeterinarian();// How to do with 2 tables??
            getHomeVisitPossibility = GetHomeVisitPossibility();
            //GetLifestyleTraits();

            adopter adopterToInsert = new adopter
            {
                name = getName,
                street_number = getStreetNumber,
                street_name = getStreetName,
                city = getCity,
                state = getState,
                zip_code = getZipCode,
                phone_num = getPhoneNum,
                email = getEmail,
                species_desired = getSpeciesDesired,
                residence_ownership_status = getResidenceOwnership,
                allergies = getResidenceOwnership,
                home_visit_possibility = getHomeVisitPossibility,
            };

            HSDataDataContext addAdopter = new HSDataDataContext();

            int numberOfAdoptionProfiles = addAdopter.adopters.Count();

            addAdopter.adopters.InsertOnSubmit(adopterToInsert);
            addAdopter.SubmitChanges();

            if (addAdopter.adopters.Count() >= numberOfAdoptionProfiles)
            {
                Console.WriteLine("Profile created successfully. Enter 1 to search the animals or 2 to exit.");
                int profileSuccess = int.Parse(Console.ReadLine());
                if (profileSuccess == 2)
                {
                    Environment.Exit(0);
                }
                else if (profileSuccess == 1)
                {
                    AdopterSearch newSearch = new AdopterSearch();
                    newSearch.SearchMenu();
                }
            }
        }

        private string GetName()
        {
            Console.WriteLine("Please enter your first and last name.");
            return Console.ReadLine();
        }

        private string GetStreetNumber()
        {
            Console.WriteLine("Please enter the numbers in your street address.");
            return Console.ReadLine();
        }

        private string GetStreetName()
        {
            Console.WriteLine("Please enter your street name.");
            return Console.ReadLine();
        }

        private string GetCity()
        {
            Console.WriteLine("Please enter your city.");
            return Console.ReadLine();
        }

        private string GetState()
        {
            Console.WriteLine("Please enter your state.");
            return Console.ReadLine();
        }

        private int GetZipCode()
        {
            Console.WriteLine("Please enter your zip code.");
            return int.Parse(Console.ReadLine());
        }

        private string GetPhoneNum()
        {
            Console.WriteLine("Please enter your phone number without spaces.");
            return Console.ReadLine();
        }

        private string GetEmail()
        {
            Console.WriteLine("Please enter your email address.");
            return Console.ReadLine();
        }

        private string GetSpeciesDesired()
        {
            Console.WriteLine("Please enter the species you wish to adopt.");
            return Console.ReadLine().ToLower();
        }

        private void GetLifestyleTraits()
        {
            AdopterLifestyle newLifestyle = new AdopterLifestyle();
            newLifestyle.GetLifestyle();
        }

        private string GetResidenceOwnership()
        {
            Console.WriteLine("Do you own your home or rent?");
            string residenceStatus = Console.ReadLine().ToLower();

            if (residenceStatus == "rent") // TODO: change this to another method
            {
                Console.WriteLine("Are you able top obtain permission from your landlord to keep a pet at home?");
                return Console.ReadLine().ToLower();
            }
            return residenceStatus;
        }

        private string GetAllergies()
        {
            Console.WriteLine("Do you or does anyone in your household have allergies to pets?");
            string allergyStatus = Console.ReadLine().ToLower();

            if (allergyStatus == "yes" || allergyStatus == "y") // TODO:change this to another method
            {
                Console.WriteLine("Are these controllable using medication or other methods?");
                string allergyControl = Console.ReadLine();
                return allergyControl;
            }

            return allergyStatus;
        }

        private string GetPreviousPets()
        {
            Console.WriteLine("Have you previously had any pets?");
            return Console.ReadLine(); // Adoption counselor will address this in further detail
        }

        private string GetCurrentPets()
        {
            Console.WriteLine("Do you currently have any pets?");
            string currentPetsStatus = Console.ReadLine();

            if (currentPetsStatus == "yes" || currentPetsStatus == "y")
            {
                GetVeterinarian();
                return currentPetsStatus;
            }

            return currentPetsStatus; // Adoption counselor will address this in further detail
        }

        private string GetVeterinarian()
        {
            Console.WriteLine("Do you currently have a veterinarian?");
            string hasVet = Console.ReadLine();
            GetVeterinarianInfo();
            return hasVet;

        }

        private string GetHomeVisitPossibility()
        {
            Console.WriteLine("Would you be willing to let us conduct a home visit if necessary?");
            return Console.ReadLine();
        }





        //private string LifestyleInfo()
        //{
        //    AdopterLifestyle newLifestyle = new AdopterLifestyle();
        //    newLifestyle.GetLifestyle();
        //}

        private void GetVeterinarianInfo()//move to veterinarian class
        {

        }

    }

}
