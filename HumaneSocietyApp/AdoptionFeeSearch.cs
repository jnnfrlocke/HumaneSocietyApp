using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class AdoptionFeeSearch
    {
        public void SearchByAdoptionFee()
        {
            Console.WriteLine("What adoption fee are you looking for?");
            string searchAdoptionFee = Console.ReadLine();

            HSDataDataContext db = new HSDataDataContext();

            IQueryable<animal> adoptionFeeQuery =
                from animal in db.animals
                where animal.adoption_fee == searchAdoptionFee
                select animal;

            Array adoptionFeeSearchArray = adoptionFeeQuery.ToArray();
            
            try
            {
                if (adoptionFeeQuery.Count() < 1)
                {
                    Console.WriteLine("No results found.\nWould you like to modify an animal's record, exit the application, or start over? Type 1 to modify, 2 to exit, or 3 to start over.");
                    string adoptionFeeSearch = Console.ReadLine();

                    if (adoptionFeeSearch == "1")
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

                    else if (adoptionFeeSearch == "2")
                    {
                        Environment.Exit(0);
                    }
                    else if (adoptionFeeSearch == "3")
                    {
                        HumaneSociety startOver = new HumaneSociety();
                        startOver.Run();
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid option.");
                        SearchByAdoptionFee();
                    }
                    Console.WriteLine("No results found.");
                    Console.ReadLine();
                }
                foreach (var result in adoptionFeeQuery)
                {
                    Console.WriteLine($"Located {result.name}, {result.adoption_fee}, ID:{result.animal_id}, {result.species}, aged {result.age}");

                    NarrowSearch narrowSearchDown = new NarrowSearch();
                    narrowSearchDown.narrowOption(adoptionFeeSearchArray);
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
                SearchByAdoptionFee();
            }
        }
    }
}
