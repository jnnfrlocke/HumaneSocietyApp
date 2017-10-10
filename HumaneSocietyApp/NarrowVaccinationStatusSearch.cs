using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowVaccinationStatusSearch
    {
        public void SearchByVaccinationStatus(List<string> listToNarrow)
        {
            Console.WriteLine("Are you looking for a pet that is already vaccinated? Type yes or no.");
            string searchVaccinationStatus = Console.ReadLine().ToLower();

            var vaccinationStatusQuery = from status in listToNarrow
                                         where status.Contains(searchVaccinationStatus)
                                         select status;

            Array namesArray = vaccinationStatusQuery.ToArray();

            if (searchVaccinationStatus != "yes" && searchVaccinationStatus != "no")
            {
                Console.WriteLine("You entered an invalid option.");
                SearchByVaccinationStatus(listToNarrow);
            }

            try
            {
                foreach (var result in vaccinationStatusQuery)
                {
                    Console.WriteLine($"Narrowed results: {result}");
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
            }

            //need something for when no results

            NarrowSearch narrowSearchDown = new NarrowSearch();
            narrowSearchDown.narrowOption(namesArray);
        }
    }
}
