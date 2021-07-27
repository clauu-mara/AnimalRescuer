using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer1.Animals
{
    class Duck:Animal
    {
        int eggs;
        string duckFood="greenery";
        public int Eggs { get; set; } = 5;
        public string DuckFood { get; set; }
        public override void DisplayFood()
        {
            Console.WriteLine("The food is:" + DuckFood);
        }
        public override void Speak()
        {
            Console.WriteLine("The animal speaks!");
        }
        public void Display()
        {
            Console.WriteLine("Food:" + duckFood);
        }
        public void EggsNumber()
        {
            Console.WriteLine("Eggs number:" + eggs);
        }


    }
}
