﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalRescuer1.Animals;

namespace AnimalRescuer1
{
    class Recreation_Activity
    {
        private  string activityName;
        private  string environment;
        private  int participantsNumber;
        private  int animalsNumber;

        public string Name { get => activityName; set => activityName = value; }
        public string Environment { get => environment; set => environment = value; }
        public int ParticipantsNumber { get; set; }
        public int AnimalsNumber { get; set; }

        public void SelectActivity(Animal animal)
        {
            switch (activityName)
            {
                case "running":
                    Console.WriteLine("This activity is specific to a {0} ",animal.Name);
                    break;
                case "sleeping":
                    Console.WriteLine("This activity is specific to a {0} ", animal.Name);
                    break;
                case "purrs":
                    Console.WriteLine("This activity is specific to a {0} ", animal.Name);
                    break;
                case "eating":
                    Console.WriteLine("This activity is specific to a {0} ", animal.Name);
                    break;
                case "swimming":
                    Console.WriteLine("This activity is specific to a {0} ", animal.Name);
                    break;
                default:
                    Console.WriteLine("No more activities");
                    break;
            }
        }
    }
}
