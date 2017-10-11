using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowAgeSearch
    {
        public void SearchByAge(List<animal> listToNarrow)
        {
            Console.WriteLine("What age would you like to search for?");
            string searchAge = Console.ReadLine();

            var ageQuery = from age in listToNarrow
                           where age.age.Contains(searchAge)
                           select age;

            Array ageArray = ageQuery.ToArray();

            try
            {
                if (ageQuery.Count() < 1)
                    Console.WriteLine("No results found.\nWould you like to modify an animal's record, exit the application, or start over? Type 1 to modify, 2 to exit, or 3 to start over.");
                string narrowAgeSearch = Console.ReadLine();

                if (narrowAgeSearch == "1")
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

                else if (narrowAgeSearch == "2")
                {
                    Environment.Exit(0);
                }
                else if (narrowAgeSearch == "3")
                {
                    HumaneSociety startOver = new HumaneSociety();
                    startOver.Run();
                }
                else
                {
                    Console.WriteLine("You did not enter a valid option.");
                    SearchByAge(listToNarrow);
                }
            
                foreach (var result in ageQuery)
            {
                Console.WriteLine($"Located {result.name}, ID:{result.animal_id}, {result.species}, aged {result.age}");

                NarrowSearch narrowSearchDown = new NarrowSearch();
                narrowSearchDown.narrowOption(ageArray);
            }
        
                foreach (var result in ageQuery)
                {
                    Console.WriteLine($"ID: {result.animal_id}, Name: {result.name}, age {result.age}");

                    NarrowSearch narrowSearchDown = new NarrowSearch();
                    narrowSearchDown.narrowOption(ageArray);
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
                SearchByAge(listToNarrow);
            }
        }
    }
}
