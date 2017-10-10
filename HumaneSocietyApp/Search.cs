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
            Console.WriteLine("Which trait would you like to search by?\nPlease enter one of the following:\nName: type 1\nSpecies: type 2\nAdoption Status: type 3\nSpecial Needs: type 4\nAge: type 5\nAdoptionFee: type 6\nLocation: type 7\nVaccination Status: type 8");
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
                    LocationSearch newLocationSearch = new LocationSearch();
                    newLocationSearch.SearchByLocation();
                    break;
                case "8":
                    VaccinationStatusSearch newVaccionationStatusSearch = new VaccinationStatusSearch();
                    newVaccionationStatusSearch.SearchByVaccinationStatus();
                    break;
                default:
                    Console.WriteLine("Please type a valid entry.");
                    SearchMenu();
                    break;
            }
            return searchType;
        }
    }




}
