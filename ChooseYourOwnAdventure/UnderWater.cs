using System;
namespace ChooseYourOwnAdventure
{
    public class UnderWater
    {

        public UnderWater()
        {
        }

        public string GetUnderWaterAdventure (string playerName, double odds)
        {
            string underWaterOption;
            double chance;

            Console.WriteLine(playerName + " is swimming in the depths of the Bermuda Triangle. What will he do? Press enter" +
                              " to roll the dice and find out your fate");
            Console.ReadLine();

            chance = odds;
            if (chance > 7) 
            {
                underWaterOption = "You were captured by pirates!!";
            }
            else if (chance > 4) 
            {
                underWaterOption = "You found the city of Atlantis!";
            }
            else 
            {
                underWaterOption = "You found Tupac. Congrats!";
            }
            return underWaterOption;
        }
    }
}
