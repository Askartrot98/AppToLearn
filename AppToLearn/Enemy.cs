using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppToLearn
{
    public class Enemy
    {

        public string Type { get; set; }
        public int Hp { get; set; }
        public int Mana { get; set; }
        public int Defense { get; set; }
        public int Attack { get; set; }

        public int Experience { get; set; }
        public Enemy(string type, int hp, int mana, int defense, int attack, int experience)
        {
            Type = type;
            Hp = hp;
            Mana = mana;
            Defense = defense;
            Attack = attack;
            Experience = experience;
        }
        public void TakeDamage(int damage)
        {
            Hp -= Math.Max(1, damage); // almeno 1 danno
            if (Hp < 0) Hp = 0;
        }

        public int DoDamage(Character target)
        {
            int damage = Math.Max(1, this.Attack - target.Defense);
            target.TakeDamage(damage);
            return damage;
        }


        public string GetEnemyStats()
        {
            return $"{Type} \nHP: {Hp} \nMana: {Mana}\nDefense: {Defense}\nAttack: {Attack}\nExperience: {Experience}";
        }
    }
}
