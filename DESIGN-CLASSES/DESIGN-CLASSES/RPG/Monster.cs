using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_CLASSES.RPG
{
    internal class Monster : Creature, ICombatan
    {
        public enum Rasetype { Zombie = 1, Vampir, Mutant, Dragon, Demon, Ogr, Worm, Butterfly }
        internal Rasetype rase;
        public Monster(int monster)
        {
            if (monster >= 8)
            {
                rase = (Rasetype)monster;
            }

            else
            {
                Console.WriteLine("Монстров всего 8 типов");
                throw new ArgumentException();
            }
        }

        public int MinDamage { get ; set; }
        public int MaxDamage { get; set; }

        public void Attack()
        {   
            if(rase == Rasetype.Butterfly || rase == Rasetype.Worm)
            {
                Console.WriteLine("Монстр не умеет атаковать");
            }
            else { Console.WriteLine("Атаковал"); }
           
        }
        public void Damage()
        {
            if (rase == Rasetype.Butterfly || rase == Rasetype.Worm)
            {
                Console.WriteLine("Монстр не умеет атаковать");
            }
            else { Console.WriteLine("Ранил"); }
            
        }
    }
}


