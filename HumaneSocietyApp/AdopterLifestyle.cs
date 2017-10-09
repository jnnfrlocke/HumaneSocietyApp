using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    public class AdopterLifestyle
    {
        int timeHome;
        string trained;
        string veterinarianCost;

        public void GetLifestyle()
        {

            timeHome = GetTimeHome();
            trained = GetTraining();
            veterinarianCost = GetVeterinarianCost();

            lifestyle newLifestyle = new lifestyle()
            {
                time_home = timeHome,
                training = trained,
                veterinarian_cost = veterinarianCost
            };

        HumaneSociety02DataContext addLifestyle = new HumaneSociety02DataContext();

            addLifestyle.lifestyles.InsertOnSubmit(newLifestyle);
            addLifestyle.SubmitChanges();
        }

        public int GetTimeHome()
        {
            Console.WriteLine("About how much time are you able to spend with your new pet per week?");
            return int.Parse(Console.ReadLine());
        }

        private string GetTraining()
        {
            Console.WriteLine("Would you prefer your pet to be trained or are you willing to train the pet yourself (if applicable).\nPlease type 'already trained', 'willing to train', or 'not applicable'.");
            return Console.ReadLine();
        }

        private string GetVeterinarianCost()
        {
            Console.WriteLine("Do you have a budget or are you prepared to set aside for veterinarian visits?");
            return Console.ReadLine();
        }
    }
}
