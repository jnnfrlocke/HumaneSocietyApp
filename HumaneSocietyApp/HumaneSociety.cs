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

        }

        public void EmployeeOrAdopter()
        {
            Console.WriteLine("Are you an employee or a potential adopter? Please type 'employee' or 'adopter'.");
            string userType = Console.ReadLine();
            if (userType == "employee")
            {
                EmployeeOptions();
            }
            else if (userType == "adopter")
            {
                AdopterOptions();
            }
            else
            {
                Console.WriteLine("Please enter a valid option");
                EmployeeOrAdopter();
            }
        }

        public void EmployeeOptions()
        {

        }

        public void AdopterOptions()
        {

        }
    }
}
