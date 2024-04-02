using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    public class IdNumber
    {
        public int number1;
        public IdNumber(int number1)
        {
            this.number1 = number1;
        }
        public override string ToString()
        {
            return number1.ToString();
        }
        public override bool Equals(object? obj)
        {
            if (obj is IdNumber n)
                return this.number1 == n.number1;
            return false;
        }
    }
    public class MusicalInstrument : IInit, IComparable, ICloneable
    {
        public IdNumber id;
        public static int cnt_MusicalInstrument;
        static string[] Titles = { "Flight", "Vestion", "Fender", "Epiphone", "Yamah", "Fazioliiiiiiii", "Casio", "Hohner", "Kawai", "Becker", "Boss", "Kurzweil", "Sennheiser", "Shure", "Sigma", "Roland", "Suzuki", "Crafter", "Veston",
        "Flight2", "Vestion2", "Fender2", "Epiphone2", "Yamah2", "Fazioliiiiiiii2", "Casio2", "Hohner2", "Kawai2", "Becker2", "Boss2", "Kurzweil2", "Sennheiser2", "Shure2", "Sigma2", "Roland2", "Suzuki2", "Crafter2", "Veston2"};
        protected string title;
        protected Random rnd = new Random();
        public string Title
        {
            get => title;
            set
            {
                title = value;
            }
        }
        public MusicalInstrument()
        {
            Title = "не определено";
            cnt_MusicalInstrument++;
            id = new IdNumber(1);
        }
        public MusicalInstrument(string title, int number1)
        {
            Title = title;
            cnt_MusicalInstrument++;
            id = new IdNumber(number1);
        }
        public override bool Equals(object obj)
        {
            MusicalInstrument s = obj as MusicalInstrument;
            if (s != null)
            {
                return s.id.number1 == this.id.number1 && s.Title == this.Title;
            }
            else { return false; }
        }
        public override string ToString()
        {
            return $"ID: {id} Название: {Title}";
        }
        public void Show()
        {
            Console.WriteLine($"ID: {id}, Название инструмента: {Title}");
        }
        public virtual void VirtualShow()
        {
            Console.WriteLine($"ID: {id}, Название инструмента: {Title}");
        }
        public virtual void Init()
        {
            Console.WriteLine("Введите id: ");
            try
            {
                id.number1 = int.Parse(Console.ReadLine());
            }
            catch 
            {
                id.number1 = 0;
            }
            Console.WriteLine("Введите название инструмента: ");
            Title = Console.ReadLine();
        }
        public virtual void RandomInit()
        {
            Title = Titles[rnd.Next(0, 36)];
            id.number1 = rnd.Next(1, 10000);
        }
        public int CompareTo(object? obj)
        {
            if (obj == null)
            {
                return -1;
            }
            if (obj is not MusicalInstrument)
            {
                return 0;
            }
            MusicalInstrument p = obj as MusicalInstrument;
            return String.Compare(this.Title, p.Title);
        }
        public object Clone()
        {
            return new MusicalInstrument(Title, id.number1);
        }
        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 61;
                hash = hash * 23 + (Title.GetHashCode() * id.number1.GetHashCode());
                return hash;
            }
        }
    }
}