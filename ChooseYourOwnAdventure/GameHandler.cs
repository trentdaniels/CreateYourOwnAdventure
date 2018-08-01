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
        Random random;

        // Constructors
        public GameHandler()
        {
            random = new Random();
            player = new Player();
            Choice();

        }

        // Methods
        public void Choice () {
            string choice;

            Console.WriteLine("Welcome to the adventure {0}!\nChoose your adventure by typing [1], [2], or [3].", player.name);
            choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    escapeAdventure = new Escape();
                    Console.WriteLine(escapeAdventure.GetEscapeMethod(player.name));
                    Console.ReadLine();
                    break;
                case "2":
                    underWaterAdventure = new UnderWater();
                    Console.WriteLine(underWaterAdventure.GetUnderWaterAdventure(player.name, random.Next(0, 10)));
                    Console.ReadLine();
                    break;
                case "3":
                    flightAdventure = new Flight();
                    Console.WriteLine(flightAdventure.GetFlightAdventure(player.name, random.Next(0, 15)));
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid Input. Please try again");
                    Choice();
                    return;

            }
            Choice();
        }
    }
}
