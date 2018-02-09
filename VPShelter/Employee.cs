using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        protected string employeeID;
        protected string name;

        public abstract void SignIn();

        public abstract void Play();

        public virtual void Sleep()
        {
            VirtualPet pet1 = new VirtualPet();
            pet1.Sleep();
        }

        public virtual void Potty()
        {
            VirtualPet pet1 = new VirtualPet();
            pet1.Potty();
        }
    }
}



