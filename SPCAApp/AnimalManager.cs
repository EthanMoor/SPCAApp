using System;
using System.Collections.Generic;
using System.Text;

namespace SPCAAppGui
{
    public class AnimalManager
    {
        private List<Animal> animals = new List<Animal>();
        private int nextId = 1;

        public AnimalManager()
        {

        }

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);

            animals[animals.Count - 1].SetId(nextId);
            this.nextId += 1;
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
