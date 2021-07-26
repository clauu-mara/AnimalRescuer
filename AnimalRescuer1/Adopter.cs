using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AnimalRescuer1
{
    class Adopter
    {

        string humanName;
        string gender;
        double salary;
        string occupation;
        Color hairColor;
        string favoriteAnimal;
        int numberOfAnimals;

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
    }
    class Kids:Adopter
    {
        int friendsNumber;
        int parentsNumber;
        public int FriendsNumber { get; set; } = 4;
        public int ParentsNumber { get; set; } = 2;
        
    }
    class Parents:Adopter
    {
        int kidsNumber;
        public int KidsNumber { get; set; } = 2;
    }
}
