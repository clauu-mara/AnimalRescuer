using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer1.Animals
{
    class Cat:Animal
    {
        private string breed;
        private string catFood;

        public string Breed { get => breed; set => breed = value; }
        public string CatFood { get =>catFood; set => catFood=value; }

        public override void DisplayFood()
        {
            Console.WriteLine("The food is:" + CatFood);
        }
        public override void Speak()
        {
            Console.WriteLine("The animal speaks!");
        }
    }
}
