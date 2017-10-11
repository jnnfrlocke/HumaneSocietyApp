using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    public class AdopterSpeciesSearch
    {
        public void SearchBySpecies(List<animal> listToNarrow)
        {
            Console.WriteLine("Please enter a species.");
            string searchSpecies = Console.ReadLine();
            
            var speciesQuery =
                from animal in listToNarrow
                where animal.species == searchSpecies
                select animal;
            List<animal> adopterSpeciesList = speciesQuery.ToList();

            try
            {
                if (speciesQuery.Count() < 1)
                {
                    Console.WriteLine("No results found.\nWould you like to exit the application or start over? Type 1 to exit or 2 to start over.");
                    string speciesSearch = Console.ReadLine();

                    if (speciesSearch == "1")
                    {
                        Environment.Exit(0);
                    }
                    else if (speciesSearch == "2")
                    {
                        HumaneSociety startOver = new HumaneSociety();
                        startOver.Run();
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid option.");
                        SearchBySpecies(listToNarrow);
                    }
                }

                foreach (var result in speciesQuery)
                {
                Console.WriteLine($"Located {searchSpecies}, ID:{result.animal_id}, {result.name}, aged {result.age}");

               
                }
                
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
                SearchBySpecies(listToNarrow);
            }

            AdopterNarrowSearch narrowSearchDown = new AdopterNarrowSearch();
            narrowSearchDown.adopterNarrowOption(adopterSpeciesList);


        }
    }
}
