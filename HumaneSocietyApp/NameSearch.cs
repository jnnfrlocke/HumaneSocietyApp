using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    public class NameSearch
    {
        public void SearchByName()
        {
            Console.WriteLine("Please enter the animal's name");
            string searchName = Console.ReadLine();

            HSDataDataContext db = new HSDataDataContext();

            IQueryable<animal> namesQuery =
                from animal in db.animals
                where animal.name == searchName
                select animal;

            

            try
            {
                foreach (var result in namesQuery)
                {
                    Console.WriteLine($"Located {searchName}, ID:{result.animal_id.ToString()}, {result.species}, aged {result.age}");
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
            }

            //need something for if no results

            Array namesArray = namesQuery.ToArray();

            NarrowSearch narrowSearchDown = new NarrowSearch();
            narrowSearchDown.narrowOption(namesArray);
        }
    }
}
