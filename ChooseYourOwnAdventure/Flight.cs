using System;
namespace ChooseYourOwnAdventure
{
    public class Flight
    {
        Player player;
        Random random;

        public Flight()
        {
            player = new Player();
            random = new Random();
            Console.WriteLine(GetFlightAdventure());
            Console.ReadLine();
        }

        public string GetFlightAdventure()
        {
            string flightOption;
            double chance;

            Console.WriteLine(player.name + " is flying into space. What will he do? Press enter" +
                              " to roll the dice and find out your fate");
            Console.ReadLine();

            chance = random.Next(0, 15);
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
