using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowAdoptionFeeSearch
    {
        public void SearchByAdoptionFee(List<animal> arrayToNarrow)
        {
            Console.WriteLine("What adoption fee are you looking for?");
            string searchAdoptionFee = Console.ReadLine();
            
            var adoptionFeeQuery = from fee in arrayToNarrow
                                   where fee.adoption_fee.Contains(searchAdoptionFee)
                                   select fee;
            
            animal[] adoptionFeeSearchArray = adoptionFeeQuery.ToArray();

            try
            {
                if (adoptionFeeQuery.Count() < 1)
                {
                    Console.WriteLine("No results found.");
                    Console.ReadLine();
                }
                foreach (var result in adoptionFeeQuery)
                {
                    Console.WriteLine($"ID: {result.animal_id}, Name: {result.name}, age {result.age}");
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
            }

            // nothing found

            NarrowSearch narrowSearchDown = new NarrowSearch();
            narrowSearchDown.narrowOption(adoptionFeeSearchArray);
        }
    }
}
