using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class AdopterProfile
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

        public void CreateNewProfile()
        {
            name = GetName();
            streetNumber = GetStreetNumber();
            streetName = GetStreetName();
            city = GetCity();
            state = GetState();
            zipCode = GetZipCode();
            phoneNum = GetPhoneNum();
            email = GetEmail();
            speciesDesired = GetSpeciesDesired();
            lifestyleTraits = GetLifestyleTraits();
            residenceOwnership = GetResidenceOwnership();
            allergies = GetAllergies();
            previousPets = GetPreviousPets();
            currentPets = GetCurrentPets();
            veterinarian = GetVeterinarian();// How to do with 2 tables??
            homeVisitPossibility = GetHomeVisitPossibility();
        }

        private string GetName()
        {
            Console.WriteLine("Please enter your first and last name.");
            return Console.ReadLine();
        }

        private int GetStreetNumber()
        {
            Console.WriteLine("Please enter the numbers in your street address.");
            return int.Parse(Console.ReadLine());
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

        private string GetLifestyleTraits()
        {
            return LifestyleInfo();
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
            Console.WriteLine("Do you or doesd anyone in your household have allergies to pets?");
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
            GetVeterinarianInfo();
            return Console.ReadLine();

        }

        private string GetHomeVisitPossibility()
        {
            Console.WriteLine("Would you be willing to let us conduct a home visit if necessary?");
            return Console.ReadLine();
        }





        private string LifestyleInfo()
        {

        }

        private void GetVeterinarianInfo()
        {

        }

    }

}
