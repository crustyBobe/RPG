using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Class to make an instance of a hero in Game.cs to be played against as the Windows Form. Contains a constructor to create an instance of the heroes, and properties
/// for each of the hero's values. Extends Entity.cs so it can be instantiated as one.
/// </summary>
namespace FinalProject
{
    public class Hero : Entity
    {
        int health;
        int physicalStrength;
        int magicStrength;
        int attack;
        int physicaDefense;
        int magicDefense;
        int skillPoints;
        int speed;
        char type;
        string name;

        /// <summary>
        /// Constructor for a hero object to be instantiated in the Game.cs class. Will create 3 heroes, each with differing abilities and values.
        /// Include the : base underneath the definition so the heroes can be instantiated as an entity object because enemy extends entity.
        /// </summary>
        public Hero(int health, int physicalStrength, int magicStrength, int attack, int physicaDefense, int magicDefense, int skillPoints, int speed, char type, string name)
            :base(health, physicalStrength, magicStrength, attack, physicaDefense, magicDefense, skillPoints, speed, type, name)
        {
            this.Health = health;
            this.PhysicalStrength = physicalStrength;
            this.MagicStrength = magicStrength;
            this.Attack = attack;
            this.PhysicaDefense = physicaDefense;
            this.MagicDefense = magicDefense;
            this.SkillPoints = skillPoints;
            this.Speed = speed;
            this.Type = type;
            this.Name = name;
        }//end Hero.

        //Properties for each of the hero's variable values.
        #region Properties

        public int Health { get => health; set => health = value; }
        public int PhysicalStrength { get => physicalStrength; set => physicalStrength = value; }
        public int MagicStrength { get => magicStrength; set => magicStrength = value; }
        public int Attack { get => attack; set => attack = value; }
        public int PhysicaDefense { get => physicaDefense; set => physicaDefense = value; }
        public int MagicDefense { get => magicDefense; set => magicDefense = value; }
        public int SkillPoints { get => skillPoints; set => skillPoints = value; }
        public int Speed { get => speed; set => speed = value; }
        public char Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }

        #endregion

        //Methods to perform the hero's special abilities. Will be called through the switch statement in SpecialAbility.
        #region Ability Methods

        /// <summary>
        /// Method to perform the hero's special ability. Takes in type as a parameter to detemine which ability to perform.
        /// </summary>
        public void SpecialAbility(char type, Enemy selectedEnemy)
        {
            //Switch case to determine which hero is performing their ability and which method should be called.
            switch (type)
            {
                //Selected hero is the warrior.
                case 'w':
                    //Call WarriorAbility to perform the special physical attack on the passed enemy.
                    WarriorAbility(selectedEnemy);
                    break;

                //Selected hero is the mage.
                case 'm':
                    //Call MageAbility to perform the special magic attack on the passed enemy.
                    MageAbility(selectedEnemy);
                    break;

                //Selected hero is the cleric.
                case 'c':
                    //Call ClericAbility to heal the other party members.
                    ClericAbility();
                    break;

                //Default switch case.
                default:
                    //Shouldn't be able to get here.
                    break;
            }
        }//end SpecialAbility.

        /// <summary>
        /// Perform the warrior's ability on the selected enemy. Lower's their health bar from a physical attack.
        /// </summary>
        private void WarriorAbility(Enemy selectedEnemy)
        {

        }//end WarriorAbility.

        /// <summary>
        /// Perform the mage's ability on the selected enemy. Lower's their health bar from a magic attack.
        /// </summary>
        private void MageAbility(Enemy selectedEnemy)
        {

        }//end MageAbility.

        /// <summary>
        /// Perform the cleric's ability. Heal the other party members and itself? Need to check on this.
        /// </summary>
        private void ClericAbility()
        {

        }//end ClericAbility.

        #endregion

    }//end Hero.
}