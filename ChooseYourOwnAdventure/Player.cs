using System;
namespace ChooseYourOwnAdventure
{
    public class Player
    {
        // Member Variables
        public string name;
        public double age;
        public string hometown;

        // Constructor
        public Player()
        {
            name = SetName();
            age = SetAge();
            hometown = SetHometown();

        }

        // Methods
        public string SetName()
        {
            
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            return name;
        }

        public double SetAge() {
            Console.WriteLine("And how old are you?");
            age = double.Parse(Console.ReadLine());
            return age;
        }



        public string SetHometown() {
            if (age > 25) 
            {
                hometown = "Saudi Arabia";
                return hometown;
            }
            else if (age > 15) 
            {
                hometown = "Wisconsin";
                return hometown;
            }
            else 
            {
                hometown = "Your Mom";
                return hometown;
            }
        }
    }
}
