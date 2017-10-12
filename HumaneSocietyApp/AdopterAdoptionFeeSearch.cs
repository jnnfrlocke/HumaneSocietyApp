using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class AdopterAdoptionFeeSearch
    {
        public void SearchByAdoptionFee(List<animal> listToNarrow)
        {
            Console.WriteLine("What adoption fee would you like to pay?");
            string searchAdoptionFee = Console.ReadLine();

            var adoptionFeeQuery =
                from animal in listToNarrow
                where animal.adoption_fee == searchAdoptionFee
                select animal;

            List<animal> adopterAdoptionFeeList = adoptionFeeQuery.ToList();

            try
            {
                if (adoptionFeeQuery.Count() < 1)
                {
                    Console.WriteLine("No results found.\nWould you like to exit the application or start over? Type 1 to exit or 2 to start over.");
                    string adoptionFeeSearch = Console.ReadLine();

                    if (adoptionFeeSearch == "1")
                    {
                        Environment.Exit(0);
                    }
                    else if (adoptionFeeSearch == "2")
                    {
                        HumaneSociety startOver = new HumaneSociety();
                        startOver.Run();
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid option.");
                        SearchByAdoptionFee(listToNarrow);
                    }
                }
                    foreach (var result in adoptionFeeQuery)
                    {
                        Console.WriteLine($"Located {searchAdoptionFee}, ID:{result.animal_id}, {result.name}, aged {result.age}");
                    }
                
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
                SearchByAdoptionFee(listToNarrow);
            }
            AdopterNarrowSearch narrowSearchDown = new AdopterNarrowSearch();
            narrowSearchDown.adopterNarrowOption(adopterAdoptionFeeList);
        }
    }
}
