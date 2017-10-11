using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowSpeciesSearch
    {
        public void SearchBySpecies(List<animal> listToNarrow)
        {
            Console.WriteLine("Please enter a species.");
            string searchSpecies = Console.ReadLine();

            var speciesQuery = from species in listToNarrow
                             where species.species.Contains(searchSpecies)
                             select species;

            Array speciesArray = speciesQuery.ToArray();

            try
            {
                if (speciesQuery.Count() < 1)
                {
                    Console.WriteLine("No results found.");
                    Console.ReadLine();
                }
                foreach (var result in speciesQuery)
                {
                    Console.WriteLine($"ID: {result.animal_id}, Name: {result.name}, age {result.age}");
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
            }

            //need something for if no results

            NarrowSearch narrowSearchDown = new NarrowSearch();
            narrowSearchDown.narrowOption(speciesArray);
        }
    }
}
