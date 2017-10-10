using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    public class SpeciesSearch
    {
        public void SearchBySpecies()
        {
            Console.WriteLine("Please enter a species.");
            string searchSpecies = Console.ReadLine();

            HumaneSociety02DataContext db = new HumaneSociety02DataContext();

            IQueryable<animal> speciesQuery =
                from animal in db.animals
                where animal.species == searchSpecies
                select animal;// TODO: capture this in an array/list to use in a narrow by search

            try
            {
                foreach (var result in speciesQuery)
                {
                    Console.WriteLine($"Located {searchSpecies}, ID :{result.animal_id}, {result.name}, aged {result.age}");
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
            }

            Console.WriteLine("Would you like to narrow your search further? Type yes or no.");
            string continueSearching = Console.ReadLine();

        }
    }
}
