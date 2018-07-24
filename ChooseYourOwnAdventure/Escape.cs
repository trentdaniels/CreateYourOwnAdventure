using System;
namespace ChooseYourOwnAdventure
{
    public class Escape
    {
        // Member Variables
        Player player;

        // Constructors
        public Escape()
        {
            player = new Player();

            Console.WriteLine(GetEscapeMethod());
            Console.ReadLine();
        }

        // Methods
        public string GetEscapeMethod () {
            string escapeHeight;
            string escapeMethod;

            Console.WriteLine(player.name + ", a secret agent from Tokyo, runs into a set a three doors, all at different heights.\n How tall" +
                              "are you in inches?");
            escapeHeight = Console.ReadLine();
            if (double.Parse(escapeHeight) > 60) {
                escapeMethod = "You climbed up the window!";
                return escapeMethod;
            }
            else if (double.Parse(escapeHeight) > 20){
                escapeMethod = "You just opened the door. Oh no!";
                return escapeMethod;
            }
            else {
                escapeMethod = "You crawled through the dog door";
                return escapeMethod;
            }
        }
    }
}
