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
            Console.WriteLine("Please type the task you need to access:\nTo add an animal, type 1.\nTo see which room an animal is located in, type 2.\nTo find out if an animal has had its vaccinations, type 3.\nTo view the amount of food an animal needs, type 4.\nTo view or change an animal's species, type 5.\nTo change an animal's adoption status, type 6.\nTo process an adoption fee payment, type 7.\nTo start over, type restart.");
            string task = Console.ReadLine();
            switch (task)
            {
                case "1":
                    newAnimal.Add();
                    break;
                case "2":
                    newAnimal.Location();
                    break;
                case "3":
                    newAnimal.CheckVaccinationStatus();
                    break;
                case "4":
                    newAnimal.Food();
                    break;
                case "5":
                    newAnimal.CheckSpecies();
                    break;
                case "6":
                    newAnimal.ChangeStatus(task);
                    break;
                case "7":
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
    }
}
