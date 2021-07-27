using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AnimalRescuer1.Animals;

namespace AnimalRescuer1.Adopters
{
    class Adopter
    {

        private  string humanName;
        private  string gender;
        private  double salary;
        private  string occupation;
        private  Color hairColor;
        private  string favoriteAnimal;
        private  int numberOfAnimals;
        private double height;
        private bool animalLover;

        public string HumanName
        {
            get => humanName;
            set => humanName = value;
        }

        public double Salary { get; set; } = 1200.20;

        public string Occupation { get; set; }
        public string Gender { get => gender; set => gender = value; }
        public Color HairColor { get; set; }
        public string FavoriteAnimal { get; set; }
        public int NumberOfAnimals { get; set; }
        public double Height { get; set; }
        public bool AnimalLover { get; set; }

        public bool CheckTheAdopter()
        {
            if(Salary>300 || NumberOfAnimals<4)
            {
                return true;
            }
            else if( salary<100 || NumberOfAnimals>=4)
            {
                Console.WriteLine("Try a little harder. You need more money.");
            }
            return false;
        }

        public void AdoptAnimal()
        {
            switch(FavoriteAnimal)
            {
                case "cat":
                    Console.WriteLine("Do you want to adopt a cat? YES - y NO - n");
                    string input = Console.ReadLine();
                    if(input.Equals("y"))
                    { 
                        Cat newCat = new Cat();
                        Console.WriteLine("The are {0} cats from which you can choose.", newCat.AnimalsNumber);
                    }
                    else
                    {
                        Console.WriteLine("OK, no cats then.");
                    }
                    break;
                case "dog":
                    Console.WriteLine("Do you want to adopt a dog? YES - y NO - n");
                    input = Console.ReadLine();
                    if (input.Equals("y"))
                    {
                        Dog newDog = new Dog();
                        Console.WriteLine("The are {0} dogs from which you can choose.", newDog.AnimalsNumber);
                    }
                    else
                    {
                        Console.WriteLine("OK, no dogs then.");
                    }
                    break;
                case "duck":
                    Console.WriteLine("Do you want to adopt a duck? YES - y NO - n");
                    input = Console.ReadLine();
                    if (input.Equals("y"))
                    {
                        Duck newDuck = new Duck();
                        Console.WriteLine("The are {0} ducks from which you can choose.", newDuck.AnimalsNumber);
                    }
                    else 
                    {
                        Console.WriteLine("OK, no ducks then.");
                    }
                    break;
                case "rabbit":
                    Console.WriteLine("Do you want to adopt a rabbit? YES - y NO - n");
                    input = Console.ReadLine();
                    if (input.Equals("y"))
                    {
                        Rabbit newRabbit = new Rabbit();
                        Console.WriteLine("The are {0} rabbits from which you can choose.", newRabbit.AnimalsNumber);
                    }
                    else
                    {
                        Console.WriteLine("OK, no rabbits then.");
                    }
                    break;
            }
        }

        public void Display()
        {
            Console.WriteLine();
        }
    }

}
