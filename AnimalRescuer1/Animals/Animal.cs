using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnimalRescuer1.Animals
{
    abstract class Animal
    {
        private string name;
        private  string gender;
        private int age;
        private int healthState;
        private  int feelingHungry;
        private int spiritState;
        private string favoriteFood;
        private string favoriteActivity;
        private bool healthCard;
        private Color animalColor;
        private double kilos;
        private  DateTime lastBath;
        private string favoriteToy;
        private int animalsNumber;

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

        public string FavoriteToy { get; set; }

        public int AnimalsNumber { get; set; }

        public double AnimalEats(Animal_Food animalFood)
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
                SpiritState++;
                FeelingHungry--;
                HealthState++;
                Kilos++;
            }
            Console.WriteLine("The new kilos:" + Kilos);

            if (HealthState > 8 && SpiritState >5)
                Console.WriteLine("The animal feels better.");
            if (FeelingHungry < 5)
                Console.WriteLine("The animal in no more hungry ");

            return Kilos;
         
        }
        public void AnimalSleeping()
        {
            if (spiritState < 5)
                Console.WriteLine("The animal is sleepy");
        }

        public void CheckLastBath()
        {
            if (LastBath > DateTime.Now.AddDays(360))
                Console.WriteLine("You should take it a bath");
        }

        public void isPlaying()
        {
            if (SpiritState > 9)
                Console.WriteLine("The animal is playing");
        }

        public void DisplayFood()
        {
            Console.WriteLine("The favorite food is :" + FavoriteFood);
        }

        public abstract void Speak();
    }

}