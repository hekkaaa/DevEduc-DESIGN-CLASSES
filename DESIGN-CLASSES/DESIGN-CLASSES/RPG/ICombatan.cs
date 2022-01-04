using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_CLASSES.RPG
{
    internal interface ICombatan
    {
        public void Attack();
      
        public void Damage();
    
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
    }
}
