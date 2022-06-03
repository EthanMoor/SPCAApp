using System;
using System.Collections.Generic;
using System.Text;

namespace SPCA_app
{
    class Animal
    {
        // Access Modifiers - public / private / protected
        private string name;
        private string species;
        private readonly Dictionary<string, int> 


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

        // Set Methods - Assigns a value to a private variable


        public void SetName(string nme)
        {
            name = nme;
        }

        public void SetSpecies(string spcs)
        {
            species = spcs;
        }


    }


    


}


