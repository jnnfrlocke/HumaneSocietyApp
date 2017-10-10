﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSocietyApp
{
    public class NameSearch
    {
        public void SearchByName()
        {
            Console.WriteLine("Please enter the animal's name");
            string searchName = Console.ReadLine();

            HumaneSociety02DataContext db = new HumaneSociety02DataContext();

            IQueryable<animal> namesQuery =
                from animal in db.animals
                where animal.name == searchName
                select animal;// TODO: capture this in an array/list to use in a narrow by search

            Array namesArray = namesQuery.ToArray();

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

            NarrowSearch narrowSearchDown = new NarrowSearch();
            narrowSearchDown.narrowOption(namesArray);

            //return searchName;
        }
    }
}