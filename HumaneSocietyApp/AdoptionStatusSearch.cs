using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    public class AdoptionStatusSearch
    {
        public void SearchByAdoptionStatus()
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
                SearchByAdoptionStatus();
            }


            HSDataDataContext db = new HSDataDataContext();

            IQueryable<animal> adoptionStatusQuery =
                from animal in db.animals
                where animal.is_adopted == adopted
                select animal;

            Array adoptionStatusArray = adoptionStatusQuery.ToArray();

            try
            {
                foreach (var result in adoptionStatusQuery)
                {
                    Console.WriteLine($"Located {searchAdoptionStatus} animals, ID: {result.animal_id}, {result.species}, {result.name}, aged {result.age}");
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
