using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HumaneSocietyApp
{
    public class Employee
    {
        public void EmployeeOptions()
        {
            Animal newAnimal = new Animal();
            Search newSearch = new Search();

            Console.WriteLine("Please type the task you need to access:\nTo add an animal, type 1.\nTo see which room an animal is located in, type 2.\nTo find out if an animal has had its vaccinations, type 3.\nTo view the amount of food an animal needs, type 4.\nTo view or change an animal's species, type 5.\nTo change an animal's adoption status, type 6.\nTo process an adoption fee payment, type 7.\nTo start over, type restart.");
            string task = Console.ReadLine();
            switch (task)
            {
                case "1":
                    newAnimal.Add();
                    break;
                case "2":
                    newSearch.SearchMenu();
                    break;
                case "3":
                    newSearch.SearchMenu();
                    break;
                case "4":
                    newSearch.SearchMenu();
                    break;
                case "5":
                    newSearch.SearchMenu();
                    break;
                case "6":
                    newSearch.SearchMenu();
                    break;
                case "7":
                    newSearch.SearchMenu();
                    break;
                case "restart":
                    HumaneSociety newHS = new HumaneSociety();
                    newHS.EmployeeOrAdopter();
                    break;
                default:
                    Console.WriteLine("You did not type a valid entry. Would you like to continue, exit the application, or start over? Type 1 to continue, 2 to exit, or 3 to start over.");
                    string endEmployeeMenu = Console.ReadLine();

                    if (endEmployeeMenu == "1")
                    {
                        EmployeeOptions();
                    }
                    else if (endEmployeeMenu == "2")
                    {
                        Environment.Exit(0);
                    }
                    else if (endEmployeeMenu == "3")
                    {
                        HumaneSociety startOver = new HumaneSociety();
                        startOver.Run();
                    }
                    else
                    {
                        Console.WriteLine("You did not enter a valid option.");
                        EmployeeOptions();
                    }

                    break;
            } 
        }
    }
}
