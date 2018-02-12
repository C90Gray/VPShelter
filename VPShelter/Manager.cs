using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Manager : Employee
    {
        public int YearsEmployed { get; }

        public bool IsSignedIn { get; set; }

        public Manager()
        {
            this.IsSignedIn = false;
        }

        public override void Play()
        {
            if (IsSignedIn)
            {
                Console.WriteLine("The pets love playing with you");
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
            Console.WriteLine("\aThank you for signing in. Have a great day");
           
        }

        public string Adopt()
        {
            if (IsSignedIn)
            {
                Console.WriteLine("Please choose an animal to add to the shelter.");
                Console.WriteLine("1: Cleo the cat is a longhaired housecat. He loves being around people and rarely gets upset");
                Console.WriteLine("2: Bone the dog is a pug. He is lazy and barks at everything. He hates people");
                Console.WriteLine("3: Iggy the Iguana is the coolest reptile in town.");
                Console.WriteLine("4: Mr. Fluffles is a Rabbit who has an obsession with biting everyone and everything.");
                Console.WriteLine("5: Cattoy is a goldfish. She is really boring and doesn't do anything except float in her bowl.");
                Console.WriteLine("");
                Console.WriteLine("Please choose a pet now");
                int adoptionChoice = int.Parse(Console.ReadLine());
                do
                {
                    switch (adoptionChoice)
                    {
                        case 1:
                            Console.WriteLine("You chose Cleo! He will make a great additon");
                            return "Cleo";
                            
                        case 2:
                            Console.WriteLine("You chose Bone! He will make a great addition");
                            return "Bone";
                            
                        case 3:
                            Console.WriteLine("You chose Iggy! He will make a great addition");
                            return "Iggy";

                        case 4:
                            Console.WriteLine("You chose Mr. Fluffles! He will make a great addition");
                            return "Mr. Fluffles";
                        case 5:
                            Console.WriteLine("You chose Cattoy! She will make a great addition");
                            return "Cattoy";
                    }
                } while ((adoptionChoice >= 5) && (adoptionChoice <= 1));
                return "";
            }
           else
            {
                Console.WriteLine("ERROR: Employee is not signed in. Please sign in and try again");
                return "";
            }


        }

        //this method takes in newBuddy which is a string variable assigned in the add pet method and figures out if that pet has been added or not, to determine if there is 4 or 5 options of pets to adopt. 
        //it returns an int that will be assigned to a variable in the program class to go into a switch statement and change the ishere bool of the specific pet to false
        public int RemovePet(string petadd)
        {
            if (IsSignedIn)
            {
                int petchoice;
                Console.WriteLine("Please choose a pet to send to it's new furrever home");
                if (petadd == "")
                {
                    Console.WriteLine("1: Chloe the Cat");
                    Console.WriteLine("2: Rodger the Dog");
                    Console.WriteLine("3: Killer the Snaker");
                    Console.WriteLine("4: Felix the Parrot");

                    petchoice = int.Parse(Console.ReadLine());

                    switch (petchoice)
                    {
                        case 1:
                            Console.WriteLine("Chloe has moved on to her Furrever Home");
                            return 1;
                        case 2:
                            Console.WriteLine("Rodger has moved on to his Furrever Home");
                            return 2;
                        case 3:
                            Console.WriteLine("Killer has moved on to his Furrever Home");
                            return 4;
                        case 4:
                            Console.WriteLine("Felix has moved on to her Furrever Home");
                            return 3;
                    }

                }
                else
                {
                    Console.WriteLine("1: Chloe");
                    Console.WriteLine("2: Rodger");
                    Console.WriteLine("3: Killer");
                    Console.WriteLine("4: Felix");
                    Console.WriteLine("5: " + petadd);
                    petchoice = int.Parse(Console.ReadLine());

                    switch (petchoice)
                    {
                        case 1:
                            Console.WriteLine("Chloe has moved on to her Furrever Home");
                            return 1;
                        case 2:
                            Console.WriteLine("Rodger has moved on to his Furrever Home");
                            return 2;
                        case 3:
                            Console.WriteLine("Killer has moved on to his Furrever Home");
                            return 4;
                        case 4:
                            Console.WriteLine("Felix has moved on to his Furrever Home");
                            return 3;
                        case 5:
                            Console.WriteLine(petadd + " has moved on to his Furrever Home");
                            return 5;
                    }



                }
            }
            else
            {
                Console.WriteLine("ERROR: Employee is not signed in. Please sign in and try again");
                return 0;
            }

            return 0;
          
        }
            






    }
}

