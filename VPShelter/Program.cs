using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to Chet Felter's Positively Perfect Pet Shelter, \nwhere everything is just a little bit helter-skelter...");
            Console.WriteLine("");
            Console.WriteLine("Are you an Employee or a Volunteer? Please enter a number.");
            Console.WriteLine("1: Employee");
            Console.WriteLine("2: Volunteer");
            int choice = int.Parse(Console.ReadLine());
            VirtualPet pet1 = new VirtualPet("Chloe", "Cat", 50, 50, 50, 50);
            VirtualPet pet2 = new VirtualPet("Rodger", "Dog", 48, 36, 37, 84);
            VirtualPet pet3 = new VirtualPet("Felix", "Parrot", 43, 79, 23, 1);
            VirtualPet pet4 = new VirtualPet("Killer", "Snake", 42, 73, 21, 89);

            switch (choice)
            {
                case 1:
                    Manager boss = new Manager();
                    int Action = 0;
                    string newBuddy = "";
                    Console.WriteLine("Thank you for working at Chet Felter's Positively Perfect Pet Shelter.");
                    do
                    {
                        
                       
                        
                        Console.WriteLine("");
                        Console.WriteLine("What would you like to do? Please select a number from the following options.");
                        Console.WriteLine("1: Sign in");
                        Console.WriteLine("2: Adopt a Pet");
                        Console.WriteLine("3: Play with the pets");
                        Console.WriteLine("4: Check pet status");
                        Console.WriteLine("5: Sign out");

                        Action = int.Parse(Console.ReadLine());

                        switch (Action)
                        {
                            case 1:
                                boss.SignIn();
                                break;
                            case 2:
                                newBuddy = boss.Adopt();
                                break;
                            case 3:
                                boss.Play();
                                break;
                            case 4:
                                if (newBuddy == "")
                                {
                                    pet1.Tick();
                                    Console.WriteLine("");
                                    pet2.Tick();
                                    Console.WriteLine("");
                                    pet3.Tick();
                                    Console.WriteLine("");
                                    pet4.Tick();
                                }
                                else
                                {
                                    pet1.Tick();
                                    Console.WriteLine("");
                                    pet2.Tick();
                                    Console.WriteLine("");
                                    pet3.Tick();
                                    Console.WriteLine("");
                                    pet4.Tick();
                                    Console.WriteLine("");
                                    VirtualPet pet5 = new VirtualPet(newBuddy, "Pet", 60, 35, 25, 57);
                                    pet5.Tick();

                                }
                                break;                       
                        }


                    } while (Action != 5);
                    break;
                case 2:
                    Volunteer bob = new Volunteer();
                    Action = 0;
                    Console.WriteLine("Thank you for volunteering at Chet Felter's Positively Perfect Pet Shelter!");
                    do
                    {
                       
                        Console.WriteLine("");
                        Console.WriteLine("What would you like to do? Please select a number from the following options.");
                        Console.WriteLine("1: Sign in");
                        Console.WriteLine("2: Feed the pets");
                        Console.WriteLine("3: Play with the pets");
                        Console.WriteLine("4: Give the pets water");
                        Console.WriteLine("5: Take the pets to do thier business");
                        Console.WriteLine("6: Let the pets take a rest");
                        Console.WriteLine("7: Check pet status");
                        Console.WriteLine("8: Sign out");

                        Action = int.Parse(Console.ReadLine()); 

                        switch (Action)
                        {
                            case 1:
                                bob.SignIn();
                                break;
                            case 2:
                                bob.FeedAll();
                                break;
                            case 3:
                                bob.Play();
                                break;
                            case 4:
                                bob.DrinkAll();
                                break;
                            case 5:
                                bob.Potty();
                                break;
                            case 6:
                                bob.Sleep();
                                break;
                            case 7:
                                pet1.Tick();
                                Console.WriteLine("");
                                pet2.Tick();
                                Console.WriteLine("");
                                pet3.Tick();
                                Console.WriteLine("");
                                pet4.Tick();
                                break;
                        }

                    } while (Action != 8);
                    break;
                default:
                    return;

            }

            Console.WriteLine("Thank you for helping at Chet Felter's Positively Perfect Pet Shelter. Please come again!" );
        


        }
    }
}
