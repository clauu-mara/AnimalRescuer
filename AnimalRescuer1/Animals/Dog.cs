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
       private int energyLevel;
        private int hungryLevel;

        public string Breed { get => breed; set => breed = value; }
        public string DogFood { get; set; }

        public int EnergyLevel { get; set; }

        public int HungryLevel { get; set; }
        public override void DisplayFood()
        {
            Console.WriteLine("The food is:" + DogFood);
        }
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow bow");
        }
        public override void Speak()
        {
            Console.WriteLine("The animal speaks!");
        }

        public void ComplexData(DogFood food)
        {
            EnergyLevel = (int)food.Calories + 10 + (int)food.Quantity;
            if(food.AnimalName.SpiritState <5 && food.AnimalName.Kilos <4)
            { HungryLevel = food.AnimalName.FeelingHungry; }

            Console.WriteLine("Energy level : {0}, HungryLevel: {1}", EnergyLevel, HungryLevel);
        }

        public string Energy()
        {
            if (EnergyLevel > 10)
                return "a inceput sa se simta mai energic";
            else
                return " nu are energie";
        }


    }
}
