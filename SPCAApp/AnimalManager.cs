using System;
using System.Collections.Generic;
using System.Text;

namespace SPCAAppGui
{
    public class AnimalManager
    {
        private List<Animal> animals = new List<Animal>();


        public AnimalManager()
        {

        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public string RecentlyAddedNewAnimal()
        {
            return animals[animals.Count - 1].AddAnimalReceipt();
        }

        public string AnimalReceipts()
        {
            string receipts = "";
            foreach (Animal animal in animals)
            {
                receipts += animal.AddAnimalReceipt() + "\n";
            }
            return receipts;
        }

        public List<Animal> GetAnimals()
        {
            return animals;
        }

    }
}
