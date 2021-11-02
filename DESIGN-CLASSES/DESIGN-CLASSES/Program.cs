using System;

namespace DESIGN_CLASSES
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Moster gg = new Moster();
            Console.WriteLine(gg.GetInfo);


        }

    }
}
