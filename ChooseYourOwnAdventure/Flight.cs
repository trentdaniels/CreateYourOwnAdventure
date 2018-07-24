using System;
namespace ChooseYourOwnAdventure
{
    public class Flight
    {
        
        Random random;

        public Flight()
        {
            
            random = new Random();

        }

        public string GetFlightAdventure(string playerName, int odds)
        {
            string flightOption;
            double chance;

            Console.WriteLine(playerName + " is flying into space. What will he do? Press enter" +
                              " to roll the dice and find out your fate");
            Console.ReadLine();

            chance = odds;
            if (chance > 12)
            {
                flightOption = "The birds pooped in your face. Ew!";
            }
            else if (chance > 6)
            {
                flightOption = "You see your parents in an airplane!";
            }
            else
            {
                flightOption = "You run into Superman and die.";
            }
            return flightOption;
        } 
    }
}
