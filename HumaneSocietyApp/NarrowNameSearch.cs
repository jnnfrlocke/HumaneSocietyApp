using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowNameSearch
    {
        public void SearchByName(List<animal> listToNarrow)
        {
            Console.WriteLine("Please enter the animal's name");
            string searchName = Console.ReadLine();

            var namesQuery = from name in listToNarrow
                             where name.name.Contains(searchName)
                             select name;
            
            Array namesArray = namesQuery.ToArray();

            try
            {

                if (namesQuery.Count() < 1)
                {
                    Console.WriteLine("No results found.");
                    Console.ReadLine();
                }
                foreach (var result in namesQuery)
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
            narrowSearchDown.narrowOption(namesArray);
        }
    }
}
