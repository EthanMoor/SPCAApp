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

    }
}
