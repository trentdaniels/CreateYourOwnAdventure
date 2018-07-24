using System;
namespace ChooseYourOwnAdventure
{
    public class UnderWater
    {
        
        Player player;
        Random random;

        public UnderWater()
        {
            player = new Player();
            random = new Random();
            Console.WriteLine(GetUnderWaterAdventure());
            Console.ReadLine();
        }

        public string GetUnderWaterAdventure () {
            string underWaterOption;
            double chance;

            Console.WriteLine(player.name + " is swimming in the depths of the Bermuda Triangle. What will he do? Press enter" +
                              " to roll the dice and find out your fate");
            Console.ReadLine();

            chance = random.Next(0, 10);
            if (chance > 7) {
                underWaterOption = "You were captured by pirates!!";
            }
            else if (chance > 4) {
                underWaterOption = "You found the city of Atlantis!";
            }
            else {
                underWaterOption = "You found Tupac. Congrats!";
            }
            return underWaterOption;
        }
    }
}
