using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    abstract class Human
    {

        private string _name;
        private string _surname;
        private string _patronimic;
        private DateTime _birthDate;
        public Nationality nationality;
        public Gender gender;
        public string getName()
        {
            return _name;
        }
        public string getSurname()
        {
            return _surname;
        }
        public string getPatronimic()
        {
            return _patronimic;
        }
        public void setName(string newName)
        {
            if (newName.Length >= 2 && newName.Length <= 20)
            {
                _name = newName;
            }
            else
            {
                throw new ArgumentException("Имя либо слишком короткое либо длинное.");
            }
        }
        public void setSurname(string newSurname)
        {
            if (newSurname.Length >= 4 && newSurname.Length <= 24)
            {
                _surname = newSurname;
            }
            else
            {
                throw new ArgumentException("Фамилия либо слишком короткое либо длинное.");
            }
        }
        public void setPatronimic(string newPatronimic)
        {
            if (newPatronimic.Length >= 2 && newPatronimic.Length <= 20)
            {
                _patronimic = newPatronimic;
            }
            else
            {
                throw new ArgumentException("Имя либо слишком короткое либо длинное.");
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                this.setName(value); //value - new data
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                this.setSurname(value); //value - new data
            }
        }
        public string Patronimic
        {
            get
            {
                return _patronimic;
            }
            set
            {
                this.setPatronimic(value); //value - new data
            }
        }
        public DateTime BirthDate
        {
            private set
            {
                if (value <= DateTime.Now && value > DateTime.Now.AddYears(-104))
                {
                    _birthDate = value;
                }
                else
                {
                    throw new ArgumentException("Человек не нашего поколения.");
                }
            }
            get
            {
                return _birthDate;
            }
        }
        public Human()
        {
            Name = "Name";
            Surname = "Surname";
            Patronimic = "Patronimic";
            BirthDate = new DateTime(1991, 1, 1);
            gender = default;
            nationality = default;
        }
        public Human(string name, string surname, string patron, DateTime birth, Gender gen, Nationality nat)
        {
            Name = name;
            Surname = surname;
            Patronimic = patron;
            BirthDate = birth;
            gender = gen;
            nationality = nat;
        }
        public override string ToString()
        {
            return $"Human: \n\t" +
                $"Name: {Name};\n\t" +
                $"Surname: {Surname};\n\t" +
                $"Patronimic: {Patronimic};\n\t" +
                $"Gender: {gender};\n\t" +
                $"Nationality: {nationality};\n\t" +
                $"Birth Date: {BirthDate.ToShortDateString()}\n\t";
        }
        public virtual void print() //possible to redefine in children class
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(this);
            Console.ResetColor();
        }
    }
}
