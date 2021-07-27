using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer1
{
    class Vet
    {
        string name, specialization;
        string assistantName;
        string gender;
        int workHours;
        string animalName;

        public string Name { get => name; set => name = value; }
        public string Specialization { get => specialization; set => specialization = value; }
        public string AssistantName { get; set; }
        public string Gender { get; set; }
        public int WorkHours { get; set; }
        public string AnimalName { get; set; }

        public void Working()
        {
            if (WorkHours > 8)
                Console.WriteLine("The vet worked too much");
            else if(WorkHours<=6)
                Console.WriteLine("The vet worked too little");
            else 
                Console.WriteLine("The vet worked enough.");

        }
    }
}
