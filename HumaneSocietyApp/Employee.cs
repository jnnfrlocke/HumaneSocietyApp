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
            Console.WriteLine("Please type the task you need to access:\nTo add an animal, type add.\nTo change an animal's adoption status, type status.\nTo see which room an animal is located in, type location.\nTo find out if an animal has had its vaccinations, type vaccinations.\nTo track the amount of food an animal needs, type food.\nTo view or change an animals category, type species.\nTo process an adoption fee payment, type payment.\nTo go back to the beginning, type restart.");
            string task = Console.ReadLine();
            switch (task)
            {
                case "add":
                    newAnimal.Add();
                    break;
                case "status":
                    newAnimal.ChangeStatus();
                    break;
                case "location":
                    newAnimal.Location();
                    break;
                case "vaccinations":
                    newAnimal.CheckVaccinationStatus();
                    break;
                case "food":
                    newAnimal.Food();
                    break;
                case "species":
                    newAnimal.CheckSpecies();
                    break;
                case "payment":
                    newAnimal.ProcessPayment();
                    break;
                case "restart":
                    HumaneSociety newHS = new HumaneSociety();
                    newHS.EmployeeOrAdopter();
                    break;
                default:
                    Console.WriteLine("You did not type a valid entry.");
                    EmployeeOptions();
                    break;

            } 
        }

        

        public void Search()
        {

        }

        
    }
}
