using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowAgeSearch
    {
        public void SearchByAge(List<string> listToNarrow)
        {
            Console.WriteLine("What age would you like to search for?");
            string searchAge = Console.ReadLine();

            var ageQuery = from age in listToNarrow
                           where age.Contains(searchAge)
                           select age;

            Array ageArray = ageQuery.ToArray();

            try
            {
                foreach (var result in ageQuery)
                {
                    Console.WriteLine($"Narrowed results: {result}");
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
