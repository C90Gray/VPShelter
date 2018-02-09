using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPet
    {

        //fields
        protected bool isHungry;
        protected int hungerLevel;
        protected bool isThirsty;
        protected int thirstLevel;
        protected bool isTired;
        protected int tiredness;
        protected bool isBored;
        protected int bordomLevel;
        protected bool hasToPotty;
        public string name;
        protected string description;

        //properties
        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }

        public int HungerLevel
        {
            get { return this.hungerLevel; }
            set { this.hungerLevel = value; }
        }

        public bool IsThirsty
        {
            get { return this.isThirsty; }
            set { this.isThirsty = value; }
        }

        public int ThirstLevel
        {
            get { return this.thirstLevel; }
            set { this.thirstLevel = value; }
        }

        public bool IsTired
        {
            get { return this.isTired; }
            set { this.isTired = value; }
        }

        public int Tiredness
        {
            get { return this.tiredness; }
            set { this.tiredness = value; }
        }

        public bool IsBored
        {
            get { return this.isBored; }
            set { this.isBored = value; }
        }

        public int BordomLevel
        {
            get { return this.bordomLevel; }
            set { this.bordomLevel = value; }
        }

        public bool HasToPotty
        {
            get { return this.hasToPotty; }
            set { this.hasToPotty = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public VirtualPet()
        {

        }

        public VirtualPet(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public VirtualPet(string name, string description, int hungerLevel, int thirstLevel, int tiredness, int bordomLevel)
        {
            this.name = name;
            this.description = description;
            this.hungerLevel = hungerLevel;
            this.thirstLevel = thirstLevel;
            this.tiredness = tiredness;
            this.bordomLevel = bordomLevel;
        }



        //methods
        public virtual string Eat()
        {
            
                IsHungry = false;
                hungerLevel -= 10;
                Console.Title = "ASCII Art";
                string title = @"
                          
                             _
                            /  \
          _..--""""--.._      \_ /
         /,_..------ -.._\   ||
         |               |   ||
         |  `'''-----'''`|   ||
         \               /  /  \
          '.           .'   |  |
            '--.....--'     \_ /



";
                Console.WriteLine(title);
                return "The pets have been fed. \n";
            
           
        }

        public virtual string Drink()
        {
          
                isThirsty = false;
                hasToPotty = true;
                thirstLevel = 0;
                Console.Title = "ASCII Art";
                string title = @"

                        //
                       //
                      //
                     //
              _______||
         ,-'''       ||`-.
        (            ||   )
        |`-..._______,..-'|
        |            ||   |
        |     _______||   |
        |,-'''_ _  ~ ||`-.|
        |  ~ / `-.\ ,-'\ ~|
        |`-...___/___,..-'|
        |    `-./-'_ \/_| |
        | -'  ~~     || -.|
        (   ~      ~   ~~ )
         `-..._______,..-'


";
                Console.WriteLine(title);
                return "The pet's thirst was quenched. \n";
          
        }

        public virtual void Play()
        {
            Console.Title = "ASCII Art";
            string title = @"


                      ..ee$$$$$ee..                              
                   .e$*      $      *$e.                
                 z$'*.       $         $$c                        
               z$'   *.      $       .P  ^$c                      
              d'      *      $      z'     'b                     
             $'        b     $     4%       ^$                    
            d%         *     $     P         '$                   
           .$          'F    $    J'          $r                  
           4L...........b....$....$...........J$                  
           $F           F    $    $           4$                  
           4F          4F    $    4r          4P                  
           ^$          $     $     b          $%                  
            3L        .F     $     'r        JP                   
             *c       $      $      3.      z$                    
              *b     J'      $       3r    dP                     
               ^$c  z%       $        'c z$'                      
                 '*$L        $        .d$''                        
                    '*$ee..  $  ..ze$P'                    
                        ""*******""                  


";
            Console.WriteLine(title);
            bordomLevel -= 25;
            hungerLevel += 15;
            thirstLevel += 25;
        }

        public virtual void Sleep()
        {
           
                Console.WriteLine("Zzzzzzzzzzzz");
                Console.Title = "ASCII Art";
                string title = @"


        ||
        ||                   ||
     ||/||___                ||
     || /`   )____________||_/|
     ||/___ //_/_/_/_/_/_/||/ |
     ||(___)/_/_/_/_/_/_/_||  |
     ||     |_|_|_|_|_|_|_|| /|
     ||     | | | | | | | ||/||
     ||~~~~~~~~~~~~~~~~~~~||
     ||                   ||

";
                Console.WriteLine(title);
                bordomLevel += 10;
                hungerLevel += 20;
                thirstLevel += 10;
                tiredness = 0;
          
        }

        public virtual void Potty()
        {
            Console.Title = "ASCII Art";
            string title = @"
    (   )
  (   ) (
   ) _   )
    ( \_
  _(_\ \)__
 (____\___))
";
            Console.WriteLine(title);
            hungerLevel += 15;
            thirstLevel += 10;
        }

        //tick method
        public virtual void Tick()
        {
            //created random class to allow fluctuation in fields
            Random r = new Random();

            hungerLevel = hungerLevel + r.Next(-10, 10);
            thirstLevel = thirstLevel + r.Next(-3, 3);
            tiredness = tiredness + r.Next(-5, 5);
            bordomLevel = bordomLevel = r.Next(-6, 6);

            //These extensive if statements make sure that the levels (since they are randomly fluctuating) stay within the range of 0 - 100
            if ((hungerLevel >= 50) && (hungerLevel <= 100))
            {
                isHungry = true;
            }
            else if ((hungerLevel < 50) && (hungerLevel >= 0))
            {
                isHungry = false;
                hasToPotty = true;
            }
            else
            {
                hungerLevel = 50;
                isHungry = true;
            }

            if ((thirstLevel >= 50) && (thirstLevel <= 100))
            {
                isThirsty = true;
            }
            else if ((thirstLevel < 50) && (thirstLevel >= 0))
            {
                isThirsty = false;
                hasToPotty = true;
            }
            else
            {
                thirstLevel = 49;
                isThirsty = false;
            }

            if ((bordomLevel >= 50) && (bordomLevel <= 100))
            {
                isBored = true;
            }
            else if ((bordomLevel < 50) && (bordomLevel >= 100))
            {
                isBored = false;
            }
            else
            {
                bordomLevel = 40;
                isBored = false;
            }

            if ((tiredness >= 50) && (tiredness <= 100))
            {
                isTired = true;
            }
            else if ((tiredness < 50) && (tiredness >= 0))
            {
                isTired = false;
            }
            else
            {
                tiredness = 30;
                IsTired = false;
            }

            //finally, after all the numbers are set, this is sent to the console.
            Console.WriteLine("\nIt is " + isHungry + " that " + name + "is hungry. \nHunger Level: " + hungerLevel);
            Console.WriteLine("\nIt is " + IsThirsty + " that " + name + " is thirsty. \nThirst Level: " + thirstLevel);
            Console.WriteLine("\nIt is " + isTired + " that " + name + " is tired. \nTiredness: " + tiredness);
            Console.WriteLine("\nIt is " + isBored + " that " + name + " is bored. \nBordom Level: " + bordomLevel);
            Console.WriteLine("\nIt is " + hasToPotty + " that " + name + " has to go potty. \n");
          
        }
    }
}


