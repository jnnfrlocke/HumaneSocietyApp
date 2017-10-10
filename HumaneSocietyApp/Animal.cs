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

        // Add options end here

        public void ChangeSpecies()
        {
            Console.WriteLine("You need the animal's ID to update its species. If you need to search for the animal, type 'search'. To continue, press enter.");
            string needToSearch = Console.ReadLine();

            if (needToSearch == "search")
            {
                Search startSearch = new Search();
                startSearch.SearchMenu();
            }

            Console.WriteLine("Enter the ID of the animal whose species you wish to change.");
            int searchID = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the species of this animal?");
            string newSpeciesValue = Console.ReadLine();

            HumaneSociety02DataContext db = new HumaneSociety02DataContext();

            IQueryable<animal> changeSpeciesQuery =
                from animal in db.animals
                where animal.animal_id == searchID
                select animal;

            foreach (animal animal in changeSpeciesQuery)
            {
                animal.species = newSpeciesValue;
                db.SubmitChanges();
            }

        }

        public void ChangeStatus(string task)
        {
            Console.WriteLine("You need the animal's ID to update its adoption status. If you need to search for the animal, type 'search'. To continue, press enter.");
            string needToSearch = Console.ReadLine();

            if (needToSearch == "search")
            {
                Search startSearch = new Search();
                startSearch.SearchMenu();
            }

            Console.WriteLine("Enter the ID of the animal whose adoption status you wish to change.");
            int searchID = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the adoption status of this animal?");
            string newStatusValue = Console.ReadLine();

            HumaneSociety02DataContext db = new HumaneSociety02DataContext();

            IQueryable<animal> changeStatusQuery =
                from animal in db.animals
                where animal.animal_id == searchID
                select animal;

            foreach (animal animal in changeStatusQuery)
            {
                animal.is_adopted = newStatusValue;
                db.SubmitChanges();
            }
        }

        public void ProcessPayment()
        {
            int newFee;
            Console.WriteLine("You need the animal's ID to process an adoption fee payment. If you need to search for the animal, type 'search'. To continue, press enter.");
            string needToSearch = Console.ReadLine();

            if (needToSearch == "search")
            {
                Search startSearch = new Search();
                startSearch.SearchMenu();
            }

            Console.WriteLine("Enter the ID of the animal whose adoption fee you wish to process.");
            int searchID = int.Parse(Console.ReadLine());

            Console.WriteLine("Is the adopter paying the full fee? Type 'yes' or 'no'.");
            string newFeeValue = Console.ReadLine();

            if (newFeeValue == "yes")
            {
                newFee = 0;
                HumaneSociety02DataContext db = new HumaneSociety02DataContext();

                IQueryable<animal> changeFeeQuery =
                    from animal in db.animals
                    where animal.animal_id == searchID
                    select animal;

                foreach (animal animal in changeFeeQuery)
                {
                    animal.adoption_fee = newFee;
                    db.SubmitChanges();
                }
            }
            else if (newFeeValue == "no")
            {
                Console.WriteLine("This transaction needs a supervisor's approval. To enter a supervisor's code, type 1. To exit the application, type 2. To begin again, type 3");
                int supervisorApproval = int.Parse(Console.ReadLine());

                if (supervisorApproval == 1)
                {
                    //do supervisor thing
                }
                else if (supervisorApproval == 2)
                {
                    Environment.Exit(0);
                }
                else if (supervisorApproval == 3)
                {
                    HumaneSociety startOver = new HumaneSociety();
                    startOver.Run();
                }
            }
            else
            {
                Console.WriteLine("You entered an invalid option.");
                ProcessPayment();
            }

            
        }





        //public void Location()
        //{

        //}

        //public void CheckVaccinationStatus()
        //{

        //}

        //public void Food()
        //{

        //}
        
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
