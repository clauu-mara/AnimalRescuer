using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer1.Animals
{
    class Dog:Animal
    {
       private string breed;
       private string dogFood;

        public string Breed { get => breed; set => breed = value; }
        public string DogFood { get; set; }

        public void DisplayFood()
        {
            Console.WriteLine("The food is:" + DogFood);
        }

        public override void Speak()
        {
            Console.WriteLine("The animal speaks!");
        }

    }
}
