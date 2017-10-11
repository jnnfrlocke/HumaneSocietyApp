using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class AdopterAgeSearch
    {
        public void SearchByAge(List<animal> listToNarrow)
        {
            Console.WriteLine("What age would you like to search for?");
            string searchAge = Console.ReadLine();

            var ageQuery =
                from animal in listToNarrow
                where animal.age == searchAge
                select animal;

            List<animal> ageList = ageQuery.ToList();

            try
            {
                if (ageQuery.Count() < 1)
                {
                    Console.WriteLine("No results found.\nWould you like to exit the application or start over? Type 1 to exit or 2 to start over.");
                    string ageSearch = Console.ReadLine();

                    if (ageSearch == "1")
                    {
                        Environment.Exit(0);
                    }
                    else if (ageSearch == "2")
                    {
                        HumaneSociety startOver = new HumaneSociety();
                        startOver.Run();
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid option.");
                        SearchByAge(listToNarrow);
                    }
                }
                    foreach (var result in ageQuery)
                    {
                        Console.WriteLine($"Located {searchAge}, ID:{result.animal_id}, {result.name}, aged {result.age}");

                        
                    }
                
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
                SearchByAge(listToNarrow);
            }
            AdopterNarrowSearch narrowSearchDown = new AdopterNarrowSearch();
            narrowSearchDown.adopterNarrowOption(ageList);

        }
    }
}
