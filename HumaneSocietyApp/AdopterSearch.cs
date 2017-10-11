using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    public class AdopterSearch
    {
        public string SearchMenu()
        {
            HSDataDataContext db = new HSDataDataContext();

            IQueryable<animal> adoptableAnimals =
                from animal in db.animals
                where animal.is_adopted == "no"
                select animal;

            List<animal> adoptableAnimalList = adoptableAnimals.ToList();

            Console.WriteLine("Which trait would you like to search by?\nPlease enter one of the following:\nSpecies: type 1\nSpecial Needs: type 2\nAge: type 3\nAdoptionFee: type 4\nVaccination Status: type 5");
            string searchType = Console.ReadLine().ToLower();

            switch (searchType)
            {
                case "1":
                    AdopterSpeciesSearch newSpeciesSearch = new AdopterSpeciesSearch();
                    newSpeciesSearch.SearchBySpecies(adoptableAnimalList);
                    break;
                case "2":
                    AdopterSpecialNeedsSearch newSpecialNeedsSearch = new AdopterSpecialNeedsSearch();
                    newSpecialNeedsSearch.SearchBySpecialNeeds(adoptableAnimalList);
                    break;
                case "3":
                    AgeSearch newAgeSearch = new AgeSearch();
                    newAgeSearch.SearchByAge();
                    break;
                case "4":
                    AdoptionFeeSearch newAdoptionFeeSearch = new AdoptionFeeSearch();
                    newAdoptionFeeSearch.SearchByAdoptionFee();
                    break;
                case "5":
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

        public List<animal> NarrowToAdoptableAnimals()
        {
            HSDataDataContext db = new HSDataDataContext();

            IQueryable<animal> adoptableAnimals =
                from animal in db.animals
                where animal.is_adopted == "no"
                select animal;

            List < animal > adoptableAnimalList = adoptableAnimals.ToList();

            return adoptableAnimalList;
        }
    }
}
