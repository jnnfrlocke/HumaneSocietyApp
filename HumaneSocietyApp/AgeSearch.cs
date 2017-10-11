using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    public class AgeSearch
    {
        public void SearchByAge()
        {
            Console.WriteLine("What age would you like to search for?");
            string searchAge = Console.ReadLine();

            HSDataDataContext db = new HSDataDataContext();

            IQueryable<animal> ageQuery =
                from animal in db.animals
                where animal.age == searchAge
                select animal;

            Array ageArray = ageQuery.ToArray();

            try
            {
                foreach (var result in ageQuery)
                {
                    Console.WriteLine($"Located {searchAge}, ID:{result.animal_id}, {result.species}, aged {result.age}");
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
            }

            //needs message for when nothing is returned

            NarrowSearch narrowSearchDown = new NarrowSearch();
            narrowSearchDown.narrowOption(ageArray);
        }
    }
}
