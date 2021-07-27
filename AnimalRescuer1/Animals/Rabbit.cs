using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer1.Animals
{
    class Rabbit:Animal
    {
        private int babies;
        private string rabbitFood;
        public int Babies { get; set; } = 10;
        public string RabbitFood { get; set; }
        public override void DisplayFood()
        {
            Console.WriteLine("The food is:" + RabbitFood);
        }
        public override void Speak()
        {
            Console.WriteLine("The animal speaks!");
        }

        public int BabiesNumber()
        {
            Babies = AnimalsNumber / 2;
            return babies;
        }
    }
}
