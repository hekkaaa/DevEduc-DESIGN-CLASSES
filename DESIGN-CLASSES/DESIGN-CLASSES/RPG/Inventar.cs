using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DESIGN_CLASSES.RPG.Item;

namespace DESIGN_CLASSES.RPG
{
    internal class Inventar
    {   
        public int _intpouch = 4;
        string Name { get; set; }
        public LinkedList<typeIthem> pouch = new LinkedList<typeIthem>(); // сумка инвентаря?

        public void AddPouch(typeIthem items) 
        {   
            if(_intpouch == 0)
            {
                Console.WriteLine("Сумка заполнена милорд!");
            }
            else
            {
                pouch.AddLast(items);
                _intpouch--;
            }
           
        }

        public void GetPouch()
        {   
            Console.Write("В сумке: ");
            if(pouch.Count == 0)
            {
                Console.Write("Пусто");
            }
            foreach(typeIthem item in pouch)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        public void RemovePouch()
        {

        }
    }
}
