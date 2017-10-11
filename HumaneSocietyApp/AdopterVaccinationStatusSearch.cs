using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class AdopterVaccinationStatusSearch
    {
        public void SearchByVaccinationStatus(List<animal> listToNarrow)
        {
            Console.WriteLine("Are you looking for animals with special needs? Type yes or no.");
            string searchVaccinationStatus = Console.ReadLine();

            HSDataDataContext db = new HSDataDataContext();

            var vaccinationStatusQuery =
                from animal in listToNarrow
                where animal.is_vaccinated == searchVaccinationStatus
                select animal;

            List<animal> adopterVaccinationStatusList = vaccinationStatusQuery.ToList();

            try
            {
                if (vaccinationStatusQuery.Count() < 1)
                {
                    Console.WriteLine("No results found.\nWould you like to exit the application or start over? Type 1 to exit or 2 to start over.");
                    string vaccinationStatusSearch = Console.ReadLine();

                    if (vaccinationStatusSearch == "1")
                    {
                        Environment.Exit(0);
                    }
                    else if (vaccinationStatusSearch == "2")
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
                        Console.WriteLine($"Located {searchVaccinationStatus}, ID:{result.animal_id}, {result.name}, aged {result.age}");

                        AdopterNarrowSearch narrowSearchDown = new AdopterNarrowSearch();
                        narrowSearchDown.adopterNarrowOption(adopterVaccinationStatusList);
                    }
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
                SearchByVaccinationStatus(listToNarrow);
            }

        }
    }
}
