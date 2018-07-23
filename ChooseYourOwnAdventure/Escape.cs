using System;
namespace ChooseYourOwnAdventure
{
    public class Escape
    {
        Player player; 

        public Escape()
        {
            
            GetEscapeMethod();
        }

        public string GetEscapeMethod () {
            string escapeMethod;

            Console.WriteLine(player.name + ", a secret agent from " + player.hometown);
            escapeMethod = Console.ReadLine();
            return escapeMethod;
        }
    }
}
