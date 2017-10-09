using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    public class Animal
    {
        string addName;
        string speciesToAdd;
        string vaccinationAnswer;
        double foodPerWeek;
        string locationToAdd;
        string adoptionStatus;
        int adoptionFee;
        string specialNeeds;
        string age;

        public void Add()
        {
            addName = GetName();
            speciesToAdd = GetSpecies();
            vaccinationAnswer = GetVaccination();
            foodPerWeek = GetFood();
            locationToAdd = GetLocation();
            adoptionStatus = GetAdoptionStatus();
            adoptionFee = GetAdoptionFee();
            specialNeeds = GetSpecialNeeds();
            age = GetAge();

            animal animalToInsert = new animal
            {
                name = addName,
                species = speciesToAdd,
                is_vaccinated = vaccinationAnswer,
                amount_of_food = foodPerWeek,
                room = locationToAdd,
                is_adopted = adoptionStatus,
                adoption_fee = adoptionFee,
                special_needs = specialNeeds,
                age = age 
            };

            HumaneSociety02DataContext addAnimal = new HumaneSociety02DataContext();

            addAnimal.animals.InsertOnSubmit(animalToInsert);
            addAnimal.SubmitChanges();
        }

        private string GetName()
        {
            Console.WriteLine("What's the animal's name?");
            string addName = Console.ReadLine();
            return addName;
        }

        public string GetSpecies()
        {
            //Search newSearch = new Search();
            //string searchField = newSearch.SearchMenu();
            Console.WriteLine("Please type the animal's species.");
            string speciesToAdd = Console.ReadLine();
            return speciesToAdd;
        }

        private string GetVaccination()
        {
            Console.WriteLine("Is this animal vaccinated?");
            string vaccinationAnswer = Console.ReadLine();
            return vaccinationAnswer;
        }

        private double GetFood()
        {
            Console.WriteLine("How much food does this animal eat per week, in cups?");
            double foodPerWeek = double.Parse(Console.ReadLine());
            return foodPerWeek;
        }

        private string GetLocation()
        {

            Console.WriteLine("What room is this animal in?");
            string locationToAdd = Console.ReadLine();
            return locationToAdd;
        }

        private string GetAdoptionStatus()
        {
            Console.WriteLine("Has this animal been adopted?");
            string adoptionStatus = Console.ReadLine();
            return adoptionStatus;
        }

        private int GetAdoptionFee()
        {
            Console.WriteLine("What is this animal's adoption fee?");
            int adoptionFee = int.Parse(Console.ReadLine());
            return adoptionFee;
        }

        private string GetSpecialNeeds()
        {
            Console.WriteLine("What kind of special needs does this animal have?");
            string specialNeeds = Console.ReadLine();
            return specialNeeds;
        }

        private string GetAge()
        {
            Console.WriteLine("How old is this animal?");
            string age = Console.ReadLine();
            return age;
        }
        

        public void ChangeStatus()
        {
            Search newSearch = new Search();
            string searchField = newSearch.SearchMenu();



            //GetAdoptionStatus();

            var animalStatus = new animal();
            //var statusChangeAnimal = animalStatus.Where(searchField.is_adopted == "no" ) TODO change adopted status 
        }

        public void Location()
        {

        }

        public void CheckVaccinationStatus()
        {

        }

        public void Food()
        {

        }

        public void CheckSpecies()
        {

        }

        public void ProcessPayment()
        {

        }


        //public void ShowAnimal() TODO: string concatenation
        //{
        //    Console.WriteLine("Name: " + animal.name);
        //    Console.WriteLine("Species: " + animal.species);
        //    Console.WriteLine("Vaccinated: " + animal.is_vaccinated);
        //    Console.WriteLine("Amount of Food: " + animal.amount_of_food);
        //    Console.WriteLine("Location: " + animal.room);
        //    Console.WriteLine("Adopted: " + animal.is_adopted);
        //    Console.WriteLine("Adoption Fee: " + animal.adoption_fee);
        //    Console.WriteLine("Special Needs: " + animal.special_needs);
        //    Console.WriteLine("Age: " + animal.age);
        //}


    }
}
