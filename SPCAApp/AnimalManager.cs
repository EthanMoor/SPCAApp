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


        public int FindAnimal(int id)
        {
            for (int animalIndex = 0; animalIndex < animals.Count; animalIndex++)
            {
                if (id == animals[animalIndex].GetId())
                {
                    return animalIndex;
                }
            }

            return -1;
        }

        public void AddConsumption(int id, DateTime date, int consumption)
        {
            int foundIndex = FindAnimal(id);

            if (foundIndex != -1)
            {
                animals[foundIndex].AddConsumptionToAnimal(date, consumption);
            }
        }

        public string GetRecentlyAddedConsumption(DateTime date, int id)
        {
            return animals[FindAnimal(id)].RecentlyAddedConsumption(date);
        }

        public string GetAnimalSummary(int id)
        {
            return animals[FindAnimal(id)].AnimalSummary();
        }
        



    }
}
