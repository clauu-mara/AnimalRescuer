using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer1
{
    class Animal_Food
    { 
        string foodName;
        double foodPrice;
        double quantity;
        DateTime expirationDate = DateTime.Now.AddDays(10);
        int availability;

        public string FoodName { get => foodName; set => foodName = value; }
        public double FoodPrice { get => foodPrice; set => foodPrice = value; }

        public double Quantity { get => quantity; set => quantity = value; }
        public DateTime ExpirationDate { get => expirationDate; set => expirationDate = value; }
        public int Availability { get => availability; set => availability = value; }

        public void  CheckCalories(Animal animal)
        {
            if(animal.Kilos>20)
                Console.WriteLine("Too much kilos! Too much calories!");
        }
    }
}
