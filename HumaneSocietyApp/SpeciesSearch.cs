using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    public class SpeciesSearch
    {
        public void SearchBySpecies()
        {
            Console.WriteLine("Please enter a species.");
            string searchSpecies = Console.ReadLine();

            HumaneSociety02DataContext db = new HumaneSociety02DataContext();

            IQueryable<animal> speciesQuery =
                from animal in db.animals
                where animal.species == searchSpecies
                select animal;

            Array speciesArray = speciesQuery.ToArray();

            try
            {
                foreach (var result in speciesQuery)
                {
                    Console.WriteLine($"Located {searchSpecies}, ID:{result.animal_id}, {result.name}, aged {result.age}");
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
            }

            NarrowSearch narrowSearchDown = new NarrowSearch();
            narrowSearchDown.narrowOption(speciesArray);
        }
    }
}
