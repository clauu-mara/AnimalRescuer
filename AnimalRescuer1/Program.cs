using System;

namespace AnimalRescuer1
{

    class Animal
    {
        string name;
        int age;
        int healthState;
        int feelingHungry;
        int spiritState;
        string favoriteFood;
        string favoriteActivity;
        bool healthCard;

        public Animal(string animalName, int animalAge, int animalHealthState, int animalFeelingHungry, int animalSpiritState, string favoriteFood, string favoriteActivity, bool healthCard)
        {
            name = animalName;
            age = animalAge;
            healthState = animalHealthState;
            feelingHungry = animalFeelingHungry;
            spiritState = animalSpiritState;
            this.favoriteFood = favoriteFood;
            this.favoriteActivity = favoriteActivity;
            this.healthCard = healthCard;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

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

        public int HealthState
        {
            get { return healthState; }
            set { healthState = value; }

        }

        public int FeelingHungry
        {
            get { return feelingHungry; }
            set
            {
                feelingHungry = value;
            }
        }

        public int SpiritState
        {
            get { return spiritState; }
            set { spiritState = value; }
        }

        public string FavoriteFood
        {
            get { return favoriteFood; }
            set { favoriteFood = value; }
        }

        public string FavoriteActivity
        {
            get { return favoriteActivity; }
            set { favoriteActivity = value; }
        }

        public bool HealthCard
        {
            get { return healthCard; }
            set { healthCard = value; }
        }
    }

    class Adopter
    {
        string humanName;
        double salary;
        string occupation;

        public Adopter(string humanName, double salary, string occupation)
        {
            this.humanName = humanName;
            this.salary = salary;
            this.occupation = occupation;
        }

        public string HumanName
        {
            get => humanName;
            set => humanName = value;
        }

        public double Salary
        {
            get => salary;
            set => salary = value;
        }

        public string Occupation
        {
            get => occupation;
            set => occupation = value;
        }
    }
    class Animal_Food
    {
        string foodName;
        double foodPrice;
        double quantity;
        DateTime expirationDate = DateTime.Now.AddDays(10);
        int availability;

        public Animal_Food(string foodName, double foodPrice, double quantity, DateTime expirationDate, int availability)
        {
            this.foodName = foodName;
            this.foodPrice = foodPrice;
            this.quantity = quantity;
            this.expirationDate = expirationDate;
            this.availability = availability;
        }

        public string FoodName { get => foodName; set => foodName = value; }
        public double FoodPrice { get => foodPrice; set => foodPrice = value; }

        public double Quantity { get => quantity; set => quantity = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }
        public int Availability { get => availability; set => availability = value; }
    }
    class Recreation_Activity
    {
        string name;
        string environment;
        public Recreation_Activity(string name, string environment)
        {
            this.name = name;
            this.environment = environment;
        }
        public string Name { get => name; set => name = value; }
        public string Environment { get => environment; set => environment = value; }

    }
    class Vet
    {
        string name, specialization;
        public Vet()
        {
            name = Name;
            specialization = Specialization;
        }
        public string Name { get => name; set => name = value; }
        public string Specialization { get => specialization; set => specialization = value; }
    }
    class Game
    {
        Adopter adopter;
        Dog dog;
        Cat cat;
        Kids kids;
        Adults adults;
        Vet vet;
        public Game(Adopter adopter, Dog dog, Cat cat, Kids kids, Adults adults, Vet vet)
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
        public Adults Adults1 { get => adults; set => adults = value; }
        public Vet Vet1 { get => vet; set => vet = value; }
    }
    class Dog : Animal
    {
        string breed;
        string gender;
        string food;
        public Dog(string breed, string gender, string food, string animalName, int animalAge, int animalHealthState, int animalFeelingHungry, int animalSpiritState, string favoriteFood, string favoriteActivity, bool healthCard) : base(animalName, animalAge, animalHealthState, animalFeelingHungry, animalSpiritState, favoriteFood, favoriteActivity, healthCard)
        {
            this.breed = breed;
            this.gender = gender;
            this.food = food;
        }

        public string Breed { get => breed; set => breed = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Food { get => food; set => food = value; }
    }
    class Cat : Animal
    {
        string breed;
        string gender;
        string food;

        public Cat(string breed, string gender, string catFood, string animalName, int animalAge, int animalHealthState, int animalFeelingHungry, int animalSpiritState, string favoriteFood, string favoriteActivity, bool healthCard) : base(animalName, animalAge, animalHealthState, animalFeelingHungry, animalSpiritState, favoriteFood, favoriteActivity, healthCard)
        {
            this.breed = breed;
            this.gender = gender;
            food = catFood;
        }

        public string Breed { get => breed; set => breed = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Food { get => food; set => food = value; }
    }
    class Kids : Adopter
    {
        string gender;
        public Kids(string gender, string humanName, double salary, string occupation) : base(humanName, salary, occupation)
        {
            this.gender = gender;
        }
        public string Gender { get => gender; set => gender = value; }
    }
    class Adults : Adopter
    {
        string gender;
        public Adults(string gender, string humanName, double salary, string occupation) : base(humanName, salary, occupation)
        {
            this.gender = gender;
        }
        public string Gender { get => gender; set => gender = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Animal("Dog", 2, 5, 7, 4, "milk", "running", true);
            Console.WriteLine("Animal info :");
            Console.WriteLine("Animal name:" + animal.Name);
            Console.WriteLine("Animal age:" + animal.Age);
            Console.WriteLine("Animal health state:" + animal.HealthState);
            Console.WriteLine("Animal feeling hungry:" + animal.FeelingHungry);
            Console.WriteLine("Animal spirit state:" + animal.SpiritState);
            Console.WriteLine("Animal favorite food:" + animal.FavoriteFood);
            Console.WriteLine("Animal favorite activity:" + animal.FavoriteActivity);
            Console.WriteLine("Animal health card:" + animal.HealthCard);
            Console.WriteLine("\n");
            animal.Name = "cat";
            animal.Age = 8;
            animal.HealthState = 10;
            animal.FeelingHungry = 1;
            animal.SpiritState = 10;
            animal.FavoriteFood = " KiteKat";
            animal.FavoriteActivity = " purrs";
            animal.HealthCard = true;
            Console.WriteLine("New info :");
            Console.WriteLine("Animal name:" + animal.Name);
            Console.WriteLine("Animal age:" + animal.Age);
            Console.WriteLine("Animal health state:" + animal.HealthState);
            Console.WriteLine("Animal feeling hungry:" + animal.FeelingHungry);
            Console.WriteLine("Animal spirit state:" + animal.SpiritState);
            Console.WriteLine("Animal favorite food:" + animal.FavoriteFood);
            Console.WriteLine("Animal favorite activity:" + animal.FavoriteActivity);
            Console.WriteLine("Animal health card:" + animal.HealthCard);
            Console.WriteLine("\n");


            Dog dog = new Dog("Labrador", "male", "milk", "Bruno", 3, 5, 8, 9, "Friskies", "running", false);
            Console.WriteLine("Dog info :");
            Console.WriteLine("Dog breed:" + dog.Breed);
            dog.Gender = "female";
            Console.WriteLine("Dog gender:" + dog.Gender);
            dog.Name = "Maya";
            Console.WriteLine("Dog name:" + dog.Name);
            dog.Food = "Pedigree";
            Console.WriteLine("Dog food:" + dog.Food);
            Console.WriteLine("Dog health state:" + dog.HealthState);
            Console.WriteLine("Dog feeling hungry:" + dog.FeelingHungry);
            Console.WriteLine("Dog spirit state:" + dog.FeelingHungry);
            Console.WriteLine("Dog favorite food:" + dog.FavoriteFood);
            Console.WriteLine("Dog favorite activity:" + dog.FavoriteActivity);
            Console.WriteLine("Dog health card:" + dog.HealthCard);
            Console.WriteLine("\n");

            Adopter adopter = new Adopter("Mike", 9000, "Freelancer");
            Console.WriteLine("Adopter info :");
            adopter.HumanName = "Amalia";
            Console.WriteLine("Adopter name :" + adopter.HumanName);
            adopter.Salary = 1500;
            Console.WriteLine("Adopter salary :" + adopter.Salary);
            adopter.Occupation = "Intern";
            Console.WriteLine("Adopter occupation :" + adopter.Occupation);
            adopter.Salary = 12000;
            Console.WriteLine("Adopter salary :" + adopter.Salary);
            Console.WriteLine("\n");

            Animal_Food food = new Animal_Food("Pedigree", 100, 1, default, 3);
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
            Console.WriteLine("\n");



            Recreation_Activity activity = new Recreation_Activity("Running", "Nature");
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

            Cat cat = new Cat("British", "female", "milk", "Tina", 3, 5, 8, 9, "Whiskas", "sleeping", false);
            cat.Name = "Tanu";
            Console.WriteLine("CAT name:" + cat.Name);
            cat.Breed = "No breed";
            Console.WriteLine("CAT breed:" + cat.Breed);
            cat.Gender = "male";
            Console.WriteLine("CAT gender:" + cat.Gender);
            Kids kids = new Kids("male", "Cezar", 200, "Pupil");
            Adults adults = new Adults("female", "Aria", 5000, "Student");
            Console.WriteLine("\n");

            Game game = new Game(adopter, dog, cat, kids, adults, vet);
            Console.WriteLine("Game info: ");
            Console.WriteLine("Adopter name : " + game.Adopter1.HumanName);
            Console.WriteLine("Dog: " + game.Dog1.Name);
            Console.WriteLine("Cat: " + game.Cat1.Name);
            Console.WriteLine("Kids: " + game.Kids1.HumanName);
            Console.WriteLine("Adults: " + game.Adults1.HumanName);
            Console.WriteLine("Vet: " + game.Vet1.Name);

            Console.ReadLine();
        }
    }
}

