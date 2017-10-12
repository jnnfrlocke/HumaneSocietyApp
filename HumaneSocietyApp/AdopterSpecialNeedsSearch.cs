using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class AdopterSpecialNeedsSearch
    {
       public void SearchBySpecialNeeds(List<animal> listToNarrow)
        {
            Console.WriteLine("Are you looking for animals with special needs? Type yes or no.");
            string searchSpecialNeeds = Console.ReadLine();

            var specialNeedsQuery =
                from animal in listToNarrow
                where animal.special_needs == searchSpecialNeeds
                select animal;

            List<animal> adopterSpecialNeedsList = specialNeedsQuery.ToList();

            try
            {
                if (specialNeedsQuery.Count() < 1)
                {
                    Console.WriteLine("No results found.\nWould you like to exit the application or start over? Type 1 to exit or 2 to start over.");
                    string specialNeedsSearch = Console.ReadLine();

                    if (specialNeedsSearch == "1")
                    {
                        Environment.Exit(0);
                    }
                    else if (specialNeedsSearch == "2")
                    {
                        HumaneSociety startOver = new HumaneSociety();
                        startOver.Run();
                    }
                   else
                    {
                        Console.WriteLine("You did not enter a valid option.");
                        SearchBySpecialNeeds(listToNarrow);
                    }
                    foreach (var result in specialNeedsQuery)
                    {
                        Console.WriteLine($"Located {searchSpecialNeeds}, ID:{result.animal_id}, {result.name}, aged {result.age}");

                        AdopterNarrowSearch narrowSearchDown = new AdopterNarrowSearch();
                        narrowSearchDown.adopterNarrowOption(adopterSpecialNeedsList);
                    }
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
                SearchBySpecialNeeds(listToNarrow);
            }
        }
    }
}
