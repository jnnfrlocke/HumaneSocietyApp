using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowSpecialNeedsSearch
    {
        public void SearchBySpecialNeeds(List<string> listToNarrow)
        {
            Console.WriteLine("Are you looking for animals with special needs? Type yes or no.");
            string searchSpecialNeeds = Console.ReadLine();

            var specialNeedsQuery = from needs in listToNarrow
                                    where needs.Contains(searchSpecialNeeds)
                                    select needs;

            Array specialNeedsArray = specialNeedsQuery.ToArray();

            try
            {
                foreach (var result in specialNeedsQuery)
                {
                    Console.WriteLine($"Narrowed results: {result}");
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
