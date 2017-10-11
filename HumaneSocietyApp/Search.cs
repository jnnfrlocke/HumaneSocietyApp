using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace HumaneSocietyApp
{
    
    public class Search
    {
        public string SearchMenu()
        {
            Console.WriteLine("Which trait would you like to search by?\nPlease enter one of the following:\nName: type 1\nSpecies: type 2\nAdoption Status: type 3\nSpecial Needs: type 4\nAge: type 5\nAdoptionFee: type 6\nVaccination Status: type 7");
            string searchType = Console.ReadLine().ToLower();

            switch (searchType)
            {
                case "1":
                    NameSearch newNameSearch = new NameSearch();
                    newNameSearch.SearchByName();
                    break;
                case "2":
                    SpeciesSearch newSpeciesSearch = new SpeciesSearch();
                    newSpeciesSearch.SearchBySpecies();
                    break;
                case "3":
                    AdoptionStatusSearch newAdoptionStatusSearch = new AdoptionStatusSearch();
                    newAdoptionStatusSearch.SearchByAdoptionStatus();
                    break;
                case "4":
                    SpecialNeedsSearch newSpecialNeedsSearch = new SpecialNeedsSearch();
                    newSpecialNeedsSearch.SearchBySpecialNeeds();
                    break;
                case "5":
                    AgeSearch newAgeSearch = new AgeSearch();
                    newAgeSearch.SearchByAge();
                    break;
                case "6":
                    AdoptionFeeSearch newAdoptionFeeSearch = new AdoptionFeeSearch();
                    newAdoptionFeeSearch.SearchByAdoptionFee();
                    break;
               case "7":
                    VaccinationStatusSearch newVaccionationStatusSearch = new VaccinationStatusSearch();
                    newVaccionationStatusSearch.SearchByVaccinationStatus();
                    break;
                default:
                    Console.WriteLine("You typed an invalid entry.\nTo continue your search, enter 1. To exit the application, type 2. To start over, type 3");
                    string endContinueSearch = Console.ReadLine();

                    if (endContinueSearch == "1")
                    {
                        SearchMenu();
                    }
                    else if (endContinueSearch == "2")
                    {
                        Environment.Exit(0);
                    }
                    else if (endContinueSearch == "3")
                    {
                        HumaneSociety startOver = new HumaneSociety();
                        startOver.Run();
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid option.");
                        SearchMenu();
                    }
                    break;
            }
            return searchType;
        }
    }




}
