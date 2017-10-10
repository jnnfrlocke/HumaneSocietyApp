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

            HumaneSociety02DataContext db = new HumaneSociety02DataContext();

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
                foreach (var result in vaccinationStatusQuery)
                {
                    Console.WriteLine($"Located {result.name}, ID:{result.animal_id}, {result.species}, aged {result.age}");
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
