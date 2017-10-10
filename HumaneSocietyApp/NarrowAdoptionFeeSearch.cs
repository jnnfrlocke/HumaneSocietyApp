using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowAdoptionFeeSearch
    {
        public void SearchByAdoptionFee()// pass in array created by previous search
        {
            Console.WriteLine("What adoption fee are you looking for?");
            float searchAdoptionFee = float.Parse(Console.ReadLine());

            HumaneSociety02DataContext db = new HumaneSociety02DataContext();

            IQueryable<animal> adoptionFeeQuery =
                from animal in db.animals
                where animal.adoption_fee == searchAdoptionFee
                select animal;

            Array namesArray = adoptionFeeQuery.ToArray();

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
            narrowSearchDown.narrowOption(namesArray);
        }
    }
}
