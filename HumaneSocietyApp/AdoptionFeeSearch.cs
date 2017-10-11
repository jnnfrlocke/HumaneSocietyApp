using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class AdoptionFeeSearch
    {
        public void SearchByAdoptionFee()
        {
            Console.WriteLine("What adoption fee are you looking for?");
            string searchAdoptionFee = Console.ReadLine();

            HSDataDataContext db = new HSDataDataContext();

            IQueryable<animal> adoptionFeeQuery =
                from animal in db.animals
                where animal.adoption_fee == searchAdoptionFee
                select animal;

            Array adoptionFeeSearchArray = adoptionFeeQuery.ToArray();
            
            try
            {
                foreach (var result in adoptionFeeQuery)
                {
                    Console.WriteLine($"Located {result.name}, {result.adoption_fee}, ID:{result.animal_id}, {result.species}, aged {result.age}");
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
