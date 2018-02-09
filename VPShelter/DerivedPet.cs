using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class DerivedPet : VirtualPet
    {
        public string petType;
        public string diet;

        public string PetType
        {
            get { return this.petType; }
            set { this.petType = value; }
        }


        public string Diet
        {
            get { return this.diet; }
            set { this.diet = value; }
        }

       public DerivedPet()
        {

        }

        public DerivedPet(string petType, string name, string diet)
        {
            this.petType = petType;
            this.name = name;
            this.diet = diet;
            this.isBored = true;
            this.isHungry = true;
            this.isThirsty = true;
            this.isTired = false;
            this.hasToPotty = false;
            this.bordomLevel = 50;
            this.tiredness = 50;
            this.thirstLevel = 50;
            this.hungerLevel = 50;
        }






    }
}
