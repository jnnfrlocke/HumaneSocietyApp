using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class AdopterContinueSearch
    {
        public string ContinueSearchMenu(List<animal> listToNarrow)
        {
            Console.WriteLine("Which trait would you like to search by?\nPlease enter one of the following:\nSpecies: type 1\nSpecial needs: type 2\nAge: type 3\nAdoption fee: type 4");
            string searchType = Console.ReadLine().ToLower();

            switch (searchType)
            {
                case "1":
                    AdopterSpeciesSearch newSpeciesSearch = new AdopterSpeciesSearch();
                    newSpeciesSearch.SearchBySpecies(listToNarrow);
                    break;
                case "2":
                    AdopterSpecialNeedsSearch newSpecialNeedsSearch = new AdopterSpecialNeedsSearch();
                    newSpecialNeedsSearch.SearchBySpecialNeeds(listToNarrow);
                    break;
                case "3":
                    AdopterAgeSearch newAgeSearch = new AdopterAgeSearch();
                    newAgeSearch.SearchByAge(listToNarrow);
                    break;
                case "4":
                    AdopterVaccinationStatusSearch newVaccionationStatusSearch = new AdopterVaccinationStatusSearch();
                    newVaccionationStatusSearch.SearchByVaccinationStatus(listToNarrow);
                    break;
                case "5":
                    AdopterAdoptionFeeSearch newAdoptionFeeSearch = new AdopterAdoptionFeeSearch();
                    newAdoptionFeeSearch.SearchByAdoptionFee(listToNarrow);
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
