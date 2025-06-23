using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AppToLearn
{
    public class Character
    {
        public string Type { get; set; }
        public int Hp { get; set; }
        public int Mana { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }

        public int Level { get; set; } = 1; // Default level is 1
        public int Experience { get; set; }

        public Character(string type, int hp, int mana, int defense, int attack)
        {
            Type = type;
            Hp = hp;
            Mana = mana;
            Defense = defense;
            Attack = attack;
        }

        public string GetStats()
        {
            return $"{Type} \nHP: {Hp} \nMana: {Mana}\nDefense: {Defense}\nAttack: {Attack}\nLevel: {Level}\nExperience: {Experience}";

        }

      

        public void TakeDamage(int damage)
        {
            Hp -= Math.Max(1, damage);
            if (Hp < 0)
            {
                Hp = 0;
                //Die();
            }
                
        }

        public int DoDamage(Enemy target)
        {
            int damage = Math.Max(1, this.Attack - target.Defense);
            target.TakeDamage(damage);
            return damage;
        }


        public void GainExperience(int amount)
        {
            Experience += amount;
            while (Experience >= Level * 100)
            {
                Experience -= Level * 100;
                LevelUp();
            }
        }

        public void LevelUp()
        {
            Level++;
            Hp += 10; // Increase HP on level up
            Mana += 5; // Increase Mana on level up
            Defense += 2; // Increase Defense on level up
            Attack += 3; // Increase Attack on level up
            Experience = 0; // Reset experience after leveling up

            Debug.WriteLine($"{Type} leveled up to Level {Level}!");
        }
    }
}
