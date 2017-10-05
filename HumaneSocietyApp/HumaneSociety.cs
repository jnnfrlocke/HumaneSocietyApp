using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class HumaneSociety
    {
        public void Run()
        {
            EmployeeOrAdopter();
        }

        public void EmployeeOrAdopter()
        {
            Console.WriteLine("Are you an employee or a potential adopter? Please type 'employee' or 'adopter'.");
            string userType = Console.ReadLine().ToLower();
            if (userType == "employee")
            {
                Employee newEmployee = new Employee();
                newEmployee.EmployeeOptions();
            }
            else if (userType == "adopter")
            {
                Adopter newAdopter = new Adopter();
                newAdopter.AdopterOptions();
            }
            else
            {
                Console.WriteLine("Please enter a valid option");
                EmployeeOrAdopter();
            }
        }

        

        
    }
}
