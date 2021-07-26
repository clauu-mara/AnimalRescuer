using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnimalRescuer1
{
    class Animal
    {
        string name;
        string gender;
        int age;
        int healthState;
        int feelingHungry;
        int spiritState;
        string favoriteFood;
        string favoriteActivity;
        bool healthCard;
        Color animalColor;
        double kilos;
        DateTime lastBath;

        public string Name { get; set; } = "Dog";

        public string Gender { get; set; }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public int HealthState { get; set; } = 7;

        public int FeelingHungry { get; set; } = 8;

        public int SpiritState { get; set; } = 4;

        public string FavoriteFood { get; set; } = "meat";

        public string FavoriteActivity { get; set; } = "running";

        public bool HealthCard { get; set; }
        public Color AnimalColor { get; set; } = Color.Black;
        public double Kilos { get; set; } = 3;
        public DateTime LastBath { get; set; } = DateTime.Today;

        public double AnimalEats(Animal animal,Animal_Food animalFood)
        {
            switch(animalFood.FoodName)
            {
                case "meat":
                    Console.WriteLine("This is a dog");
                    break;
                case "milk":
                    Console.WriteLine("This is a cat");
                    break;
                case "carrots":
                    Console.WriteLine("This is a rabbit");
                    break;
                case "idk":
                    Console.WriteLine("This is a duck");
                    break;
                default:
                    Console.WriteLine("No animal");
                    break;
            }
            if (animalFood.Quantity > 5)
            {
                animal.SpiritState++;
                animal.FeelingHungry--;
                animal.HealthState++;
                animal.Kilos++;
            }
            Console.WriteLine("The new kilos:" + animal.Kilos);

            if (animal.HealthState > 8 && animal.SpiritState >5)
                Console.WriteLine("The animal feels better.");
            if (animal.FeelingHungry < 5)
                Console.WriteLine("The animal in no more hungry ");

            return animal.Kilos;
         
        }
        public void AnimalSleeping(Animal animal)
        {
            if (animal.spiritState < 5)
                Console.WriteLine("The animal is sleepy");
        }

        public void CheckLastBath(Animal animal)
        {
            if (animal.LastBath > DateTime.Now.AddDays(360))
                Console.WriteLine("You should take it a bath");
        }

        public void isPlaying(Animal animal)
        {
            if (animal.SpiritState > 9)
                Console.WriteLine("The animal is playing");
        }
    }

    class Dog : Animal
    {
        string breed;
        string dogFood;

        public string Breed { get => breed; set => breed = value; }
        public string DogFood { get; set; }
    }
    class Cat : Animal
    {
        string breed;
        string catFood;

        public string Breed { get => breed; set => breed = value; }
        public string CatFood { get;set; }
    }
    class Duck : Animal
    {
        int eggs;
        public int Eggs { get; set; } = 5;
    }
    class Rabbit:Animal
    {
        int babies;
        public int Babies { get; set; } = 10;
    }
}
