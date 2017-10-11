using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class NarrowAdoptionStatusSearch
    {
        public void SearchByAdoptionStatus(List<animal> listToNarrow)
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
                SearchByAdoptionStatus(listToNarrow);
            }
            
            var adoptionStatusQuery = from status in listToNarrow
                                      where status.is_adopted.Contains(searchAdoptionStatus)
                                      select status;

            Array adoptionStatusArray = adoptionStatusQuery.ToArray();

            try
            {
                if (adoptionStatusQuery.Count() < 1)
                    Console.WriteLine("No results found.\nWould you like to modify an animal's record, exit the application, or start over? Type 1 to modify, 2 to exit, or 3 to start over.");
                string adoptionStatusSearch = Console.ReadLine();

                if (adoptionStatusSearch == "1")
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

                else if (adoptionStatusSearch == "2")
                {
                    Environment.Exit(0);
                }
                else if (adoptionStatusSearch == "3")
                {
                    HumaneSociety startOver = new HumaneSociety();
                    startOver.Run();
                }
                else
                {
                    Console.WriteLine("You did not enter a valid option.");
                    SearchByAdoptionStatus(listToNarrow);
                }

                foreach (var result in adoptionStatusQuery)
                {
                    Console.WriteLine($"ID: {result.animal_id}, Name: {result.name}, age {result.age}");

                    NarrowSearch narrowSearchDown = new NarrowSearch();
                    narrowSearchDown.narrowOption(adoptionStatusArray);
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
            }   
        }
    }
}
