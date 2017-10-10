using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowAdoptionFeeSearch
    {
        public void SearchByAdoptionFee(List<string> arrayToNarrow)
        {
            Console.WriteLine("What adoption fee are you looking for?");
            string searchAdoptionFee = Console.ReadLine();
            
            var adoptionFeeQuery = from fee in arrayToNarrow
                                   where fee.Contains(searchAdoptionFee)
                                   select fee;



            //var adoptionFeeQuery =
            //    from animal in arrayToNarrow
            //    where animal.adoption_fee == searchAdoptionFee
            //    select animal;

            string[] adoptionFeeSearchArray = adoptionFeeQuery.ToArray();

            try
            {
                foreach (var result in adoptionFeeQuery)
                {
                    Console.WriteLine($"Narrowed results: {result}");
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
