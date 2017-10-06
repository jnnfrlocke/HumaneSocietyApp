using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    class Animal
    {
        public void Add()
        {
            List<string> animalToAdd = new List<string>();

            Console.WriteLine("What's the animal's name?");
            string addName = Console.ReadLine();
            animalToAdd.Add(addName);

            Console.WriteLine("Please type the animal's species.");
            string speciesToAdd = Console.ReadLine();
            animalToAdd.Add(speciesToAdd);

            Console.WriteLine("Is this animal vaccinated?");
            string vaccinationAnswer = Console.ReadLine();
            animalToAdd.Add(vaccinationAnswer);

            Console.WriteLine("How much food does this animal eat per week, in cups?");
            double foodPerWeek = double.Parse(Console.ReadLine());
            //animalToAdd.Add(foodPerWeek);

            Console.WriteLine("What room is this animal in?");
            string locationToAdd = Console.ReadLine();
            animalToAdd.Add(locationToAdd);

            Console.WriteLine("Has this animal been adopted?");
            string adoptionStatus = Console.ReadLine();
            animalToAdd.Add(adoptionStatus);

            Console.WriteLine("What is this animal's adoption fee?");
            int adoptionFee = int.Parse(Console.ReadLine());
            //animalToAdd.Add(adoptionFee);

            Console.WriteLine("What kind of special needs does this animal have?");
            string specialNeeds = Console.ReadLine();
            animalToAdd.Add(specialNeeds);

            Console.WriteLine("How old is this animal?");
            int age = int.Parse(Console.ReadLine());
            //animalToAdd.Add(age);

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
                age = age,
            };

            HumaneSocietyDBDataContext addAnimal = new HumaneSocietyDBDataContext();

            addAnimal.animals.InsertOnSubmit(animalToInsert);
            addAnimal.SubmitChanges();
        }

        public void ChangeStatus()
        {

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
    }
}
