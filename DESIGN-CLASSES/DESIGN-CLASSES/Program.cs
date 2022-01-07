using DESIGN_CLASSES.Collection;
using DESIGN_CLASSES.RPG;
using System;
using System.Collections.Generic;

namespace DESIGN_CLASSES
{
    class Program
    {
        static void Main(string[] args)
        {

            /// ********** ДЗ Unit_2: (базовый дизайн классов - хелпер, OPD-класс, полноценный класс) ****

            //// Пример для заполнения PASSPORT
            //Passport test = new Passport(4444,555231,"УВД",new DateTime(1999,12,12),true,"Гоша Мраза","female");
            //Console.WriteLine(test.Print);
            //// Через Свойства

            //test.Issued = "УВД ОМСКОЙ ОБЛАСТИ";
            //test.Serial = 4134;
            //test.Number = 555113;
            //test.IssuedDate = new DateTime(1999, 12, 25);
            //test.Issued = true;
            //test.FIO = "Маликов Вадим Сергеевич";
            //test.Gender = "male";
            //Console.WriteLine(test.Print);


            //// MONSTER
            //// Пример:
            //Moster test = new Moster(true);
            //Console.WriteLine(test.GetInfo);
            //Console.WriteLine(test.GetAttack(100));
            //test.Wounds(23);
            //IOHelper.Line(50);
            //Console.WriteLine(test.GetInfo);
            //test.Heal();
            //Console.WriteLine(test.GetInfo);

            // ********************************

            /// ********** ДЗ Unit_2 (наследование, интерфейсы)
            //RPG.Monster zombie = new RPG.Monster(8);
            //RPG.Hero zombieHero = new RPG.Hero(3);

            //Console.WriteLine(zombieHero.rase);
            //zombieHero._pocket.GetPouch();

            //Item item = new Item();
            //var te = item.Weapon(1);
            //zombieHero._pocket.AddPouch(te);
            //zombieHero._pocket.AddPouch(te);
            //zombieHero._pocket.AddPouch(te);
            //zombieHero._pocket.AddPouch(te);
            //zombieHero._pocket.AddPouch(te);

            //zombieHero._pocket.GetPouch();

            //Console.WriteLine(zombieHero._pocket._intpouch);

            // ********************************
            //List<string> list = new List<string>();
            //Console.WriteLine(list.Capacity);
            //Console.WriteLine(list.Count);


            //list.Add("Meow0");
            //Console.WriteLine(list.Capacity);
            //Console.WriteLine(list.Count);
            //list.Clear();
            //Console.WriteLine(list.Capacity);
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list[0]);


            MyList<string> list = new MyList<string>();
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            list.Add("e");
            list.Add("f");
            list.Add("g");
            list.Add("h");
            list.Add("i");
            list.Add("dsad");
            list.Add("k");

            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            list.Clear();
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            Console.WriteLine(list[0]);



        }

    }
}
