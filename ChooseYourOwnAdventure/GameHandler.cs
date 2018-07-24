using System;
namespace ChooseYourOwnAdventure
{
    public class GameHandler
    {
        // Member Variables
        public Player player;
        Escape escapeAdventure;
        UnderWater underWaterAdventure;
        Flight flightAdventure;

        // Constructors
        public GameHandler()
        {
            player = new Player();
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
                    Console.WriteLine(escapeAdventure.GetEscapeMethod(player.name));
                    Console.ReadLine();
                    break;
                case "2":
                    underWaterAdventure = new UnderWater();
                    Console.WriteLine(underWaterAdventure.GetUnderWaterAdventure(player.name));
                    break;
                case "3":
                    flightAdventure = new Flight();
                    Console.WriteLine(flightAdventure.GetFlightAdventure(player.name));
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid Input. Please try again");
                    Choice();
                    break;

            }
            Choice();
        }
    }
}
