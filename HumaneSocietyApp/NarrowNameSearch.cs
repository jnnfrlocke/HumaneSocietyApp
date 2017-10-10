using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowNameSearch
    {
        public void SearchByName(List<string> listToNarrow)
        {
            Console.WriteLine("Please enter the animal's name");
            string searchName = Console.ReadLine();

            var namesQuery = from name in listToNarrow
                             where name.Contains(searchName)
                             select name;
            
            Array namesArray = namesQuery.ToArray();

            try
            {
                foreach (var result in namesQuery)
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
            narrowSearchDown.narrowOption(namesArray);
        }
    }
}
