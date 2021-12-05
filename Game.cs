using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

/// <summary>
/// Class to contain the game logic for the Windows Forms game. Will be instantiated through Form1.cs. Contains instances of Entities as Heroes and Enemies
/// that the user can play as or against. Contains methods to damage entities and defend from entity attacks. Uses a StreamWriter to write the output of 
/// the game actions to a text file located in the /bin/debug/netcoreapps directory of the project.
/// </summary>
namespace FinalProject
{
    public class Game
    {
        Random random = new Random();

        //Create a new global instance of a warrior hero.
        public Entity warrior = new Hero(100, 100, 15, 100, 100, 15, 100, 70, 'w', "warrior");

        //Create a new global instance of a hero for the mage.
        public Entity mage = new Hero(100, 15, 100, 100, 15, 100, 100, 85, 'm', "mage");

        //Create a new global instance of a hero for the mage.
        public Entity cleric = new Hero(100, 35, 35, 100, 40, 40, 100, 75, 'c', "cleric");

        //Create instance of an enemy bandit.
        public Entity bandit = new Enemy(100, 50, 0, 100, 50, 0, 0, 75, 'b', "bandit");

        //Instance for second bandit on the form.
        public Entity banditTwo = new Enemy(100, 50, 0, 100, 50, 0, 0, 75, 'b', "second bandit");

        //Instance for the third bandit on the form.
        public Entity banditThree = new Enemy(100, 50, 0, 100, 50, 0, 0, 75, 'b', "third bandit");

        //Create instance of an enemy troll.
        public Entity troll = new Enemy(100, 75, 0, 50, 50, 0, 0, 25, 't', "troll");

        //Instance for the second troll on the form.
        public Entity trollTwo = new Enemy(100, 75, 0, 50, 50, 0, 0, 25, 't', "second troll");

        //Instance for the third troll on the form.
        public Entity trollThree = new Enemy(100, 75, 0, 50, 50, 0, 0, 25, 't', "third troll");

        //Create instance of an enemy dragon.
        public Entity dragon = new Enemy(100, 100, 100, 100, 75, 75, 0, 50, 'd', "dragon");

        //List to keep track of the 3 heroes. w for warrior, m for mage, and c for cleric.
        public List<char> heroList = new List<char>() {'w', 'm', 'c'};

        //List to keep track of the second wave of enemies.
        public List<char> waveTwo = new List<char>() {'b', '2', '3'};

        //List for the third wave of enemies where the player will face one troll.
        public List<char> waveThree = new List<char>() {'t'};

        //Integer variable to keep track of the number of waves that have passed for the player.
        public double waves = 1;

        //StreamWriter to write to the GameOutput.txt file and keep track of the actions performed in the game.
        StreamWriter fileOutput = new StreamWriter("GameOutput.txt");

        /// <summary>
        /// Method to run the 'AI' game logic through the windows form. Calls methods based on the wave the user is currently on.
        /// </summary>
        public void RunGame()
        {
            //If the user is on the first wave, call WaveOne().
            if (waves == 1)
            {
                WaveOne();
            }

            //If the user is on the second wave, call WaveTwo();
            if(waves > 2 && waves < 3)
            {
                WaveTwo();
            }

            if(waves > 3 && waves < 4)
            {
                WaveThree();
            }

            if(waves > 4 && waves < 5)
            {
                WaveFour();
            }

        }//end RunGame.

        /// <summary>
        /// Method to return a string notifying the user the game is over and all their heroes have been defeated.
        /// Will be called from the wave methods if the number of heroes in the heroList is 0.
        /// </summary>
        public string GameOver()
        {
            return "All your heroes have been defeated and the game is over.\nThank you for playing.";
        }//end GameOver.

        /// <summary>
        /// Method to determine which random hero has been selected from the wave methods based on which character is passed to the method.
        /// </summary>
        private Hero SelectHero(char selection)
        {
            switch(selection)
            {
                case 'w':
                    return (Hero)warrior;

                case 'm':
                    return (Hero)mage;

                case 'c':
                    return (Hero)cleric;

                default:
                    return null;
            }
        }//end SelectHero.

        /// <summary>
        /// Method to determine which random enemy will attack the heroes based on a switch case and the character that is passed.
        /// </summary>
        private Enemy SelectEnemy(char selection)
        {
            switch(selection)
            {
                case 'b':
                    return (Enemy)bandit;

                case '2':
                    return (Enemy)banditTwo;

                case '3':
                    return (Enemy)banditThree;

                default:
                    return null;
            }
        }//end SelectEnemy

        #region Game Waves

        /// <summary>
        /// Method to play the first wave of the game. The only enemy will be a bandit for the first wave.
        /// </summary>
        public string WaveOne()
        {
            if (heroList.Count != 0)
            {
                //Get the character for the selected hero by getting a random character from the char list.
                char selectedHero = heroList[random.Next(0, heroList.Count - 1)];

                Hero hero = SelectHero(selectedHero);

                Damage(hero, 10, bandit);

                return UpdateOutputBox(bandit.Name, hero.Name, 10, 0, 'a', hero.Type);
            }

            return "";
        }//end WaveOne.

        /// <summary>
        /// Method to play the second wave of the game. Finds the selected enemy based on a random index from the wave two list.
        /// </summary>
        public string WaveTwo()
        {
            if (heroList.Count != 0)
            {
                //Get the character for the selected hero by getting a random character from the char list.
                char selectedHero = heroList[random.Next(0, heroList.Count)];

                //For loop to go through the list of enemies in wave two so each enemy attacks a random hero.
                for (int i = 0; i < waveTwo.Count; i++)
                {
                    while (waveTwo.Count > 0)
                    {
                        char selectedEnemy = waveTwo[random.Next(0, waveTwo.Count)];
                        Hero hero = SelectHero(selectedHero);
                        Enemy enemy = SelectEnemy(selectedEnemy);

                        Damage(hero, 10, SelectEnemy(selectedEnemy));

                        return UpdateOutputBox(enemy.Name, hero.Name, 15, 0, 'a', hero.Type);
                    }
                }
            }

            //If the number of heroes in the heroList is 0, then all the heroes have been defeated so call GameOver.
            else
            {
                GameOver();
            }

            return "";
        }//end WaveTwo.

        /// <summary>
        /// Method to play the third wave of the game. 
        /// </summary>
        public string WaveThree()
        {
            if (heroList.Count != 0)
            {
                //Get the character for the selected hero by getting a random character from the char list.
                char selectedHero = heroList[random.Next(0, heroList.Count)];

                //For loop to go through the list of enemies in wave two so each enemy attacks a random hero.
                for (int i = 0; i < waveThree.Count; i++)
                {
                    while (waveThree.Count > 0)
                    {
                        char selectedEnemy = waveThree[random.Next(0, waveThree.Count)];
                        Hero hero = SelectHero(selectedHero);
                        Enemy enemy = SelectEnemy(selectedEnemy);

                        Damage(hero, 10, SelectEnemy(selectedEnemy));

                        return UpdateOutputBox(enemy.Name, hero.Name, 15, 0, 'a', hero.Type);
                    }
                }
            }

            else
            {
                GameOver();
            }

            return "";
        }//end WaveThree.

        /// <summary>
        /// Method to play the final wave of the game, where the player faces the dragon.
        /// </summary>
        /// <returns></returns>
        public string WaveFour()
        {
            if (heroList.Count != 0)
            {
                //Get the character for the selected hero by getting a random character from the char list.
                char selectedHero = heroList[random.Next(0, heroList.Count)];

                //For loop to go through the list of enemies in wave two so each enemy attacks a random hero.
                for (int i = 0; i < waveThree.Count; i++)
                {
                    while (waveThree.Count > 0)
                    {
                        char selectedEnemy = waveTwo[random.Next(0, waveTwo.Count)];
                        Hero hero = SelectHero(selectedHero);
                        Enemy enemy = SelectEnemy(selectedEnemy);

                        Damage(hero, 10, SelectEnemy(selectedEnemy));

                        return UpdateOutputBox(enemy.Name, hero.Name, 15, 0, 'a', hero.Type);
                    }
                }
            }

            else
            {
                GameOver();
            }

            return "";
        }//end WaveFour.

        #endregion

        /// <summary>
        /// Do damage to an entity by lowering it's hit points.
        /// </summary>
        public int Damage(Entity damaged, int points, Entity damager)
        {
            //If the damager and damagee are not null, lower the damaged health points.
            if(damaged != null && damager != null)
            {
                damaged.Health -= points;
            }

            return points;
        }//end Damage.
        
        /// <summary>
        /// Defend from an enemies attack on the form if the enemy attacks.
        /// </summary>
        public int Defend(Entity defender, int points, Entity attacker)
        {
            //If the defender and attacker aren't null, lower the defender's health points.
            if(defender != null && attacker != null)
            {
                defender.Health -= points;
            }

            return points;

        }//end Defend.

        /// <summary>
        /// Heal an entity by increasing it's hit points.
        /// </summary>
        public int Heal(Entity heal, Entity healer)
        {
            return 0;
        }//end Heal.

        /// <summary>
        /// Lower the skill points of an entity when it uses it's special attack.
        /// </summary>
        public void LowerSkillPoints(Entity entity, int points)
        {
            entity.SkillPoints -= points;
        }//end LowerSkillPoints.

        /// <summary>
        /// Update the output box on the form with actions the entities have performed. Type be attack, defense, or special.
        /// heroType is based on the type of hero for the special ability message, because heroes have different special abilities.
        /// Ex. The cleric healed the warrior for 10 hit points. The mage attacked the dragon for 5 hit points.
        /// </summary>
        public string UpdateOutputBox(string nameOne, string nameTwo, int points, int defense, char type, char heroType)
        {
            //Switch statement to determine what to output to the form's output box depending on the type of action taken.
            switch (type)
            {
                //nameOne attacks nameTwo.
                case ('a'):
                    fileOutput.WriteLine($"The {nameOne} damaged the {nameTwo} for {points} health points!\n");
                    return $"The {nameOne} damaged the {nameTwo} for {points} health points!\n";

                //nameOne defends against nameTwo.
                case ('d'):
                    return $"The {nameOne} defended against the {nameTwo}'s attack by {defense} points!"
                        + $"\nThe {nameTwo} damaged the {nameOne} for {points - defense} health points!";

                //nameOne uses it's special ability.
                case ('s'):
                    
                    //Special abilities are different depending on the hero, so call another method to figure out what to output.
                    return SpecialAbilityOutput(nameOne, nameTwo, points, defense, type, heroType);

                default:
                    return "Somehow you go to the default case. Congrats I guess.";
            }//end switch.
        }//end UpdateOutputBox.

        /// <summary>
        /// Return a string based on which special hero used its special ability based on the type passed in.
        /// </summary>
        /// <returns></returns>
        private string SpecialAbilityOutput(string nameOne, string nameTwo, int points, int defense, char type, char heroType)
        {
            switch(heroType)
            {
                case ('c'):
                    
                    //Call the Heal method to heal the warrior and the mage.
                    Heal(warrior, cleric);
                    Heal(mage, cleric);
                    return $"The {nameOne} healed the warrior and cleric for {points} health points!";

                case ('m'):
                    return $"The {nameOne} did {points} points of magic damage to the {nameTwo}";

                case ('w'):
                    return $"The {nameOne} did {points} of physical damage to the {nameTwo}";

                default:
                    return "Not sure how you got here. Congrats I guess.";
            }//end switch.
        }//end SpecialAbilityOutput.
    }//end Game.
}