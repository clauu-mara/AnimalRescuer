using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer1
{
    class Recreation_Activity
    {
        string activityName;
        string environment;
        int participantsNumber;
        int animalsNumber;

        public string Name { get => activityName; set => activityName = value; }
        public string Environment { get => environment; set => environment = value; }
        public int ParticipantsNumber { get; set; }
        public int AnimalsNumber { get; set; }

        public void SelectActivity(Animal animal)
        {
            switch (activityName)
            {
                case "running":
                    Console.WriteLine("The animal which is doing this activity is a {0} ",animal.Name);
                    break;
                case "sleeping":
                    Console.WriteLine("The animal which is doing this activity is a {0} ", animal.Name);
                    break;
                case "purrs":
                    Console.WriteLine("The animal which is doing this activity is a {0} ", animal.Name);
                    break;
                case "eating":
                    Console.WriteLine("The animal which is doing this activity is a {0} ", animal.Name);
                    break;
                case "swimming":
                    Console.WriteLine("The animal which is doing this activity is a {0} ", animal.Name);
                    break;
                default:
                    Console.WriteLine("No are no more activities");
                    break;
            }
        }

    }
}
