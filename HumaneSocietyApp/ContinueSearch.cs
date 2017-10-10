using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class ContinueSearch
    {
             public string ContinueSearchMenu(List<string> listToNarrow)
        {
            Console.WriteLine("Which trait would you like to search by?\nPlease enter one of the following:\nName: type 1\nSpecies: type 2\nAdoption Status: type 3\nSpecial Needs: type 4\nAge: type 5\nAdoptionFee: type 6\nVaccination Status: type 7");
            string searchType = Console.ReadLine().ToLower();

            switch (searchType)
            {
                case "1":
                    NarrowNameSearch newNameSearch = new NarrowNameSearch();
                    newNameSearch.SearchByName(listToNarrow);
                    break;
                case "2":
                    NarrowSpeciesSearch newSpeciesSearch = new NarrowSpeciesSearch();
                    newSpeciesSearch.SearchBySpecies(listToNarrow);
                    break;
                case "3":
                    NarrowAdoptionStatusSearch newAdoptionStatusSearch = new NarrowAdoptionStatusSearch();
                    newAdoptionStatusSearch.SearchByAdoptionStatus(listToNarrow);
                    break;
                case "4":
                    NarrowSpecialNeedsSearch newSpecialNeedsSearch = new NarrowSpecialNeedsSearch();
                    newSpecialNeedsSearch.SearchBySpecialNeeds(listToNarrow);
                    break;
                case "5":
                    NarrowAgeSearch newAgeSearch = new NarrowAgeSearch();
                    newAgeSearch.SearchByAge(listToNarrow);
                    break;
                case "6":
                    NarrowAdoptionFeeSearch newAdoptionFeeSearch = new NarrowAdoptionFeeSearch();
                    newAdoptionFeeSearch.SearchByAdoptionFee(listToNarrow);
                    break;
                case "7":
                    NarrowVaccinationStatusSearch newVaccionationStatusSearch = new NarrowVaccinationStatusSearch();
                    newVaccionationStatusSearch.SearchByVaccinationStatus(listToNarrow);
                    break;
                default:
                    Console.WriteLine("You did not enter a valid option. Would you like to continue, exit the application, or restart? Type 1 to continue, 2 to exit, or 3 to restart.");
                    string endContinueSearch = Console.ReadLine();

                    if (endContinueSearch == "1")
                    {
                        ContinueSearchMenu(listToNarrow);
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
                        ContinueSearchMenu(listToNarrow);
                    }                    
                    break;
            }
            return searchType;
        }
    }
    
}
