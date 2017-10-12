using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace HumaneSocietyApp
{
    public class HumaneSociety
    {
        public void Run()
        {
            ImportCSV();
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

        public void ImportCSV() 
        {
            string filePath = "C:/Users/jnnfr/Documents/Visual Studio 2015/Projects/HumaneSociety/HumaneSocietyApp/animals.csv";

            var animalList = File.ReadLines(filePath).Select(file => file.Split(',')).ToList();

            foreach (var item in animalList) {

                animal importAnimalCsv = new animal();
                
                importAnimalCsv.name = item[0]; 
                importAnimalCsv.species = item[1];
                importAnimalCsv.is_vaccinated = item[2];
                importAnimalCsv.amount_of_food = item[3];
                importAnimalCsv.room = item[4];
                importAnimalCsv.is_adopted = item[5];
                importAnimalCsv.adoption_fee = item[6];
                importAnimalCsv.special_needs = item[7];
                importAnimalCsv.age = item[8];

                HSDataDataContext db = new HSDataDataContext();

                db.animals.InsertOnSubmit(importAnimalCsv);
                db.SubmitChanges();
            }
        }
    }
}
