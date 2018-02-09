using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : Employee
    {
        public string VolunteerType { get; set; }
        public bool IsSignedIn { get; set; }

        public Volunteer()
        {

        }

        public Volunteer(string name, string employeeID, string volunteeerType)
        {
            this.name = name;
            this.employeeID = employeeID;
            this.VolunteerType = volunteeerType;
            this.IsSignedIn = false;
        }


        public override void Play()
        {
            if (IsSignedIn)
            {
                Console.WriteLine("The pets love playing with you!");
                VirtualPet pet1 = new VirtualPet();
                pet1.Play();
            }
            else
            {
                Console.WriteLine("ERROR: Employee is not signed in. \nPlease sign in and try again");
            }

        }

        public override void SignIn()
        {
            IsSignedIn = true;
            Console.WriteLine("Thank you for volunteering. Please fill out the following paperwork.");
            Console.WriteLine("First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Reason for volunteering:");
            string aboutMe = Console.ReadLine();
            Console.WriteLine("\n\nThank you for your info. You will now be directed to the main menu.");
        }

        public void FeedAll()
        {
            if (IsSignedIn)
            {
                Console.WriteLine("All the pets have been fed");
                VirtualPet pet1 = new VirtualPet();
                pet1.Eat();
            }
            else
            {
                Console.WriteLine("ERROR: Employee is not signed in. \nPlease sign in and try again");
            }
        }

        public void DrinkAll()
        {
            if (IsSignedIn)
            {
                Console.WriteLine("The pets are no longer thirsty");
                VirtualPet pet1 = new VirtualPet();
                pet1.Drink();
            }
            else
            {
                Console.WriteLine("ERROR: Employee is not signed in. \nPlease sign in and try again");
            }

        }
    }
}
