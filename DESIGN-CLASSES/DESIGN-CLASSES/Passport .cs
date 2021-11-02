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
        DateTime issuedDate;
        bool isActive;
        string fio;
        string gender;

        public Passport(int serial, int number, string issued, DateTime issuedDate, bool isActive, string fio, string gender)
        {
            this.serial = serial;
            this.number = number;
            this.issued = issued;
            this.issuedDate = issuedDate;
            this.isActive = isActive;
            this.fio = fio;
            this.gender = gender;
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
                if (tmp.Length > 4 || tmp.Length < 4) throw new ArgumentOutOfRangeException("ERROR length serial nuber");
                else this.serial = value;
            }
        }

        public int Number
        {
            get { return this.number; }
            set
            {
                string tmp = value.ToString();
                if (tmp.Length > 6 || tmp.Length < 6) throw new ArgumentOutOfRangeException("ERROR length serial nuber");
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
                    throw new NullReferenceException("No data has been entered (Строка пустая)");
                }
                else this.issued = value;
            }
        }
        public DateTime IssuedDate
        {
            get { return issuedDate; }
            set
            {
                DateTime BaseRf = new DateTime(1991, 12, 25);
                if (value >= BaseRf && value <= DateTime.Today) this.issuedDate = value; 
                else throw new ArgumentOutOfRangeException("Date or interval entered error");  
            }
        }

        public bool IsActive { get { return isActive; } set { this.isActive = value; } }
        public string Gender
        {
            get 
            { 
                return gender; 
            }
            set
            {
                if(value == "male".ToLower() || value.ToLower() == "female") this.gender = value;  
                else throw new Exception("Error format gender");
            }
        }

        public string FIO
        {
            get { return this.fio; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("No data has been entered (Строка пустая)");
                }
                else this.fio = value;
            }
        }

    }
}
