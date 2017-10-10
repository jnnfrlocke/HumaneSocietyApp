using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowAdoptionStatusSearch
    {
        public void SearchByAdoptionStatus(List<string> listToNarrow)
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
            
            var adoptionStatusQuery = from name in listToNarrow
                                      where name.Contains(searchAdoptionStatus)
                                      select name;

            Array adoptionStatusArray = adoptionStatusQuery.ToArray();

            try
            {
                foreach (var result in adoptionStatusQuery)
                {
                    Console.WriteLine($"Narrowed results: {result}");
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
