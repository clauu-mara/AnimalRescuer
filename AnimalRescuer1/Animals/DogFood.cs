using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer1.Animals
{
    class DogFood:Animal_Food
    {
        double calories;

        public double Calories { get; set; }

        public double MaximCalories()
        {
            calories = Quantity*100;
            return calories;
        }

    }
}
