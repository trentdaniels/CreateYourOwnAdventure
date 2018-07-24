using System;
namespace ChooseYourOwnAdventure
{
    public class Player
    {
        // Member Variables
        public string name;

        // Constructor
        public Player()
        {
            name = SetName();

        }

        // Methods
        public string SetName()
        {
            
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            return name;
        }

        public string GetName() {
            return name;
        }

       
    }
}
