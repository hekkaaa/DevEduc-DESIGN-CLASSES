using System;

namespace DESIGN_CLASSES
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Пример для заполнения PASSPORT
            //Passport test = new Passport();

            //test.Issued = "УВД ОМСКОЙ ОБЛАСТИ";
            //test.Serial = 4134;
            //test.Number = 555113;
            //test.issuedDate = new DateTime(1999,12,25);
            //test.isActive = true;
            //test.fio = "Маликов Вадим Сергеевич";
            //test.Gender = "male";
            //Console.WriteLine(test.Print);


            //// MONSTER
            // Пример:
            Moster test = new Moster(true);
            Console.WriteLine(test.GetInfo);
            Console.WriteLine(test.GetAttack(100));
            test.Wounds(23);
            IOHelper.Line(50);
            Console.WriteLine(test.GetInfo);
            test.Heal();
            Console.WriteLine(test.GetInfo);
   
        }

    }
}
