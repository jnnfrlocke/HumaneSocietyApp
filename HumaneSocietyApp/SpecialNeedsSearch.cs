using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    public class SpecialNeedsSearch
    {
        public void SearchBySpecialNeeds()
        {
            Console.WriteLine("Are you looking for animals with special needs? Type yes or no.");
            string searchSpecialNeeds = Console.ReadLine();

            HumaneSociety02DataContext db = new HumaneSociety02DataContext();

            IQueryable<animal> specialNeedsQuery =
                from animal in db.animals
                where animal.special_needs == searchSpecialNeeds
                select animal;

            Array specialNeedsArray = specialNeedsQuery.ToArray();

            try
            {
                foreach (var result in specialNeedsQuery)
                {
                    Console.WriteLine($"Located {result.name}, ID:{result.animal_id}, {result.species}, aged {result.age}");
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
            }

            // How to explain no results

            NarrowSearch narrowSearchDown = new NarrowSearch();
            narrowSearchDown.narrowOption(specialNeedsArray);

        }
    }
}
