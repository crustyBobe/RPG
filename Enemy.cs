using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Class to make an instance of an enemy in Game.cs to be played against on the Windows Form. Contains a constructor to create an instance of the enemies, and properties
/// for each of the enemy's values. Extends Entity.cs so it can be instantiated as one.
/// </summary>
namespace FinalProject
{
    public class Enemy : Entity
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
        /// Constructor for an enemy object. There will be 7 enemies, each instantiated in Game.cs and each with their own values and abilities.
        /// Includes the : base underneath the definition so the enemies can be instantiated as an entity object because enemy extends entity.
        /// </summary>
        public Enemy(int health, int physicalStrength, int magicStrength, int attack, int physicaDefense, int magicDefense, int skillPoints, int speed, char type, string name)
            : base(health, physicalStrength, magicStrength, attack, physicaDefense, magicDefense, skillPoints, speed, type, name)
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
        }//end Enemy.

        //Properties for each of the enemy's variables.
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

    }//end Enemy.
}