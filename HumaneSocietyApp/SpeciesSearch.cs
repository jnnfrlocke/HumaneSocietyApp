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

            HSDataDataContext db = new HSDataDataContext();

            IQueryable<animal> speciesQuery =
                from animal in db.animals
                where animal.species == searchSpecies
                select animal;

            Array speciesArray = speciesQuery.ToArray();

            try
            {
                if (speciesQuery.Count() < 1)
                {
                    Console.WriteLine("No results found.\nWould you like to modify an animal's record, exit the application, or start over? Type 1 to modify, 2 to exit, or 3 to start over.");
                    string speciesSearch = Console.ReadLine();

                    if (speciesSearch == "1")
                    {
                        Console.WriteLine("To edit an animal's species type 1, to change an animal's adoption status type 2, or to process an adoption fee type 3.");
                        string actionToPerform = Console.ReadLine();

                        switch (actionToPerform)
                        {
                            case "1":
                                Animal changeSpecies = new Animal();
                                changeSpecies.ChangeSpecies();
                                break;
                            case "2":
                                Animal changeAdoptionStatus = new Animal();
                                changeAdoptionStatus.ChangeStatus();
                                break;
                            case "3":
                                Animal processAdoptionFee = new Animal();
                                processAdoptionFee.ProcessPayment();
                                break;
                            default:
                                break;
                        }
                    }

                    else if (speciesSearch == "2")
                    {
                        Environment.Exit(0);
                    }
                    else if (speciesSearch == "3")
                    {
                        HumaneSociety startOver = new HumaneSociety();
                        startOver.Run();
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid option.");
                        SearchBySpecies();
                    }

                }
                foreach (var result in speciesQuery)
                {
                    Console.WriteLine($"Located {searchSpecies}, ID:{result.animal_id}, {result.name}, aged {result.age}");

                    NarrowSearch narrowSearchDown = new NarrowSearch();
                    narrowSearchDown.narrowOption(speciesArray);
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
                SearchBySpecies();
            }
        }
    }
}
