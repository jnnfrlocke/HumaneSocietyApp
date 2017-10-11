using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowVaccinationStatusSearch
    {
        public void SearchByVaccinationStatus(List<animal> listToNarrow)
        {
            Console.WriteLine("Are you looking for a pet that is already vaccinated? Type yes or no.");
            string searchVaccinationStatus = Console.ReadLine().ToLower();

            var vaccinationStatusQuery = from status in listToNarrow
                                         where status.is_vaccinated.Contains(searchVaccinationStatus)
                                         select status;

            Array namesArray = vaccinationStatusQuery.ToArray();

            if (searchVaccinationStatus != "yes" && searchVaccinationStatus != "no")
            {
                Console.WriteLine("You entered an invalid option.");
                SearchByVaccinationStatus(listToNarrow);
            }

            try
            {
                if (vaccinationStatusQuery.Count() < 1)
                    Console.WriteLine("No results found.\nWould you like to modify an animal's record, exit the application, or start over? Type 1 to modify, 2 to exit, or 3 to start over.");
                string vaccinationSearch = Console.ReadLine();

                if (vaccinationSearch == "1")
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

                else if (vaccinationSearch == "2")
                {
                    Environment.Exit(0);
                }
                else if (vaccinationSearch == "3")
                {
                    HumaneSociety startOver = new HumaneSociety();
                    startOver.Run();
                }
                else
                {
                    Console.WriteLine("You did not enter a valid option.");
                    SearchByVaccinationStatus(listToNarrow);
                }

                foreach (var result in vaccinationStatusQuery)
                {
                    Console.WriteLine($"ID: {result.animal_id}, Name: {result.name}, age {result.age}");

                    NarrowSearch narrowSearchDown = new NarrowSearch();
                    narrowSearchDown.narrowOption(namesArray);
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
            }
        }
    }
}
