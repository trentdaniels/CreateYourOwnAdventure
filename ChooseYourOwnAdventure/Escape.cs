﻿using System;
namespace ChooseYourOwnAdventure
{
    public class Escape
    {
        // Member Variables


        // Constructors
        public Escape()
        {
            
        }

        // Methods
        public string GetEscapeMethod (string playerName) {
            string escapeHeight;
            string escapeMethod;

            Console.WriteLine(playerName + ", a secret agent from Tokyo, runs into a set a three doors, all at different heights.\n How tall " +
                              "are you in inches?");
            escapeHeight = Console.ReadLine();
            if (double.Parse(escapeHeight) > 60) {
                escapeMethod = "You climbed up the window!";

            }
            else if (double.Parse(escapeHeight) > 20){
                escapeMethod = "You just opened the door. Oh no!";

            }
            else {
                escapeMethod = "You crawled through the dog door";

            }
            return escapeMethod;
        }
    }
}
