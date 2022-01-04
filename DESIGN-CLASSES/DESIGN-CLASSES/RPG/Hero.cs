using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_CLASSES.RPG
{
    internal class Hero : Humanoid, ICombatan
    {   
        public Inventar _pocket = new Inventar();
        public Hero(int rases) : base(rases) 
        {
        }

        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public void Attack()
        {   
            Console.WriteLine("Атака");
        }

        public void Damage()
        {
            Console.WriteLine("Урон");
        }
    }
}
