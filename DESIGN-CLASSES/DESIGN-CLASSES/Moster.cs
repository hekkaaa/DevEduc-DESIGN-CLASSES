using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_CLASSES
{
    public class Moster
    {
        Random rnd = new Random();
        string name;
        public enum MonsterType { Aspis = 1, Regulus, Vampir, Harpia, Mutant, Dragon, Demon, Ogr };
        MonsterType monsterType;
        int hp;
        int maxHP;
        int minAttack;
        int maxAttack;
        string warCry;
        string dieCry;

        // Перегрузки
        public Moster(bool isRandom = false)
        {
            if (isRandom == false)
            {
                Name = IOHelper.InputString("Имя Монстра");
                Monst = (MonsterType)IOHelper.InputInt("Номер монстра от 1 до 8 (Aspis, Regulus, Vampir, Harpia, Mutant, Dragon, Demon, Ogr)");
                MaxHP = IOHelper.InputInt("Максимальное количество жизней (до 500)");
                this.hp = this.maxHP; // Обычно персонажи по умолчанию все здоровы.
                MinAttack = IOHelper.InputInt("Минимальная атака (1-10)");
                MaxAttack = IOHelper.InputInt("Максимальная атака (20-100)");
                WarCry = IOHelper.InputString("Боевой клич");
                DieCry = IOHelper.InputString("Клич смерти");
                Console.Clear();
            }
            else
            {
                string[] nameRandom = { "Колинет", "Бхолгреарс", "Ролмел", "Алеида", "Укаэриутт","Икеок",
                "Врацдер", "Браулгон", "Уалбил", "Джортаэрел", "Брицот","Асцелина", "Араиа","Балтхиол",
                "Грефаитиос", "Линавер", "Иошихара", "Трезрол"};

                string[] voice = {"oerulir uerren lumos","mizol oufama ghealedoi","ganoler lalum iruno",
                "ota radhoebou uenurrus","nolu li aimur","ARRRRRRRR!","ratrono veonnen uphahro",
                "niso onon ghiena","ioglaemum uebra airo","mucimin iume ounnin","dhaumumo iapronis au",
                "ammun luhwala qiphi","omor rigeapan a","licen uephammus oa","lasulan rara sagulen",
                "eucho uva re","urim linukem annar","remacal rauflamiu oprymmas","reba lorimin lo",
                "ujuihum earummon ilu","lekeo oudreammen lomymo","numbaran eullum micleunu"};

                this.name = nameRandom[rnd.Next(0, nameRandom.Length - 1)];
                this.maxHP = rnd.Next(0, 500);
                this.hp = maxHP; // Обычно персонажи по умолчанию все здоровы.
                this.minAttack = rnd.Next(1, 11);
                this.maxAttack = rnd.Next(20, 101);
                this.warCry = voice[rnd.Next(0, nameRandom.Length - 1)];
                this.dieCry = voice[rnd.Next(0, nameRandom.Length - 1)];
                this.monsterType = (MonsterType)rnd.Next(1, 9);
            }

        }

        public Moster(string name, int maxHP, int minAttack, int maxAttack, string warCry, string dieCry)
        {
            this.name = name;
            this.maxHP = maxHP;
            this.hp = maxHP; // Обычно персонажи по умолчанию все здоровы.
            this.minAttack = minAttack;
            this.maxAttack = maxAttack;
            this.warCry = warCry;
            this.dieCry = dieCry;
        }

        // Свойства
        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value)) { this.name = "Unit"; }
                else this.name = value;
            }
        }

        public MonsterType Monst
        {
            get { return this.monsterType; }
            set
            {
                if ((int)value > 8 || (int)value < 1)
                {
                    this.monsterType = (MonsterType)rnd.Next(1, 9);
                }
                else
                {
                    this.monsterType = value;
                }
            }
        }

        public int HP
        {
            get { return this.hp; }
            set
            {
                if (value > this.maxHP || value < 0) Console.WriteLine("HP FULL/LOW");
                else { this.hp = value; }
            }
        }

        public int MaxHP {
            get { return this.maxHP; }
            set
            {
                if (value > 500) { this.maxHP = 500; }
                else if (value < 0) { this.maxHP = 1; }
                else { this.maxHP = value; }
            }
        }

        public int MinAttack
        {
            get { return this.minAttack; }
            set
            {
                if (value > 10) { this.minAttack = 10; }
                else if (value < 1) { this.minAttack = 1; }
                else { this.minAttack = value; }
            }
        }

        public int MaxAttack
        {
            get { return this.maxAttack; }
            set
            {
                if (value > 100) { this.maxAttack = 100; }
                else if (value < 20) { this.maxAttack = 20; }
                else { this.maxAttack = value; }
            }
        }

        public string WarCry
        {
            get { return this.warCry; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("No data has been entered");
                    this.WarCry = "ARRRRRRRR!";
                }
                else this.warCry = value;
            }
        }

        public string DieCry
        {
            get { return this.dieCry; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("No data has been entered");
                    this.WarCry = "MEOW!";
                }
                else this.dieCry = value;
            }
        }

        // ******** 2 lvl properties

        public string TypeText
        {
            get
            {
                if (this.monsterType == MonsterType.Vampir) { return "Вампир"; }
                else if (this.monsterType == MonsterType.Regulus) { return "Василиск"; }
                else if (this.monsterType == MonsterType.Ogr) { return "Огр"; }
                else if (this.monsterType == MonsterType.Mutant) { return "Мутант"; }
                else if (this.monsterType == MonsterType.Harpia) { return "Гарпия"; }
                else if (this.monsterType == MonsterType.Dragon) { return "Дракон"; }
                else if (this.monsterType == MonsterType.Aspis) { return "Аспид"; }
                else { return "Демон"; } 
            }
        }

   
        public bool IsDie
        {
            get { if(this.hp <= 0) return true; return false; }
        }

        public string GetInfo
        {
            get {
                return $"Имя: {this.name}\n" +
                  $"Количество жизней: {this.hp}\n" +
                  $"Максимум HP: {this.maxHP}\n" +
                  $"Тип монстра: {this.monsterType}\n" +
                  $"Минимальная атака: {this.minAttack}\n" +
                  $"Максимальная атака: {this.maxAttack}\n";
            }
        }

        // Methods

        public int GetAttack(int bonus)
        {
            int attack = rnd.Next(this.minAttack, this.maxAttack+1) + bonus;
            return attack;
        }
        public void Wounds(int damage)
        {
            this.hp = this.hp - damage;
            if (this.hp < 0) { this.hp = 0;}
        }
        public void Heal()
        {
            int heal = this.maxHP - this.hp;
            this.hp += heal;
        }
    }
}
