using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace HumaneSocietyApp
{
    
    public class Search
    {

        public string SearchMenu()
        {
            Console.WriteLine("Which trait would you like to search by?\nPlease enter one of the following:\nID\nName\nSpecies\nAdoption Status\nSpecial Needs\nAge\nAdoptionFee\nLocation\nVaccination Status");
            string searchType = Console.ReadLine().ToLower();

            switch (searchType)
            {
                case "name":
                    SearchByName();
                    break;
                case "species":
                    SearchBySpecies();
                    break;
                case "adoption status":
                    SearchByAdoptionStatus();
                    break;
                case "special needs":
                    SearchBySpecialNeeds();
                    break;
                case "age":
                    SearchByAge();
                    break;
                case "adoption fee":
                    SearchByAdoptionFee();
                    break;
                case "location":
                    SearchByLocation();
                    break;
                case "vaccination status":
                    SearchByVaccinationStatus();
                    break;
                default:
                    Console.WriteLine("Please type a valid entry.");
                    SearchMenu();
                    break;
            }
            return searchType;

        }

        public void SearchByName()
        {
            Console.WriteLine("Please enter the animal's name");
            string searchName = Console.ReadLine();

            HumaneSocietyDataContext db = new HumaneSocietyDataContext();

            IQueryable<animal> namesQuery =
                from animal in db.animals
                where animal.name == searchName
                select animal;
            
            try
            {
                foreach (var result in namesQuery)
                {
                    Console.WriteLine($"Located {searchName}, ID :{result.animal_id}, {result.species}, aged {result.age}");
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
            }
            
            Console.WriteLine("Would you like to narrow your search further? Type yes or no.");
            string continueSearching = Console.ReadLine();

            //return searchName;
        }



        public void SearchBySpecies()
        {
            Console.WriteLine("Please enter a species.");
            string searchSpecies = Console.ReadLine();

            HumaneSocietyDataContext db = new HumaneSocietyDataContext();

            IQueryable<animal> speciesQuery =
                from animal in db.animals
                where animal.species == searchSpecies
                select animal;// TODO: capture this in an array/list to use in a narrow by search

            try
            {
                foreach (var result in speciesQuery)
                {
                    Console.WriteLine($"Located {searchSpecies}, ID :{result.animal_id}, {result.name}, aged {result.age}");
                }
            }
            catch (InvalidCastException)
            {
                Console.WriteLine("Excpetion in Query...");
            }

            Console.WriteLine("Would you like to narrow your search further? Type yes or no.");
            string continueSearching = Console.ReadLine();

        }

        public void SearchByAdoptionStatus()
        {
            Console.WriteLine("Are you looking for adopted animals or animals waiting for adoption? Please enter adopted or waiting.");
            string searchAdoptionStatus = Console.ReadLine();
        }

        public void SearchBySpecialNeeds()
        {
            Console.WriteLine("Are you looking for animals with special needs?");
            string searchSpecialNeeds = Console.ReadLine();
        }

        public void SearchByAge()
        {
            Console.WriteLine("What age would you like to search for?");
            string searchAge = Console.ReadLine();
        }

        public void SearchByAdoptionFee()
        {

        }

        public void SearchByLocation()
        {

        }

        public void SearchByVaccinationStatus()
        {

        }
    }




}
