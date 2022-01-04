using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_CLASSES.RPG
{
    internal abstract class Creature
    {
        public int _intelligence = 1;
        public string _name;
        public int _hp = 100;
        public int _maxHP = 100;
        public int _minDamage;
        public int _maxDamage;
        public bool Live { get; set; }
       
    }
}
