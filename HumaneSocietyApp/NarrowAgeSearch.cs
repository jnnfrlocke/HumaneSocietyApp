using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowAgeSearch
    {
        public void SearchByAge(List<animal> listToNarrow)
        {
            Console.WriteLine("What age would you like to search for?");
            string searchAge = Console.ReadLine();

            var ageQuery = from age in listToNarrow
                           where age.age.Contains(searchAge)
                           select age;

            Array ageArray = ageQuery.ToArray();

            try
            {
                if (ageQuery.Count() < 1)
                {
                    Console.WriteLine("No results found.");
                    Console.ReadLine();
                }
                foreach (var result in ageQuery)
                {
                    Console.WriteLine($"ID: {result.animal_id}, Name: {result.name}, age {result.age}");
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
