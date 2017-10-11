using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    public class SpecialNeedsSearch
    {
        public void SearchBySpecialNeeds()
        {
            Console.WriteLine("Are you looking for animals with special needs? Type yes or no.");
            string searchSpecialNeeds = Console.ReadLine();

            HSDataDataContext db = new HSDataDataContext();

            IQueryable<animal> specialNeedsQuery =
                from animal in db.animals
                where animal.special_needs == searchSpecialNeeds
                select animal;

            Array specialNeedsArray = specialNeedsQuery.ToArray();

            try
            {
                if (specialNeedsQuery.Count() < 1)
                {
                    Console.WriteLine("No results found.\nWould you like to modify an animal's record, exit the application, or start over? Type 1 to modify, 2 to exit, or 3 to start over.");
                    string specialNeedsSearch = Console.ReadLine();

                    if (specialNeedsSearch == "1")
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

                    else if (specialNeedsSearch == "2")
                    {
                        Environment.Exit(0);
                    }
                    else if (specialNeedsSearch == "3")
                    {
                        HumaneSociety startOver = new HumaneSociety();
                        startOver.Run();
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid option.");
                        SearchBySpecialNeeds();
                    }
                }
                foreach (var result in specialNeedsQuery)
                {
                    Console.WriteLine($"Located {result.name}, ID:{result.animal_id}, {result.species}, aged {result.age}");

                    NarrowSearch narrowSearchDown = new NarrowSearch();
                    narrowSearchDown.narrowOption(specialNeedsArray);
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
                SearchBySpecialNeeds();
            }
        }
    }
}
