using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowAdoptionStatusSearch
    {
        public void SearchByAdoptionStatus(List<animal> listToNarrow)
        {
            Console.WriteLine("Are you looking for adopted animals or animals waiting for adoption? Please enter adopted or waiting.");
            string searchAdoptionStatus = Console.ReadLine();

            string adopted;

            if (searchAdoptionStatus == "adopted")
            {
                adopted = "yes";
            }
            else if (searchAdoptionStatus == "waiting")
            {
                adopted = "no";
            }
            else
            {
                Console.WriteLine("You entered an invalid option");
                adopted = null;
                SearchByAdoptionStatus(listToNarrow);
            }
            
            var adoptionStatusQuery = from status in listToNarrow
                                      where status.is_adopted.Contains(searchAdoptionStatus)
                                      select status;

            Array adoptionStatusArray = adoptionStatusQuery.ToArray();

            try
            {
                if (adoptionStatusQuery.Count() < 1)
                {
                    Console.WriteLine("No results found.");
                    Console.ReadLine();
                }
                foreach (var result in adoptionStatusQuery)
                {
                    Console.WriteLine($"ID: {result.animal_id}, Name: {result.name}, age {result.age}");
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
            }

            // something for if no results

            NarrowSearch narrowSearchDown = new NarrowSearch();
            narrowSearchDown.narrowOption(adoptionStatusArray);
        }
    }
}
