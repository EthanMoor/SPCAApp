using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SPCAAppGui
{
    public class Animal
    {
        // Access Modifiers - public / private / protected
        private string name;
        private string species;
        
        private readonly Dictionary<DateTime, int> animalConsumption = new Dictionary<DateTime, int>();

        private int id;

        // Constructor - Constructs an object by assigning values to the propities

        public Animal(string nme, string spcs)
        {
            name = nme;
            species = spcs;
        }


        // Get Methods - Returns the value stored in a private variable

        public string GetName()
        {
            return name;
        }

        public string GetSpecies()
        {
            return species;
        }

        public int GetId()
        {
            return id;
        }

        // Set Methods - Assigns a value to a private variable


        public void SetName(string nme)
        {
            name = nme;
        }

        public void SetSpecies(string spcs)
        {
            species = spcs;
        }

        public void SetId(int idee)
        {
            id = idee;
        }


        // Displays proof that an animal has been added
        public string AddAnimalReceipt()
        {
            // String that will be displayed in AddAnimal rtb
            string addAnimalReceipt = $"Animal name: {name}\n" +
                $"Species: {species}\n" +
                "\n" +
                "This animal has been succesfully added";

            return addAnimalReceipt;
        }



        public void AddConsumptionToAnimal(DateTime date, int consumption)
        {
            animalConsumption.Add(date, consumption);


        }


        public string RecentlyAddedConsumption(DateTime date)
        {
            return $"Name: {name}\nSpecies: {species}\nDate: {date.ToString("D", CultureInfo.GetCultureInfo("en-US"))}\nHow much eaten: {animalConsumption[date]}g";
        }

    }


    


}


