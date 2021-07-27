using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalRescuer1.Adopters
{
    class Kids:Adopter
    {
        int friendsNumber;
        int parentsNumber;
        public int FriendsNumber { get; set; } = 4;
        public int ParentsNumber { get; set; } = 2;

    }
}
