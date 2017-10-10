using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowSpeciesSearch
    {
        public void SearchBySpecies(List<string> listToNarrow)
        {
            Console.WriteLine("Please enter a species.");
            string searchSpecies = Console.ReadLine();

            var speciesQuery = from species in listToNarrow
                             where species.Contains(searchSpecies)
                             select species;

            Array speciesArray = speciesQuery.ToArray();

            try
            {
                foreach (var result in speciesQuery)
                {
                    Console.WriteLine($"Narrowed results: {result}");
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
