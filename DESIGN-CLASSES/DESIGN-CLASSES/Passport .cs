using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESIGN_CLASSES
{
    class Passport
    {
        int serial;
        int number;
        string issued;
        DateTime IssuedDate;
        bool IsActive;
        string FIO;
        string gender;

        public Passport()
        {
            IOHelper.PrintConsoleColor("Форма для заполнения: ", 2);
            Console.WriteLine($"Серия: {this.serial}\nНомер: {this.number}\n" +
            $"Дата выдачи: {this.IssuedDate}\n" +
            $"ФИО: {this.FIO}\nПол: {this.gender}\n" +
            $"Статус документа: {this.IsActive}");
            IOHelper.Line(30);
        }

        // Свойства
        public string Print
        {
            get
            {
                return $"Серия: { this.serial}\nНомер: { this.number}\n" +
                $"Дата выдачи: {this.IssuedDate.ToShortDateString()}\n" +
                $"Где выдан: {this.issued}\n" +
                $"ФИО: {this.FIO}\nПол: {this.gender}\n" +
                $"Статус документа: {this.IsActive}";
            }
        }

        public int Serial
        {
            get { return this.serial; }
            set
            {
                string tmp = value.ToString();
                if (tmp.Length > 4 || tmp.Length < 4) Console.WriteLine("ERROR length serial nuber");
                else this.serial = value;
            }
        }

        public int Number
        {
            get { return this.number; }
            set
            {
                string tmp = value.ToString();
                if (tmp.Length > 6 || tmp.Length < 6) Console.WriteLine("ERROR length serial nuber");
                else this.number = value;
            }
        }

        public string Issued
        {
            get{ return this.issued; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("No data has been entered");
                }
                else this.issued = value;
            }
        }
        public DateTime issuedDate
        {
            get { return IssuedDate; }
            set
            {
                DateTime BaseRf = new DateTime(1991, 12, 25);
                if (value >= BaseRf && value <= DateTime.Today) this.IssuedDate = value; 
                else Console.WriteLine("Date or interval entered error");  
            }
        }

        public bool isActive { get { return IsActive; } set { this.IsActive = value; } }
        public string Gender
        {
            get 
            { 
                return gender; 
            }
            set
            {
                if(value == "male".ToLower() || value.ToLower() == "female") this.gender = value;  
                else Console.WriteLine("Error format gender");
            }
        }

        public string fio
        {
            get { return this.FIO; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("No data has been entered");
                }
                else this.FIO = value;
            }
        }

    }
}
