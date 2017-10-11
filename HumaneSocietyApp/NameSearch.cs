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

            Array namesArray = namesQuery.ToArray();

            try
            {
                if (namesQuery.Count() < 1)
                {
                    Console.WriteLine("No results found.\nWould you like to modify an animal's record, exit the application, or start over? Type 1 to modify, 2 to exit, or 3 to start over.");
                    string nameSearch = Console.ReadLine();

                    if (nameSearch == "1")
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

                    else if (nameSearch == "2")
                    {
                        Environment.Exit(0);
                    }
                    else if (nameSearch == "3")
                    {
                        HumaneSociety startOver = new HumaneSociety();
                        startOver.Run();
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid option.");
                        SearchByName();
                    }
                }
                foreach (var result in namesQuery)
                {
                    Console.WriteLine($"Located {searchName}, ID:{result.animal_id.ToString()}, {result.species}, aged {result.age}");

                    NarrowSearch narrowSearchDown = new NarrowSearch();
                    narrowSearchDown.narrowOption(namesArray);
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
            }
        }
    }
}
