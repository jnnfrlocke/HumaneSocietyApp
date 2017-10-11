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
            Console.WriteLine("Which trait would you like to search by?\nPlease enter one of the following:\nSpecies: type 1\nSpecial Needs: type 2\nAge: type 3\nAdoptionFee: type 4\nVaccination Status: type 5");
            string searchType = Console.ReadLine().ToLower();

            switch (searchType)
            {
                case "1"://species
                    NameSearch newNameSearch = new NameSearch();
                    newNameSearch.SearchByName();
                    break;
                case "2"://special needs
                    SpeciesSearch newSpeciesSearch = new SpeciesSearch();
                    newSpeciesSearch.SearchBySpecies();
                    break;
                case "3"://age
                    AdoptionStatusSearch newAdoptionStatusSearch = new AdoptionStatusSearch();
                    newAdoptionStatusSearch.SearchByAdoptionStatus();
                    break;
                case "4"://adoption fee
                    SpecialNeedsSearch newSpecialNeedsSearch = new SpecialNeedsSearch();
                    newSpecialNeedsSearch.SearchBySpecialNeeds();
                    break;
                case "5"://vaccination status
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
                    Console.WriteLine("Please type a valid entry.");
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

            List < animal > adoptableAnimalList = adoptableAnimals.ToList<animal>();

            return adoptableAnimalList;
        }
    }
}
