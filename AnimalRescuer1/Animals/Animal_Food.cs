using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalRescuer1.Animals;

namespace AnimalRescuer1
{
    class Animal_Food
    { 
        private string foodName;
        private  Animal animalName;
        private  double foodPrice;
        private  double quantity;
        private  DateTime expirationDate = DateTime.Now.AddDays(10);
        private  int availability;

        public string FoodName { get => foodName; set => foodName = value; }
        public Animal AnimalName { get; set; }
        public double FoodPrice { get => foodPrice; set => foodPrice = value; }

        public double Quantity { get => quantity; set => quantity = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }
        public int Availability { get => availability; set => availability = value; }

        public void  CheckCalories(Animal animal )
        {
            if(animal.Kilos>20)
                Console.WriteLine("Too much kilos! Too much calories!");
        }

        public void CheckDateTime()
        {
            if (ExpirationDate == DateTime.Now)
                Console.WriteLine("Hurry up");
           else if(ExpirationDate<DateTime.Now)
                Console.WriteLine("The food is expired");
            else
                Console.WriteLine("You have enough time");
        }
    }
}
