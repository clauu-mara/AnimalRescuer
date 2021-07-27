using System;
using System.Drawing;
using AnimalRescuer1.Animals;

namespace AnimalRescuer1
{
    class Game
    {
        Adopter adopter;
        Dog dog;
        Cat cat;
        Kids kids;
        Parents adults;
        Vet vet;
        public Game(Adopter adopter, Dog dog, Cat cat, Kids kids, Parents adults, Vet vet)
        {
            this.adopter = adopter;
            this.dog = dog;
            this.cat = cat;
            this.kids = kids;
            this.adults = adults;
            this.vet = vet;
        }

        public Adopter Adopter1
        {
            get => adopter;
            set => adopter = value;
        }

        public Dog Dog1 { get => dog; set => dog = value; }
        public Cat Cat1 { get => cat; set => cat = value; }
        public Kids Kids1 { get => kids; set => kids = value; }
        public Parents Adults1 { get => adults; set => adults = value; }
        public Vet Vet1 { get => vet; set => vet = value; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            /*Animal animal = new Animal();
            animal.Name = "cat";
            animal.Gender = "female";
            animal.Age = 8;
            animal.HealthState = 10;
            animal.FeelingHungry = 1;
            animal.SpiritState = 10;
            animal.FavoriteFood = " KiteKat";
            animal.FavoriteActivity = " purrs";
            animal.HealthCard = true;
            animal.AnimalColor = Color.Black;
            animal.Kilos = 3;
            animal.LastBath = DateTime.Today;
            animal.FavoriteToy = "mouse";
            animal.AnimalsNumber = 4;
            Console.WriteLine("New info :");
            Console.WriteLine("Animal name:" + animal.Name);
            Console.WriteLine("Animal age:" + animal.Age);
            Console.WriteLine("Animal health state:" + animal.HealthState);
            Console.WriteLine("Animal feeling hungry:" + animal.FeelingHungry);
            Console.WriteLine("Animal spirit state:" + animal.SpiritState);
            Console.WriteLine("Animal favorite food:" + animal.FavoriteFood);
            Console.WriteLine("Animal favorite activity:" + animal.FavoriteActivity);
            Console.WriteLine("Animal health card:" + animal.HealthCard);
            Console.WriteLine("Animal kilos:" + animal.Kilos);
            Console.WriteLine("Animal color:" + animal.AnimalColor);
            Console.WriteLine("Animal last bath:" + animal.LastBath);
            Console.WriteLine("Animal favorite toy:" + animal.FavoriteToy);
            Console.WriteLine("Number of animals:" + animal.AnimalsNumber);
            Console.WriteLine("\n");*/


            Dog dog = new Dog();
            Console.WriteLine("Dog info :");
            dog.Breed = "Labrador";
            Console.WriteLine("Dog breed:" + dog.Breed);
            dog.Gender = "female";
            Console.WriteLine("Dog gender:" + dog.Gender);
            dog.Name = "Maya";
            Console.WriteLine("Dog name:" + dog.Name);
            dog.DogFood = "Pedigree";
            Console.WriteLine("Dog food:" + dog.DogFood);
            Console.WriteLine("Dog health state:" + dog.HealthState);
            Console.WriteLine("Dog feeling hungry:" + dog.FeelingHungry);
            Console.WriteLine("Dog spirit state:" + dog.SpiritState);
            Console.WriteLine("Dog favorite food:" + dog.FavoriteFood);
            Console.WriteLine("Dog favorite activity:" + dog.FavoriteActivity);
            Console.WriteLine("Dog health card:" + dog.HealthCard);
            Console.WriteLine("\n");

            Adopter adopter = new Adopter();
            Console.WriteLine("Adopter info :");
            adopter.HumanName = "Amalia";
            Console.WriteLine("Adopter name :" + adopter.HumanName);
            adopter.Salary = 1500;
            Console.WriteLine("Adopter salary :" + adopter.Salary);
            adopter.Occupation = "Intern";
            Console.WriteLine("Adopter occupation :" + adopter.Occupation);
            adopter.Salary = 12000;
            Console.WriteLine("Adopter salary :" + adopter.Salary);
            adopter.HairColor = Color.Red;
            Console.WriteLine("Hair color:" + adopter.HairColor);
            adopter.FavoriteAnimal = "cat";
            Console.WriteLine("Favorite animal:" + adopter.FavoriteAnimal);
            adopter.NumberOfAnimals = 4;
            Console.WriteLine("Number of animals:" + adopter.NumberOfAnimals);
            Console.WriteLine("\n");

            Animal_Food food = new Animal_Food();
            Console.WriteLine("Animal food info :");
            food.FoodName = "meat";
            Console.WriteLine("Animal food name :" + food.FoodName);
            food.FoodPrice = 60;
            Console.WriteLine("Animal food price :" + food.FoodPrice);
            food.Quantity = 3;
            Console.WriteLine("Animal food quantity:" + food.Quantity);
            food.ExpirationDate = DateTime.Now.AddDays(2);
            Console.WriteLine("Animal food dateTime :" + food.ExpirationDate);
            food.Availability = 6;
            Console.WriteLine("Animal food availability :" + food.Availability);
            food.AnimalName = dog;
            Console.WriteLine("The animal name is: " + food.AnimalName);
            Console.WriteLine("\n");


            Recreation_Activity activity = new Recreation_Activity();
            Console.WriteLine("Recreation activity info :");
            activity.Name = "sleeping";
            Console.WriteLine("Recreation activity name :" + activity.Name);
            activity.Environment = "house";
            Console.WriteLine("Environment :" + activity.Environment);
            Console.WriteLine("\n");

            Vet vet = new Vet();
            vet.Name = "Mike";
            Console.WriteLine("Vet name :" + vet.Name);
            vet.Specialization = "Med";
            Console.WriteLine("Vet specialization:" + vet.Specialization);
            Console.WriteLine("\n");

            Cat cat = new Cat();
            cat.Name = "Tanu";
            Console.WriteLine("CAT name:" + cat.Name);
            cat.Breed = "No breed";
            Console.WriteLine("CAT breed:" + cat.Breed);
            cat.Gender = "male";
            Console.WriteLine("CAT gender:" + cat.Gender);
            cat.CatFood = "milk";
            Console.WriteLine("CAT food: " + cat.CatFood);
            cat.FavoriteActivity = "sleeping";
            Console.WriteLine("CAT favorite activity:" + cat.FavoriteActivity);
            cat.FeelingHungry = 3;
            Console.WriteLine("CAT feeling hungry:" + cat.FeelingHungry);
            cat.HealthCard = false;
            Console.WriteLine("CAT health card:" + cat.HealthCard);
            cat.SpiritState = 5;
            Console.WriteLine("CAT spirit state:" + cat.SpiritState);
            cat.HealthState = 7;
            Console.WriteLine("CAT health state:" + cat.HealthState);
            cat.Kilos = 3;
            Console.WriteLine("CAT kilos:" + cat.Kilos);
            cat.LastBath = DateTime.Now.AddYears(-1);
            Console.WriteLine("CAT last bath:" + cat.LastBath);
            cat.Age = 1;
            cat.Kilos = 21;
            Console.WriteLine("CAT age:" + cat.Age);
            Console.WriteLine("\n");

            Console.WriteLine("Kids:");
            Kids kids = new Kids();
            kids.Gender = "female";
            Console.WriteLine("Kids gender:" + kids.Gender);
            kids.HumanName = "Mia";
            kids.FriendsNumber = 5;
            Console.WriteLine("Kid s friends:" + kids.FriendsNumber);
            kids.ParentsNumber = 1;
            Console.WriteLine("Kid s parents:" + kids.ParentsNumber);
            Console.WriteLine("\n");

            Console.WriteLine("Parents:");
            Parents adults = new Parents();
            adults.Gender = "male";
            Console.WriteLine("Parents gender:" + adults.Gender);
            adults.HumanName = "Luis";
            adults.HairColor = Color.White;
            Console.WriteLine("Parents hair color:" + adults.HairColor);
            adults.KidsNumber = 1;
            Console.WriteLine("Parent s kid:" + adults.KidsNumber);
            Console.WriteLine("\n");

            Game game = new Game(adopter, dog, cat, kids, adults, vet);
            Console.WriteLine("Game info: ");
            Console.WriteLine("Adopter name : " + game.Adopter1.HumanName);
            Console.WriteLine("Dog name: " + game.Dog1.Name);
            Console.WriteLine("Cat name: " + game.Cat1.Name);
            Console.WriteLine("Kids name: " + game.Kids1.HumanName);
            Console.WriteLine("Adults name: " + game.Adults1.HumanName);
            Console.WriteLine("Vet name: " + game.Vet1.Name);
            Console.WriteLine("---------------------------------");


            Duck duck = new Duck();
            Animal duck1 = new Duck();
            duck.FavoriteFood = "idk";
            duck.FavoriteActivity = "Swimming";
            duck.DuckFood = "idk";
            Console.WriteLine("---------------------------------");
            Rabbit rabbit = new Rabbit();
            rabbit.FavoriteFood = "carrots";
            rabbit.FavoriteActivity = "eating";
            rabbit.RabbitFood = "carrots";
            Console.WriteLine("---------------------------------");


            //Methods
            Console.WriteLine("Eat method:");
            duck.AnimalEats(food);
            Console.WriteLine("Sleep method:");
            duck1.AnimalSleeping();
            Console.WriteLine("The animal is playing?");
            duck1.isPlaying();
           
            
            Console.WriteLine("Eat method:");
            rabbit.AnimalEats(food);
            Console.WriteLine("Check last bath:");
            rabbit.CheckLastBath();
            cat.CheckLastBath();
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Check calories:");
            food.CheckCalories(cat);
            Console.WriteLine("Check DateTime:");
            food.CheckDateTime();
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Select the animal by his favorite activity:");
            activity.SelectActivity(rabbit);
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Check if the adopter can take care of the animal");
            adopter.CheckTheAdopter();
            Console.WriteLine("What do you want to adopt?");
            adopter.AdoptAnimal();
            Console.WriteLine("---------------------------------");

            Console.WriteLine("How much the vet works:");
            vet.Working();

            Console.WriteLine("---------------------------------");
            dog.DisplayFood();
            cat.DisplayFood();
            duck.DisplayFood();
            rabbit.DisplayFood();

            Console.WriteLine("---------------------------------");
            dog.Speak();
            cat.Speak();
            duck1.Speak();
            rabbit.Speak();

            Console.ReadLine();


        }
    }
}

