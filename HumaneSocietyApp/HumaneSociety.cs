using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.IO;

namespace HumaneSocietyApp
{
    class HumaneSociety
    {
        public void Run()
        {
            ImportCSV();
            //EmployeeOrAdopter();
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
            string connectionString = "Server=GUMBY;Database=HumaneSociety;Integrated Security=true";

            using (SqlConnection OpeningConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand importAnimalCSV = OpeningConnection.CreateCommand())
                {
                    importAnimalCSV.CommandText = "bulk insert animal from 'C:/Users/jnnfr/Documents/Visual Studio 2015/Projects/HumaneSociety/HumaneSocietyApp/animals.csv' with (firstrow = 2, fieldterminator = ',', rowterminator = '\n', tablock)";

                    OpeningConnection.Open();
                    importAnimalCSV.ExecuteNonQuery();
                    OpeningConnection.Close();

                }
            }
          }

        public void ImportCSVWithLinq ()
        {
            string animalFile = "C:/Users/jnnfr/Documents/Visual Studio 2015/Projects/HumaneSociety/HumaneSocietyApp/animals.csv";
            string[] animalLines = File.ReadAllLines(animalFile);
        }



    }
}
