using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class CodeClips
    {
        //    //End/Restart/Continue - EMPLOYEE
        //    public void EndRestartContinue()
        //    {
        //        Console.WriteLine("Would you like to narrow your search further? Type yes or no.");
        //        string continueSearching = Console.ReadLine().ToLower();

        //        if (continueSearching == "yes")
        //        {
        //            ContinueSearch continueSearchingNow = new ContinueSearch();
        //            continueSearchingNow.ContinueSearchMenu(listToNarrow);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Would you like to perform an action on an animal's record, exit the application, or start over? Type 1 to edit an animal's record, 2 to exit, or 3 to start over.");
        //            string endOrRestart = Console.ReadLine().ToLower();

        //            if (endOrRestart == "1")
        //            {
        //                Console.WriteLine("To edit an animal's species type 1, to change an animal's adoption status type 2, or to process an adoption fee type 3.");
        //                string actionToPerform = Console.ReadLine();

        //                switch (actionToPerform)
        //                {
        //                    case "1":
        //                        Animal changeSpecies = new Animal();
        //                        changeSpecies.ChangeSpecies();
        //                        break;
        //                    case "2":
        //                        Animal changeAdoptionStatus = new Animal();
        //                        changeAdoptionStatus.ChangeStatus();
        //                        break;
        //                    case "3":
        //                        Animal processAdoptionFee = new Animal();
        //                        processAdoptionFee.ProcessPayment();
        //                        break;
        //                    default:
        //                        Console.WriteLine("You entered an invalid option. Would you like to continue, exit the application or start over? Type 1 to continue, 2 to exit, or 3 to start over.");
        //                        string endNarrowSearch = Console.ReadLine();

        //                        if (endNarrowSearch == "1")
        //                        {
        //                            narrowOption(arrayToBeginNarrow); ;
        //                        }
        //                        else if (endNarrowSearch == "2")
        //                        {
        //                            Environment.Exit(0);
        //                        }
        //                        else if (endNarrowSearch == "3")
        //                        {
        //                            HumaneSociety startOver = new HumaneSociety();
        //                            startOver.Run();
        //                        }
        //                        else
        //                        {
        //                            Console.WriteLine("You did not enter a valid option.");
        //                            narrowOption(arrayToBeginNarrow);
        //                        }
        //                        break;
        //                }
        //            }

        //            else if (endOrRestart == "2")
        //            {
        //                Environment.Exit(0);
        //            }
        //            else if (endOrRestart == "3")
        //            {
        //                HumaneSociety startOver = new HumaneSociety();
        //                startOver.Run();
        //            }

        //            else
        //            {
        //                Console.WriteLine("You did not enter a valid option.");
        //                narrowOption(arrayToBeginNarrow);
        //            }
        //        }
        //    }

        //    //If no results
        //    public void NoResults()//in top of try
        //    {
        //        if (adoptionFeeQuery.Count() < 1)
        //        {
        //            Console.WriteLine("No results found.");
        //            Console.ReadLine();
        //        }
        //    }

        //    public void GoesAfterTry()
        //    {
        //        if (ageQuery.Count() < 1)
        //            Console.WriteLine("No results found.\nWould you like to modify an animal's record, exit the application, or start over? Type 1 to modify, 2 to exit, or 3 to start over.");
        //        string narrowAgeSearch = Console.ReadLine();

        //        if (narrowAgeSearch == "1")
        //        {
        //            Console.WriteLine("To edit an animal's species type 1, to change an animal's adoption status type 2, or to process an adoption fee type 3.");
        //            string actionToPerform = Console.ReadLine();

        //            switch (actionToPerform)
        //            {
        //                case "1":
        //                    Animal changeSpecies = new Animal();
        //                    changeSpecies.ChangeSpecies();
        //                    break;
        //                case "2":
        //                    Animal changeAdoptionStatus = new Animal();
        //                    changeAdoptionStatus.ChangeStatus();
        //                    break;
        //                case "3":
        //                    Animal processAdoptionFee = new Animal();
        //                    processAdoptionFee.ProcessPayment();
        //                    break;
        //                default:
        //                    break;
        //            }
        //        }

        //        else if (narrowAgeSearch == "2")
        //        {
        //            Environment.Exit(0);
        //        }
        //        else if (narrowAgeSearch == "3")
        //        {
        //            HumaneSociety startOver = new HumaneSociety();
        //            startOver.Run();
        //        }
        //        else
        //        {
        //            Console.WriteLine("You did not enter a valid option.");
        //            SearchByAge(listToNarrow);
        //        }

        //        foreach (var result in ageQuery)
        //        {
        //            Console.WriteLine($"Located {result.name}, ID:{result.animal_id}, {result.species}, aged {result.age}");

        //            NarrowSearch narrowSearchDown = new NarrowSearch();
        //            narrowSearchDown.narrowOption(ageArray);
        //        }
        //    }
    }




}
    

