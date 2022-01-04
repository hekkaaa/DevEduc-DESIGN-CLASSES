using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_CLASSES.RPG
{
    internal class Humanoid : Creature
    {

        internal enum Rase { Ork = 1, Human, Elf, Dworf, Tauren }
        public Rase rase;


        internal Humanoid(int rases)
        {
            if (rases <= 5)
            {
                rase = (Rase)rases;
            }

            else
            {
                Console.WriteLine("Монстров всего 5 типов");
                throw new ArgumentException();
            }
        }


    }
}
