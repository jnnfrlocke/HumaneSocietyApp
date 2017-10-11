using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class VaccinationStatusSearch
    {
        public void SearchByVaccinationStatus()
        {
            Console.WriteLine("Are you looking for a pet that is already vaccinated? Type yes or no.");
            string searchVaccinationStatus = Console.ReadLine().ToLower();

            HSDataDataContext db = new HSDataDataContext();

            IQueryable<animal> vaccinationStatusQuery =
                from animal in db.animals
                where animal.is_vaccinated == searchVaccinationStatus
                select animal;

            Array namesArray = vaccinationStatusQuery.ToArray();

            if (searchVaccinationStatus != "yes" && searchVaccinationStatus != "no")
            {
                Console.WriteLine("You entered an invalid option.");
                SearchByVaccinationStatus();

            }

            try
            {
                if (vaccinationStatusQuery.Count() < 1)
                {
                    Console.WriteLine("No results found.\nWould you like to modify an animal's record, exit the application, or start over? Type 1 to modify, 2 to exit, or 3 to start over.");
                    string vaccinationStatusSearch = Console.ReadLine();

                    if (vaccinationStatusSearch == "1")
                    {
                        Console.WriteLine("To edit an animal's species type 1, to change an animal's adoption status type 2, or to process an adoption fee type 3.");
                        string actionToPerform = Console.ReadLine();

                        switch (actionToPerform)
                        {
                            case "1":
                                Animal changeSpecies = new Animal();
                                changeSpecies.ChangeSpecies();
                                break;
                            case "2":
                                Animal changeAdoptionStatus = new Animal();
                                changeAdoptionStatus.ChangeStatus();
                                break;
                            case "3":
                                Animal processAdoptionFee = new Animal();
                                processAdoptionFee.ProcessPayment();
                                break;
                            default:
                                break;
                        }
                    }

                    else if (vaccinationStatusSearch == "2")
                    {
                        Environment.Exit(0);
                    }
                    else if (vaccinationStatusSearch == "3")
                    {
                        HumaneSociety startOver = new HumaneSociety();
                        startOver.Run();
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid option.");
                        SearchByVaccinationStatus();
                    }
                }

                foreach (var result in vaccinationStatusQuery)
                {
                    Console.WriteLine($"Located {result.name}, ID:{result.animal_id}, {result.species}, aged {result.age}");

                    NarrowSearch narrowSearchDown = new NarrowSearch();
                    narrowSearchDown.narrowOption(namesArray);
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
                SearchByVaccinationStatus();
            }
        }
    }
}
