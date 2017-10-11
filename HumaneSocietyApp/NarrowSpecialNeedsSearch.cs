using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowSpecialNeedsSearch
    {
        public void SearchBySpecialNeeds(List<animal> listToNarrow)
        {
            Console.WriteLine("Are you looking for animals with special needs? Type yes or no.");
            string searchSpecialNeeds = Console.ReadLine();

            var specialNeedsQuery = from needs in listToNarrow
                                    where needs.special_needs.Contains(searchSpecialNeeds)
                                    select needs;

            Array specialNeedsArray = specialNeedsQuery.ToArray();

            try
            {
                if (specialNeedsQuery.Count() < 1)
                    Console.WriteLine("No results found.\nWould you like to modify an animal's record, exit the application, or start over? Type 1 to modify, 2 to exit, or 3 to start over.");
                string narrowSpecialNeedsSearch = Console.ReadLine();

                if (narrowSpecialNeedsSearch == "1")
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

                else if (narrowSpecialNeedsSearch == "2")
                {
                    Environment.Exit(0);
                }
                else if (narrowSpecialNeedsSearch == "3")
                {
                    HumaneSociety startOver = new HumaneSociety();
                    startOver.Run();
                }
                else
                {
                    Console.WriteLine("You did not enter a valid option.");
                    SearchBySpecialNeeds(listToNarrow);
                }
                
                foreach (var result in specialNeedsQuery)
                {
                    Console.WriteLine($"ID: {result.animal_id}, Name: {result.name}, age {result.age}");

                    NarrowSearch narrowSearchDown = new NarrowSearch();
                    narrowSearchDown.narrowOption(specialNeedsArray);
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
            }
        }
    }
}
