using System;
using System.Collections.Generic;
using System.Text;
using FIFOAnimalShelter.Classes;

namespace FIFOAnimalShelter.Classes
{
    class AnimalShelter
    {
        public Animal Current { get; set; }
        public Animal Previous { get; set; }

        public Enqueue(Animal animal)
        {
            if (Current != null)
            {
                Previous.Next = animal;
                Previous = animal;
            }
            else
            {
                Current = animal;
                Previous = animal;
            }

        }
        public void Dequeue(string pref)
        {
            Animal last;
            while(Current != null && GetType())
        }
    }
}
