using System;
namespace ChooseYourOwnAdventure
{
    public class GameHandler
    {
        // Member Variables
        public Player player;
        Escape escapeAdventure;

        // Constructors
        public GameHandler()
        {
            
            Choice();

        }

        // Methods
        public void Choice () {
            string choice;

            Console.WriteLine("Welcome to the adventure!\nChoose your adventure by typing [1], [2], or [3].");
            choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    escapeAdventure = new Escape();
                    break;
                default:
                    Console.WriteLine("Invalid Input. Please try again");
                    Choice();
                    break;

            }
        }
    }
}
