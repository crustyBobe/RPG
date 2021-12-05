using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Entity class to be used as the parent class for both Enemy.cs and Hero.cs. Will be used to instantiate Enemies and Heroes in Game.cs to be played as or against.
/// </summary>
namespace FinalProject
{
    public class Entity
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
        /// Constructor for a basic entity object. Both the hero and enemy classes extend entity, so entity will be used to create hero and enemy objects in Game.cs.
        /// </summary>
        public Entity(int health, int physicalStrength, int magicStrength, int attack, int physicaDefense, int magicDefense, int skillPoints, int speed, char type, string name)
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

        //Properties for each of the entity's variable values.
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
    }//end Entity.
}